using Bank_AutomationProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AutomationProject.Configurations
{
    public class AppConfigReader : IConfig
    {
        public string GetUrl()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.URL);
        }

        public string GetPassword()
        {
           return  ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetUserId()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.UserId);
        }
    }
}
