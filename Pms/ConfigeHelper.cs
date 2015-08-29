using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Pms
{
    class ConfigeHelper
    {
        public static string GetConfigString(string key)
        {
            return ConfigurationSettings.AppSettings[key];
        }
        public static int GetConfigInt(string key)
        {
            int configValue = 0;
            int.TryParse(ConfigurationSettings.AppSettings[key], out configValue);
            return configValue;
        }

        public static bool GetConfigBool(string key)
        {
            bool configValue = false;
            bool.TryParse(ConfigurationSettings.AppSettings[key], out configValue);
            return configValue;
        }
    }
}
