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
        
        [AfterScenario]
        public void DiposeWebDriver()
        {
            Website.SeleniumDriver.Quit();
            Website.SeleniumDriver.Dispose();
        }
    }
}
