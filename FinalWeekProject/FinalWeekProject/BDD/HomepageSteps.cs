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

        [Then(@"I should see the '(.*)' of the book")]
        public void ThenIShouldSeeTheOfTheBook(string p0)
        {
            Assert.That(Website.Homepage.DescriptionSection, Does.Contain("Description"));
        }

        [When(@"I click Profile without logging in")]
        public void WhenIClickProfileWithoutLoggingIn()
        {
            Website.Homepage.ClickOnProfile();
        }

        [Then(@"I should see the '(.*)' message")]
        public void ThenIShouldSeeTheMessage(string p0)
        {
            Assert.That(Website.Homepage.ProfileNotLoggedIn, Does.Contain("Currently you are not logged into the Book Store application"));
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
