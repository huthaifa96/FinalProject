using System;
using System.ComponentModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace FinalWeekProject
{
    public class SeleniumDriverConfig
    {

        public IWebDriver Driver { get; set; }

        public SeleniumDriverConfig(string driver, int pageLoadInSecs, int implicitWaitInSecs)
        {
            DriverSetUp(driver, pageLoadInSecs, implicitWaitInSecs);
        }

       
        public void DriverSetUp(string driver, int pageLoadInSecs, int implicitWaitInSecs)
        {
            if (driver.ToLower() == "chrome")
            {
                // creates a new driver isntance (chrome) we can use in testing
                SetChromeDriver();
                SetDriverConfiguration(pageLoadInSecs, implicitWaitInSecs);
            }
            else if (driver.ToLower() == "firefox")
            {
                SetFireFoxDriver();
                SetDriverConfiguration(pageLoadInSecs, implicitWaitInSecs);
            }
            else
            {
                throw new Exception("Please use 'chrome' or 'firefox'");
            }
        }

        public void SetFireFoxDriver()
        {
            Driver = new FirefoxDriver();
        }

        public void SetChromeDriver()
        {
            Driver = new ChromeDriver();
        }

        public void SetDriverConfiguration(int pageLoadInSecs, int implicitWatiInSecs)
        {
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInSecs);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWatiInSecs);
        }
    }
}
