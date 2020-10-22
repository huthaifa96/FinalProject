using System;
using TechTalk.SpecFlow;
using NUnit.Framework;


namespace FinalWeekProject
{
    [Binding]
    public class HomepageSteps
    {
        public Website Website { get; } = new Website("chrome");

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            Website.Homepage.VisitHomePage();
        }

        [When(@"I enter a (.*) into the search bar")]
        public void WhenIEnterAIntoTheSearchBar(string bookName)
        {
            Website.Homepage.SearchBook(bookName);
        }

        [When(@"click on the searched book's name")]
        public void WhenClickOnTheSearchedBookSName()
        {
            Website.Homepage.ClickOnSearchedBook();
        }

        //[Then(@"I should see the '(.*)' of the book")]
        //public void ThenIShouldSeeTheOfTheBook(string description)
        //{
        //    Assert.That(Website.Homepage.DescriptionSection, Is.(description));
        //}
        [Then(@"I should see the right (.*) of the book")]
        public void ThenIShouldSeeTheRightOfTheBook(string p0)
        {
            Assert.That(Website.Homepage.DescriptionSection, Is.EqualTo("This pocket guide is the perfect on-the-job companion to Git, the distributed version control system. It provides a compact, readable introduction to Git for new users, as well as a reference to common commands and procedures for those of you with Git exp"));
        //    Assert.That(Website.Homepage.DescriptionSection, Is.EqualTo("Like it or not, JavaScript is everywhere these days-from browser to server to mobile-and now you, too, need to learn the language or dive deeper than you have. This concise book guides you into and through JavaScript, written by a veteran programmer who o"));
        //    Assert.That(Website.Homepage.DescriptionSection, Is.EqualTo("No matter how much experience you have with JavaScript, odds are you don’t fully understand the language. As part of the \"You Don’t Know JS\" series, this compact guide focuses on new features available in ECMAScript 6 (ES6), the latest version of the st"));
        }


        [When(@"I click Profile without logging in")]
        public void WhenIClickProfileWithoutLoggingIn()
        {
            Website.Homepage.ClickOnProfile();
        }

        [Then(@"I should see the '(.*)' message")]
        public void ThenIShouldSeeTheMessage(string p0)
        {
            Assert.That(Website.Homepage.ProfileNotLoggedIn, Does.Contain("Currently you are not logged into the Book Store application, please visit the login page to enter or register page to register yourself."));
        }

        [When(@"I click Login")]
        public void WhenIClickLogin()
        {
            Website.Homepage.ClickOnLogin();
        }

        [Then(@"The '(.*)' message should be seen")]
        public void ThenTheMessageShouldBeSeen(string p0)
        {
            Assert.That(Website.Homepage.LoginWelcome, Does.Contain("Welcome"));
        }


        [AfterScenario]
        public void DiposeWebDriver()
        {
            Website.SeleniumDriver.Quit();
            Website.SeleniumDriver.Dispose();
        }
    }
}
