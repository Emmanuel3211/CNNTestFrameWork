using CNNTestFrameWork1.Hooks;
using CNNTestFrameWork1.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CNNTestFrameWork1.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        RegistrationPage registrationPage = new RegistrationPage();
        
        [Given(@"I navigate to CNN website")]
        public void GivenINavigateToCNNWebsite()
        {
            driver.Navigate().GoToUrl(@"https://edition.cnn.com/");
        }

        [Given(@"I click accept cookies")]
        public void GivenIClickAcceptCookies()
        {
            registrationPage.ClickAcceptCookies();
        }


        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            registrationPage.ClickLoginButton();
        }

        [When(@"I click on the signup link")]
        public void WhenIClickOnTheSignupLink()
        {
            registrationPage.ClickSignupLink();
        }

        [When(@"I entered my email address ""([^""]*)""")]
        public void WhenIEnteredMyEmailAddress(string p0)
        {
            registrationPage.UserEnterEmailAddress(p0);
        }

        [When(@"I entered my password ""([^""]*)""")]
        public void WhenIEnteredMyPassword(string p0)
        {
            registrationPage.UserEnterPassword(p0);
        }

        [When(@"I click on create account button")]
        public void WhenIClickOnCreateAccountButton()
        {
            registrationPage.ClickCreateAccountButton();
        }


        [Then(@"I am registered and redirected to the CNN website ""([^""]*)""")]
        public void ThenIAmRegisteredAndRedirectedToTheCNNWebsite(string p0)
        {
            //registrationPage.RedirectedHomePage().Contains("https://edition.cnn.com/");
            registrationPage.RedirectedHomePage().Should().BeTrue();
        }




    }

}
