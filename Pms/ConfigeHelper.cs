using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
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

        public static void SetConfigValue(string key,string value)
        {
            string appPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string configFile = System.IO.Path.Combine(appPath, "Pms.exe.config");
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(); 
          
        }
    }
}
