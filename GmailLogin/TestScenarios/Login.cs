using GmailLogin.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace GmailLogin.TestScenarios
{
    public class Login
    {
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver(@"C:\chromedriver_win32");
            
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
        }

        IWebDriver _driver;
        WebDriverWait _wait;

        [Test]
        public void TypeLogin()
        {
            _driver.Url = "https://gmail.com";
            LoginPage loginPage = new LoginPage(_driver);

            loginPage.LoginInput.SendKeys("testowanie678");
            loginPage.LoginNext.Click();

            _wait.Until(x => 
            {
                try
                {
                    return loginPage.PasswordInput.Enabled;
                }
                catch(StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });

            loginPage.PasswordInput.SendKeys("ttt");
            Assert.IsTrue(true);
        }
    }
}

