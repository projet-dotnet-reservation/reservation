using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.EnterpriseServices;

namespace lib_Config
{
    [Transaction(TransactionOption.Required), ObjectPooling(5, 10), EventTrackingEnabled(true)]
    public class clsConfig : ServicedComponent
    {
        [AutoComplete]
        public static String readConfigString(String key)
        {
            String value = Properties.Settings.Default.Properties[key].DefaultValue.ToString();
           //String value = ConfigurationManager.ConnectionStrings[key].ConnectionString;
           return value;
        }
    }
}
