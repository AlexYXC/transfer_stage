from pymodbus.client import ModbusSerialClient

# Register mapping (standard addresses from your spreadsheet)
REGS = {
    'current_temp':    58505,  # read-only
    'set_temp':        58506,  # read-only
    'P':               58507,
    'I':               58508,
    'D':               58509,
    'cycle':           58510,
    'power_limit':     58524,
    'comp_offset':     58551,
    'hysteresis':      58527,
    'seg1_temp':       3001,
    'seg1_heat_time':  3151,
    'seg1_hold_time':  3051,
    'seg1_power':      3101,
    'run':            10011,  # coil
    'pause':          10013,  # coil
}

READ_ONLY = {'current_temp', 'set_temp'}

class ModbusController:
    def __init__(self, port, slave_id=10, *, timeout=1, retries=0):
        self.client = ModbusSerialClient(
            port=port,
            baudrate=9600,
            bytesize=8,
            parity='N',
            stopbits=1,
            timeout=timeout,
            retries=retries
        )
        self.slave_id = slave_id
        if not self.client.connect():
            self.client.close()
            raise ConnectionError(
                f'Cannot open {port}. Check the connection and whether another program is using it.'
            )

    def close(self):
        self.client.close()

    def _get_addr(self, name):
        raw = REGS[name]
        if raw < 40001:
            return raw - 1
        else :
            return raw - 40001

    def read_register(self, name):
        addr = self._get_addr(name)
        response = self.client.read_holding_registers(addr, count=1, device_id=self.slave_id)
        if response.isError():
            raise IOError(f"Failed to read {name}: {response}")
        raw = response.registers[0]
        if name in ('current_temp', 'set_temp', 'power_limit', 'comp_offset', 'hysteresis'):
            return raw * 0.1
        return raw

    def write_register(self, name, value):
        if name in READ_ONLY:
            raise IOError(f"Register {name} is read-only")
        addr = self._get_addr(name)
        if name in ('set_temp', 'power_limit', 'comp_offset', 'hysteresis'):
            payload = int(value * 10)
        else:
            payload = int(value)
        response = self.client.write_register(addr, payload, device_id=self.slave_id)
        if response.isError():
            raise IOError(f"Failed to write {name}: {response}")

    def write_coil(self, name, value: bool):
        addr = self._get_addr(name)
        response = self.client.write_coil(addr, value, device_id=self.slave_id)
        if response.isError():
            raise IOError(f"Failed to write coil {name}: {response}")

    def read_coil(self, name):
        addr = self._get_addr(name)
        response = self.client.read_coils(addr, count=1, device_id=self.slave_id)
        if response.isError():
            raise IOError(f"Failed to read coil {name}: {response}")
        return response.bits[0]
