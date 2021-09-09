using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;
using TechTalk.SpecFlow;

namespace qaMarsSpecflow.Steps
{
    [Binding]
    public class LoginSteps
    {
        public static string path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
        IWebDriver driver;


        [Given(@"Launch Url")]
        public void GivenLaunchUrl()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://192.168.99.100:5000/Home");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

        }
        
        [Given(@"Click on sign in button")]
        public void GivenClickOnSignInButton()
        {
            IWebElement signIn = driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
            signIn.Click();
        }
        
        [When(@"i enter valid email and password")]
        public void WhenIEnterValidEmailAndPassword()
        {
            driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("jisaelza@gmail.com");

            driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("Password01");

        }

        [When(@"click on login button")]
        public void WhenClickOnLoginButton()
        {
            driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();
        }
        
        [Then(@"login should be successful")]
        public void ThenLoginShouldBeSuccessful()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
