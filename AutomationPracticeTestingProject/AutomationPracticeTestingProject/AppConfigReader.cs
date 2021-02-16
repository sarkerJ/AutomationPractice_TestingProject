using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AutomationPracticeTestingProject
{
    public static class AppConfigReader
    {
        //public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        //public static readonly string SigninPageUrl = ConfigurationManager.AppSettings["signinpage_url"];

        //.NET core doesnt read configreader.... so use the code below instead 
        public static string BaseUrl { get; }
        public static string SigninPageUrl { get; }
        public static string DressesPageUrl { get; }

        static AppConfigReader()
        {
            //var configBuilder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false, true);
            //var baseSettingSection = configBuilder.Build().GetSection("base_settings");
            //BaseUrl = baseSettingSection.GetSection("base_url").Value;
            //SigninPageUrl = baseSettingSection.GetSection("signinpage_url").Value;
            //DressesPageUrl = baseSettingSection.GetSection("dressespage_url").Value;

            BaseUrl = "http://automationpractice.com/";
        }
    }
}
