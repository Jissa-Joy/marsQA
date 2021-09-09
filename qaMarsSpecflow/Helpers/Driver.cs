
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace qaMarsSpecflow
{
    public class Driver
    {
        public static IWebDriver driver { get; set; }

        public static string Url = "http://192.168.99.100:5000/Home";

        public static void Initialize()
        {
            driver = new ChromeDriver();
            TurnOnWait();
            driver.Manage().Window.Maximize();

        }

        public static string BaseUrl
        {
            get { return Url; }
        }

        public static void TurnOnWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }
        public static void NavigateUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        public void Close()
        {
            driver.Quit();
        }
    }

}
