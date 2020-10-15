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

        private IWebElement _newUserButton => _driver.FindElement(By.Id("newUser"));
        private IWebElement _newUserHeading => _driver.FindElement(By.CssSelector("h4"));

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void VisitLoginPage()
        {
            _driver.Navigate().GoToUrl(LoginPageUrl);
        }

        public void NewUser()
        {
            _newUserButton.Click();
        }

        public string NewUserWelcome()
        {
            return _newUserHeading.Text;
        }

    }
}
