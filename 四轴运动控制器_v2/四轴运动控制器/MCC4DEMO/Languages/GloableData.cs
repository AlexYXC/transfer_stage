using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;


namespace MccCustomLanguage
{
    public class GlobalData
    {
        /// <summary>
        /// 系统语言（Chinese（中文），English（英文）。。。）
        /// </summary>
        /// //System.Configuration.ConfigurationManager.AppSettings
        public static string SystemLanguage = ConfigurationManager.AppSettings["Language"];
        /*
         * 上面这句话就是告诉我们需要引用System.Configuration.dll就会出现ConfigurationManager类了，就是这么简单。
         */


        private static Language globalLanguage;
        public static Language GlobalLanguage
        {
            get
            {
                if (globalLanguage == null)
                {
                    globalLanguage = new Language();
                    return globalLanguage;
                }
                return globalLanguage;
            }
        }
    }
}
