using CNNTestFrameWork1.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V112.Network;
using OpenQA.Selenium.DevTools.V113.FedCm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNNTestFrameWork1.PageObject
{
    class RegistrationPage
    {
        public IWebDriver driver;
        public RegistrationPage()
        {
            driver = BaseTest.driver;
        }
        private By loginButton=By.XPath("//div[@class='header__right']//button[@aria-label='User Account Log In Button'][normalize-space()='Log In']");
        private By signuplink = By.XPath("//*[@id='login-registration-link']");
        //private By createAccountButton = By.XPath("//*[@id='user-account-registration-create-account-button']");
        private By createAccountButton = By.Id("user-account-registration-create-account-button");
        private By emailAddy = By.XPath("//*[@id='registration-email-input']");
        private By passWord = By.XPath("//*[@id='registration-password-input']");
        //IWebElement cookies => driver.FindElement(By.CssSelector("#onetrust-accept-btn-handler"));
        private By cookies = By.CssSelector("#onetrust-accept-btn-handler");


        public void ClickAcceptCookies()
        {
            Thread.Sleep(8000);
            driver.FindElement(cookies).Click();
        }
        
        public void ClickLoginButton() 
        {
            Thread.Sleep(3000);
        driver.FindElement(loginButton).Click();
        }
        public void ClickSignupLink() 
        {
            Thread.Sleep(3000);
            driver.FindElement(signuplink).Click();
        }
        public void ClickCreateAccountButton() 
        {
            Thread.Sleep(3000);
            driver.FindElement(createAccountButton).Click();
        }
        public void UserEnterEmailAddress(string p0)
        {
            Thread.Sleep(3000);
            driver.FindElement(emailAddy).SendKeys(p0);
        }
        public void UserEnterPassword(string p0) 
        {
            Thread.Sleep(3000);
            driver.FindElement(passWord).SendKeys(p0);
        }
        
        public bool RedirectedHomePage()
        {
            Thread.Sleep(3000);
            return driver.Url.Contains("https://edition.cnn.com/");
        }
    }
}
