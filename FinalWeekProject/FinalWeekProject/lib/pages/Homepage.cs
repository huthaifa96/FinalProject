using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWeekProject
{
    public class Homepage
    {
        //set the driver
        private IWebDriver _driver;
        //setting the homepage URL which will utilise our AppConfigReader
        private string HomePageUrl = AppConfigReader.BaseUrl;

        private IWebElement _searchBar => _driver.FindElement(By.Id("searchBox"));
        private IWebElement _loginButton => _driver.FindElement(By.Id("login"));
        private IWebElement _searchedBook => _driver.FindElement(By.XPath("//span/a")); // Using XPath not ideal but LinkText is too specific for that book
        private IWebElement _descriptionField => _driver.FindElement(By.CssSelector("#description-wrapper #userName-value"));
        private IWebElement _profileButton => _driver.FindElement(By.CssSelector(".show #item-3 > .text"));
        private IWebElement _profileNotLoggedIn => _driver.FindElement(By.Id("notLoggin-label"));
        private IWebElement _welcomeLoginAlert => _driver.FindElement(By.Id("userForm"));
        private IWebElement _bookStoreButton => _driver.FindElement(By.CssSelector(".show #item-2"));
        private IWebElement _addToCollectionButton => _driver.FindElement(By.Id("addNewRecordButton"));
        private IWebElement _userNameCheck=> _driver.FindElement(By.Id("userName-value"));

        public Homepage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void VisitHomePage()
        {
            _driver.Navigate().GoToUrl(HomePageUrl);
        }
        public string GetLandingPageTitle()
        {
            return _driver.Title;
        }

        public void SearchBook(string bookName)
        {
            _searchBar.SendKeys(bookName.Trim());
        }
        public void ClickOnSearchedBook()
        {
            _searchedBook.Click();
        }

        public string DescriptionSection()
        {
            return _descriptionField.Text;
        }
        public void ClickOnProfile()
        {
            _profileButton.Click();
        }
        public string ProfileNotLoggedIn()
        {
            return _profileNotLoggedIn.Text;
        }

        public void ClickOnLogin()
        {
            _loginButton.Click();
        }
        public string LoginWelcome()
        {
            return _welcomeLoginAlert.Text;
        }
        public void ClickOnBookStore()
        {
            _bookStoreButton.Click();
        }

        public void AddToCollectionButton()
        {
            _addToCollectionButton.Click();
        }
        public string UsernameCheck()
        {
            return _userNameCheck.Text;
        }

    }
}
