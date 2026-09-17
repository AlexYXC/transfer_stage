using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MccCustomLanguage
{
    public class Language
    {
        #region 信息提示区
        public string ErrMsg_FailedToReadFile = "";
        public string ErrMsg_WarningLimittedStopRun = "";
        public string ErrMsg_InfoParaDownloading = "";
        public string ErrMsg_InfoParaDownloadErr = "";
        public string ErrMsg_InfoParaUploading = "";
        public string ErrMsg_InfoParaUploadErr = "";
        public string ErrMsg_ChooseCommandLineToBeModified = "";
        public string ErrMsg_OpenProgFileOk = "";
        public string ErrMsg_SaveFileTo = "";
        public string ErrMsg_ProgListNullCantSave = "";
        public string ErrMsg_LinkMCCardOk = "";
        public string ErrMsg_LinkMCCardErr = "";
        public string ErrMsg_UpdateSomeParaErr = "";
        public string ErrMsg_UpdateSomeParaOK = "";
        public string ErrMsg_SendCmndErrNoLink = "";
        public string ErrMsg_ParaSaveOK = "";
        public string ErrMsg_ParaSaveErr = "";
        #endregion


        #region 自动运行提示区
        public string AutoProgMsg_SendAll = "";
        public string AutoProgMsg_SendCmndOk = "";
        public string AutoProgMsg_SendCmndErr = "";
        public string AutoProgMsg_ReSendCmndWhenRunning = "";
        #endregion

        #region ControlerCaption
        public string MainFrmButton1TextStop = "";
        public string MainFrmButton1TextUpdate = "";
        public string IOTstFrmJoystickVoltage = "";
        #endregion

        #region AboutFrame
        public string AboutFrameTitle = "";
        public string AboutFrameVersionInfo = "";
        public string AboutFrameDescription = "";
        #endregion

        #region
        public string SetParaFrameLimitEnable = "";
        public string SetParaFrameLimitDisable = "";             
        #endregion

        protected Dictionary<string, string> DicLanguage = new Dictionary<string, string>();
        public Language()
        {
            XmlLoad(GlobalData.SystemLanguage);
            BindLanguageText();
        }

        /// <summary>
        /// 读取XML放到内存
        /// </summary>
        /// <param name="language"></param>
        protected void XmlLoad(string language)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                string address = AppDomain.CurrentDomain.BaseDirectory + "Languages\\" + language + ".xml";
                doc.Load(address);
                XmlElement root = doc.DocumentElement;

                XmlNodeList nodeLst1 = root.ChildNodes;
                foreach (XmlNode item in nodeLst1)
                {
                    DicLanguage.Add(item.Name, item.InnerText);
                }
            }
            catch (Exception ex)
            {                
                throw ex;
            }            
        }

        public void BindLanguageText()
        {
            try
            {
                ErrMsg_FailedToReadFile = DicLanguage["ErrMsg_ReadConfigFileErr"];
                ErrMsg_WarningLimittedStopRun = DicLanguage["ErrMsg_WarningLimitedStopRun"];
                ErrMsg_InfoParaDownloading = DicLanguage["ErrMsg_InfoParaDownloading"];
                ErrMsg_InfoParaDownloadErr = DicLanguage["ErrMsg_InfoParaDownloadError"];
                ErrMsg_InfoParaUploading = DicLanguage["ErrMsg_InfoParaUploading"];
                ErrMsg_InfoParaUploadErr = DicLanguage["ErrMsg_InfoParaUploadError"];
                ErrMsg_ChooseCommandLineToBeModified = DicLanguage["ErrMsg_ChoseCmndToModify"];
                ErrMsg_OpenProgFileOk = DicLanguage["ErrMsg_OpenFileOk"];
                ErrMsg_SaveFileTo = DicLanguage["ErrMsg_SaveFileTo"];
                ErrMsg_ProgListNullCantSave = DicLanguage["ErrMsg_ProgListNullCantSave"];
                ErrMsg_LinkMCCardOk     = DicLanguage["ErrMsg_LinkMCCardOk"];
                ErrMsg_LinkMCCardErr    = DicLanguage["ErrMsg_LinkMCCardErr"];
                ErrMsg_UpdateSomeParaErr= DicLanguage["ErrMsg_UpdateSomeParaErr"];
                ErrMsg_UpdateSomeParaOK = DicLanguage["ErrMsg_UpdateSomeParaOK"];
                ErrMsg_SendCmndErrNoLink = DicLanguage["ErrMsg_SendCmndErrNoLink"];
                ErrMsg_ParaSaveOK = DicLanguage["ErrMsg_ParaSaveOK"];
                ErrMsg_ParaSaveErr = DicLanguage["ErrMsg_ParaSaveErr"];
                AutoProgMsg_ReSendCmndWhenRunning = DicLanguage["AutoProgMsg_ReSendCmndWhenRunning"];
                AutoProgMsg_SendAll = DicLanguage["AutoProgMsg_SendAll"];
                AutoProgMsg_SendCmndOk = DicLanguage["AutoProgMsg_SendCmndOk"];
                AutoProgMsg_SendCmndErr = DicLanguage["AutoProgMsg_SendCmndErr"];

                // 控件名称
                MainFrmButton1TextStop = DicLanguage["MainFrmButton1Text_Stop"];
                MainFrmButton1TextUpdate = DicLanguage["MainFrmButton1Text_Update"];
                IOTstFrmJoystickVoltage = DicLanguage["IOTstFrmJoystickVoltage"];

                AboutFrameTitle = DicLanguage["AboutFrameTitle"];
                AboutFrameVersionInfo = DicLanguage["AboutFrameVersionInfo"];
                AboutFrameDescription = DicLanguage["AboutFrameDescription"];

                // 参数设置窗口
                SetParaFrameLimitDisable = DicLanguage["SetParaDlg_LimitDisable"];
                SetParaFrameLimitEnable = DicLanguage["SetParaDlg_LimitEnable"];
            }
            catch (Exception ex)
            {

            }
    }
}
}
