using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace FinalWeekProject.BDD
{
    [Binding]
    public class BooksSteps
    {
        public Website Website { get; } = new Website("chrome");

        [Given(@"I am login page")]
        public void GivenIAmLoginPage()
        {
            Website.LoginPage.VisitLoginPage();
        }

        [Given(@"I enter a valid (.*) and (.*)")]
        public void GivenIEnterAValidAnd(string UserName, string Password)
        {
                        
            Website.LoginPage.InputUsernameLogin(UserName);
            Website.LoginPage.InputPasswordLogin(Password);
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            Website.LoginPage.SignInButton();
        }

        [Given(@"I click on the Book Store")]
        public void GivenIClickOnTheBookStore()
        {
            Website.Homepage.ClickOnBookStore();
        }
                       

        [When(@"I search a (.*) and click on it")]
        public void WhenISearchAAndClickOnIt(string bookName)
        {
            Website.Homepage.SearchBook(bookName);
            Website.Homepage.ClickOnSearchedBook();
        }


        [When(@"add it to my collection")]
        public void WhenAddItToMyCollection()
        {
            Website.Homepage.AddToCollectionButton();
            Website.Homepage.ClickOnProfile();
        }
        
        [Then(@"I should see it in my profile")]
        public void ThenIShouldSeeItInMyProfile()
        {
            Assert.That(Website.Homepage.UsernameCheck, Is.EqualTo("SpartaGlobalTest"));
        }
    }

}
