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

        private IWebElement _usernameFieldLogin => _driver.FindElement(By.Id("userName"));
        private IWebElement _passwordFieldLogin => _driver.FindElement(By.Id("password"));
        private IWebElement _clickSignIn => _driver.FindElement(By.Id("login"));
        private IWebElement _invalidPasswordAlert => _driver.FindElement(By.Id("name"));
        private IWebElement _newUserButton => _driver.FindElement(By.Id("newUser"));
        private IWebElement _newUserHeading => _driver.FindElement(By.CssSelector("h4"));
        private IWebElement _firstNameField => _driver.FindElement(By.Id("firstname"));
        private IWebElement _lastNameField => _driver.FindElement(By.Id("lastname"));
        private IWebElement _usernameField => _driver.FindElement(By.Id("userName"));
        private IWebElement _passwordField => _driver.FindElement(By.Id("password"));
        private IWebElement _clickImNotRobot => _driver.FindElement(By.Id("recaptcha-anchor"));
        private IWebElement _clickRegister => _driver.FindElement(By.Id("register"));
        private IWebElement _profileHeading => _driver.FindElement(By.ClassName("main-header"));


        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void VisitLoginPage()
        {
            _driver.Navigate().GoToUrl(LoginPageUrl);
        }

        public void InputUsernameLogin(string username)
        {
            _usernameFieldLogin.SendKeys(username);
        }
        public void InputPasswordLogin(string password)
        {
            _passwordFieldLogin.SendKeys(password);
        }

        public string InvalidPasswordAlert()
        {
            return _invalidPasswordAlert.Text;
        }

        public void NewUser()
        {
            _newUserButton.Click();
        }

        public string NewUserWelcome()
        {
            return _newUserHeading.Text;
        }

        public void InputFirstName(string firstName)
        {
            _firstNameField.SendKeys(firstName);
        }
        public void InputLastName(string lastName)
        {
            _lastNameField.SendKeys(lastName);
        }
        public void InputUsername(string username)
        {
            _usernameField.SendKeys(username);
        }
        public void InputPassword(string password)
        {
            _passwordField.SendKeys(password);
        }
                
        public void NotRobot()
        {
            _clickImNotRobot.Click();
        }

        public void SignInButton()
        {
            _clickSignIn.Click();
        }

        public void RegisterNewUser()
        {
            _clickRegister.Click();
        }

        public string ProfileWelcome()
        {
            return _profileHeading.Text;
        }
    }
}
