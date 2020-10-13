using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWeekProject
{
    public class LoginPage
    {
        //set the driver
        private IWebDriver _driver;
        //setting the homepage URL which will utilise our AppConfigReader
        private string LoginPageUrl = AppConfigReader.LoginPageUrl;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void VisitLoginPage()
        {
            _driver.Navigate().GoToUrl(LoginPageUrl);
        }



    }
}
