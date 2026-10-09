using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Ports;
using System.Text;
using SerialPortLibrary;

// 32-bit .NET Framework bridge for the vendor's 32-bit MCC4DLL.dll.
// Protocol: request = id<TAB>command<TAB>arg...; response = id<TAB>OK|ERR<TAB>payload
internal static class ControllerBridge
{
    private static SPLibClass card = new SPLibClass();
    private static SerialPort temperaturePort;

    private static int TemperatureAddress(string name)
    {
        int raw;
        switch (name)
        {
            case "current_temp": raw = 58505; break;
            case "set_temp": raw = 58506; break;
            case "P": raw = 58507; break;
            case "I": raw = 58508; break;
            case "D": raw = 58509; break;
            case "cycle": raw = 58510; break;
            case "power_limit": raw = 58524; break;
            case "comp_offset": raw = 58551; break;
            case "hysteresis": raw = 58527; break;
            case "seg1_temp": raw = 3001; break;
            case "seg1_heat_time": raw = 3151; break;
            case "seg1_hold_time": raw = 3051; break;
            case "seg1_power": raw = 3101; break;
            case "run": raw = 10011; break;
            case "pause": raw = 10013; break;
            default: throw new ArgumentException("Unknown temperature controller item: " + name);
        }
        return raw < 40001 ? raw - 1 : raw - 40001;
    }

    private static void OpenTemperature(string port)
    {
        if (temperaturePort != null && temperaturePort.IsOpen &&
            String.Equals(temperaturePort.PortName, port, StringComparison.OrdinalIgnoreCase)) return;
        CloseTemperature();
        SerialPort candidate = new SerialPort(port, 9600, Parity.None, 8, StopBits.One);
        candidate.Handshake = Handshake.None;
        candidate.ReadTimeout = 1000;
        candidate.WriteTimeout = 1000;
        try
        {
            candidate.Open();
            temperaturePort = candidate;
        }
        catch
        {
            candidate.Dispose();
            throw;
        }
    }

    private static void CloseTemperature()
    {
        if (temperaturePort == null) return;
        try { if (temperaturePort.IsOpen) temperaturePort.Close(); }
        finally { temperaturePort.Dispose(); temperaturePort = null; }
    }

    private static ushort TemperatureCrc(byte[] data, int length)
    {
        ushort crc = 0xffff;
        for (int i = 0; i < length; i++)
        {
            crc ^= data[i];
            for (int bit = 0; bit < 8; bit++)
                crc = (ushort)((crc & 1) != 0 ? (crc >> 1) ^ 0xa001 : crc >> 1);
        }
        return crc;
    }

    private static byte[] ExchangeTemperature(byte function, byte[] payload, int expectedLength)
    {
        if (temperaturePort == null || !temperaturePort.IsOpen)
            throw new InvalidOperationException("Temperature controller is not connected.");
        ushort crc = TemperatureCrc(payload, payload.Length);
        byte[] request = new byte[payload.Length + 2];
        Array.Copy(payload, request, payload.Length);
        request[request.Length - 2] = (byte)(crc & 0xff);
        request[request.Length - 1] = (byte)(crc >> 8);
        temperaturePort.DiscardInBuffer();
        temperaturePort.Write(request, 0, request.Length);

        List<byte> response = new List<byte>();
        response.Add((byte)temperaturePort.ReadByte());
        response.Add((byte)temperaturePort.ReadByte());
        int responseLength = response[1] == (byte)(function | 0x80) ? 5 : expectedLength;
        while (response.Count < responseLength)
            response.Add((byte)temperaturePort.ReadByte());
        byte[] bytes = response.ToArray();
        if (bytes[0] != payload[0]) throw new InvalidOperationException("Unexpected Modbus device address.");
        ushort responseCrc = TemperatureCrc(bytes, bytes.Length - 2);
        if (bytes[bytes.Length - 2] != (byte)(responseCrc & 0xff) ||
            bytes[bytes.Length - 1] != (byte)(responseCrc >> 8))
            throw new InvalidOperationException("Invalid Modbus response checksum.");
        if (bytes[1] == (byte)(function | 0x80))
            throw new InvalidOperationException("Modbus exception " + bytes[2].ToString(CultureInfo.InvariantCulture));
        if (bytes[1] != function) throw new InvalidOperationException("Unexpected Modbus function.");
        return bytes;
    }

    private static int ReadTemperatureRegister(string name)
    {
        int address = TemperatureAddress(name);
        byte[] response = ExchangeTemperature(3, new byte[] {
            10, 3, (byte)(address >> 8), (byte)address, 0, 1
        }, 7);
        if (response[2] != 2) throw new InvalidOperationException("Unexpected Modbus register response size.");
        return response[3] * 256 + response[4];
    }

    private static void WriteTemperatureRegister(string name, int value)
    {
        if (name == "current_temp" || name == "set_temp")
            throw new InvalidOperationException("Register " + name + " is read-only.");
        if (value < 0 || value > 65535) throw new ArgumentOutOfRangeException("value", "Register value must be 0–65535.");
        int address = TemperatureAddress(name);
        byte[] response = ExchangeTemperature(6, new byte[] {
            10, 6, (byte)(address >> 8), (byte)address, (byte)(value >> 8), (byte)value
        }, 8);
        if (response[2] != (byte)(address >> 8) || response[3] != (byte)address ||
            response[4] != (byte)(value >> 8) || response[5] != (byte)value)
            throw new InvalidOperationException("Temperature controller did not echo the register write.");
    }

    private static void WriteTemperatureCoil(string name, bool value)
    {
        if (name != "run" && name != "pause") throw new ArgumentException("Unknown temperature controller coil: " + name);
        int address = TemperatureAddress(name);
        byte[] response = ExchangeTemperature(5, new byte[] {
            10, 5, (byte)(address >> 8), (byte)address, value ? (byte)0xff : (byte)0, 0
        }, 8);
        if (response[2] != (byte)(address >> 8) || response[3] != (byte)address)
            throw new InvalidOperationException("Temperature controller did not echo the coil write.");
    }

    private static string F(float value) { return value.ToString("R", CultureInfo.InvariantCulture); }
    private static float Number(string text) { return Single.Parse(text, CultureInfo.InvariantCulture); }
    private static byte B(string text) { return Byte.Parse(text, CultureInfo.InvariantCulture); }
    private static int I(string text) { return Int32.Parse(text, CultureInfo.InvariantCulture); }
    private static string Join(float[] values)
    {
        string[] parts = new string[values.Length];
        for (int i = 0; i < values.Length; i++) parts[i] = F(values[i]);
        return String.Join(",", parts);
    }
    private static UInt16 Check(UInt16 result)
    {
        if (result != 1) throw new InvalidOperationException("MCC4DLL returned " + result.ToString(CultureInfo.InvariantCulture));
        return result;
    }
    private static string Execute(string command, string[] a)
    {
        switch (command)
        {
            case "CONNECT":
                Check(card.MoCtrCard_Initial(a[0]));
                return "Connected";
            case "DISCONNECT":
                Check(card.MoCtrCard_Unload());
                return "Disconnected";
            case "TEMP_OPEN":
                OpenTemperature(a[0]);
                return "Connected to " + a[0];
            case "TEMP_CLOSE":
                CloseTemperature();
                return "Temperature controller disconnected";
            case "TEMP_READ_REGISTER":
                return ReadTemperatureRegister(a[0]).ToString(CultureInfo.InvariantCulture);
            case "TEMP_WRITE_REGISTER":
                WriteTemperatureRegister(a[0], I(a[1]));
                return "Register saved";
            case "TEMP_WRITE_COIL":
                WriteTemperatureCoil(a[0], a[1] == "1");
                return "Coil command acknowledged";
            case "PORTS":
                return String.Join(",", System.IO.Ports.SerialPort.GetPortNames());
            case "STATE":
            {
                float[] pos = new float[4], spd = new float[4];
                int[] run = new int[2];
                UInt32[] input = new UInt32[1];
                int pOk = card.MoCtrCard_GetAxisPos(255, pos);
                int sOk = card.MoCtrCard_GetAxisSpd(255, spd);
                int rOk = card.MoCtrCard_GetRunState(run);
                int iOk = card.MoCtrCard_GetInputState(0, input);
                return String.Join("|", new string[] {
                    card.CommLinkEnable ? "1" : "0",
                    rOk == 1 && (run[0] & 1) != 0 ? "1" : "0",
                    pOk == 1 ? Join(pos) : "",
                    sOk == 1 ? Join(spd) : "",
                    iOk == 1 ? input[0].ToString("X8", CultureInfo.InvariantCulture) : "00000000",
                    rOk == 1 ? run[1].ToString(CultureInfo.InvariantCulture) : "0"
                });
            }
            case "GETPARAS":
            {
                string[] values = new string[40];
                for (byte axis = 0; axis < 4; axis++)
                    for (byte index = 0; index < 10; index++)
                    {
                        float[] value = new float[1];
                        Check(card.MoCtrCard_ReadPara(axis, index, value));
                        values[axis * 10 + index] = F(value[0]);
                    }
                return String.Join(";", values);
            }
            case "SETPARAM":
                Check(card.MoCtrCard_SendPara(B(a[0]), B(a[1]), Number(a[2])));
                return "Parameter sent";
            case "SETSPEED":
            {
                byte axis = B(a[0]);
                float velocity = Number(a[1]), acceleration = Number(a[2]);
                Check(card.MoCtrCard_SendPara(axis, 2, velocity));
                Check(card.MoCtrCard_SendPara(axis, 3, acceleration));
                int[] run = new int[2];
                if (card.MoCtrCard_GetRunState(run) == 1 && (run[0] & 1) != 0)
                    Check(card.MoCtrCard_ChangeAxisMovPara(axis, velocity, acceleration));
                return "Speed and acceleration sent";
            }
            case "SETLIMITS":
            {
                byte axis = B(a[0]);
                Check(card.MoCtrCard_SendPara(axis, 8, Number(a[1])));
                Check(card.MoCtrCard_SendPara(axis, 9, Number(a[2])));
                Check(card.MoCtrCard_SetAxisRealtiveInputPole(axis, 32, B(a[3])));
                Check(card.MoCtrCard_SetAxisRealtiveInputPole(axis, 64, B(a[4])));
                return "Limits sent";
            }
            case "SAVE_ROM":
                Check(card.MoCtrCard_SaveSystemParaToROM());
                return "Parameters saved to controller ROM";
            case "MDI":
                Check(card.MoCtrCard_SendMDICommand(Encoding.UTF8.GetString(Convert.FromBase64String(a[0]))));
                return "Command sent";
            case "STEP":
                Check(card.MoCtrCard_MCrlAxisMove(B(a[0]), SByte.Parse(a[1], CultureInfo.InvariantCulture)));
                return "Manual move sent";
            case "MANUAL_STEP":
            {
                byte axis = B(a[0]);
                sbyte direction = SByte.Parse(a[1], CultureInfo.InvariantCulture);
                if (direction != -1 && direction != 1)
                    throw new ArgumentOutOfRangeException("direction", "Direction must be -1 or 1.");
                float[] manualDistance = new float[1];
                Check(card.MoCtrCard_ReadPara(axis, 0, manualDistance));
                if (manualDistance[0] <= 0)
                    throw new InvalidOperationException("The controller's Manual distance must be greater than zero.");
                Check(card.MoCtrCard_MCrlAxisRelMove(axis, direction * manualDistance[0]));
                return "One manual-distance move sent";
            }
            case "ABS":
                Check(card.MoCtrCard_MCrlAxisAbsMove(B(a[0]), Number(a[1]), Number(a[2]), Number(a[3])));
                return "Absolute move sent";
            case "HOME":
                Check(card.MoCtrCard_SeekZero(B(a[0])));
                return "Home command sent";
            case "PAUSE":
                Check(card.MoCtrCard_PauseAxisMov(15));
                return "Motion paused";
            case "RESUME":
                Check(card.MoCtrCard_ReStartAxisMov(15));
                return "Motion resumed";
            case "STOP":
                for (byte axis = 0; axis < 4; axis++) Check(card.MoCtrCard_StopAxisMov(axis));
                return "Controlled stop sent to all axes";
            case "EMERGENCY":
                for (byte axis = 0; axis < 4; axis++) Check(card.MoCtrCard_EmergencyStopAxisMov(axis));
                return "Emergency stop sent to all axes";
            case "CANCELHOME":
                Check(card.MoCtrCard_CancelSeekZero(15));
                return "Homing canceled";
            case "RESETCOORD":
                Check(card.MoCtrCard_ResetCoordinate(B(a[0]), Number(a[1])));
                return "Coordinate reset";
            case "JOYSTICK":
                Check(card.MoCtrCard_SetJoyStickEnable(B(a[0]), B(a[1])));
                return "Joystick setting sent";
            case "OUTPUT":
                Check(card.MoCtrCard_SetOutput(B(a[0]), a[1] == "1"));
                return "Output setting sent";
            case "DEBUG":
                if (a[0] == "1") card.MoCtrCard_OpenSpDebugForm();
                else card.MoCtrCard_CloseSpDebugForm();
                return a[0] == "1" ? "Serial debug window opened" : "Serial debug window closed";
            case "QUITMOTION":
                Check(card.MoCtrCard_QuiteMotionControl());
                return "Motion control exited";
            case "QUIT":
                if (card.CommLinkEnable) card.MoCtrCard_Unload();
                CloseTemperature();
                return "Bye";
            default:
                throw new ArgumentException("Unknown command: " + command);
        }
    }

    private static void Reply(string id, bool ok, string payload)
    {
        payload = (payload ?? "").Replace('\r', ' ').Replace('\n', ' ').Replace('\t', ' ');
        Console.WriteLine(id + "\t" + (ok ? "OK" : "ERR") + "\t" + payload);
        Console.Out.Flush();
    }

    [STAThread]
    private static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        Console.InputEncoding = new UTF8Encoding(false);
        Console.OutputEncoding = new UTF8Encoding(false);
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            string[] fields = line.Split('\t');
            if (fields.Length < 2) continue;
            string id = fields[0];
            try
            {
                string[] args = new string[Math.Max(0, fields.Length - 2)];
                Array.Copy(fields, 2, args, 0, args.Length);
                string response = Execute(fields[1].ToUpperInvariant(), args);
                Reply(id, true, response);
                if (fields[1].Equals("QUIT", StringComparison.OrdinalIgnoreCase)) break;
            }
            catch (Exception ex) { Reply(id, false, ex.Message); }
        }
    }
}
