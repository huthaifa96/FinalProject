using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace FinalWeekProject.BDD
{
    [Binding]
    public class LoginSteps
    {
        public Website Website { get; } = new Website("chrome");

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            Website.LoginPage.VisitLoginPage();
        }
        
        [When(@"I click new user")]
        public void WhenIClickNewUser()
        {
            Website.LoginPage.NewUser();
        }
        
        [Then(@"I should see '(.*)'")]
        public void ThenIShouldSee(string p0)
        {
            Assert.That(Website.LoginPage.NewUserWelcome, Does.Contain("Register to Book Store"));
        }

        [Given(@"that I am on the create new user page")]
        public void GivenThatIAmOnTheCreateNewUserPage()
        {
            Website.LoginPage.VisitLoginPage();
            Website.LoginPage.NewUser();
        }

        [Given(@"I have filled in the relevant fields")]
        public void GivenIHaveFilledInTheRelevantFields(string firstName, string lastName, string username, string password)
        {
            firstName = "Sparta";
            lastName = "Global";
            username = "SpartaGlobalTest";
            password = "Test123$";

            Website.LoginPage.InputFirstName(firstName);
            Website.LoginPage.InputLastName(lastName);
            Website.LoginPage.InputUsername(username);
            Website.LoginPage.InputPassword(password);

        }

        [Given(@"clicked the I'm not a robot box")]
        public void GivenClickedTheIMNotARobotBox()
        {
            Website.LoginPage.NotRobot();
        }

        [When(@"I click register")]
        public void WhenIClickRegister()
        {
            Website.LoginPage.RegisterNewUser();
        }

        [Then(@"I should have created a new user")]
        public void ThenIShouldHaveCreatedANewUser()
        {
            Assert.That(Website.LoginPage.ProfileWelcome, Does.Contain("Profile"));
        }

        [Given(@"I have entered the username '(.*)'")]
        public void GivenIHaveEnteredTheUsername(string username)
        {
            Website.LoginPage.InputUsernameLogin(username);
        }

        [Given(@"I have entered the password (.*)")]
        public void GivenIHaveEnteredThePassword(string password)
        {
            Website.LoginPage.InputPasswordLogin(password);
        }

        [When(@"I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            Website.LoginPage.SignInButton();
        }

        [Then(@"I should see an alert containing the error message ""(.*)""")]
        public void ThenIShouldSeeAnAlertContainingTheErrorMessage(string p0)
        {
            Assert.That(Website.LoginPage.InvalidPasswordAlert, Does.Contain("Invalid username or password!"));
        }


        [AfterScenario]
        public void DiposeWebDriver()
        {
            Website.SeleniumDriver.Quit();
            Website.SeleniumDriver.Dispose();
        }
    }
}
