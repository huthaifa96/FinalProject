using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWeekProject
{
    public class Website
    {
        public IWebDriver SeleniumDriver { get; internal set; }
        public Homepage Homepage { get; internal set; }
        public LoginPage LoginPage { get; internal set; }
        
        public Website(string driverName, int pageLoadWaitInSecs = 10, int implicitWaitInSecs = 10)
        {
            SeleniumDriver = new SeleniumDriverConfig(driverName, pageLoadWaitInSecs, implicitWaitInSecs).Driver;
            Homepage = new Homepage(SeleniumDriver);
            LoginPage = new LoginPage(SeleniumDriver);
        }
        public void DeleteCookies()
        {
            SeleniumDriver.Manage().Cookies.DeleteAllCookies();
        }

    }
}
