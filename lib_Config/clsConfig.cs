using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace lib_Config
{
    public class clsConfig
    {
        public static String readConfigString(String key)
        {
            String value = Properties.Settings.Default.Properties[key].DefaultValue.ToString();
           //String value = ConfigurationManager.ConnectionStrings[key].ConnectionString;
           return value;
        }
    }
}
