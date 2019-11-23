using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace GmailLogin.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        IWebDriver _webDriver;
        
        public IWebElement LoginInput { get => _webDriver.FindElement(By.Id("identifierId"));  }
        public IWebElement LoginNext { get => _webDriver.FindElement(By.Id("identifierNext"));  }
        public IWebElement PasswordInput { get => _webDriver.FindElement(By.XPath("//input[@type=\"password\" and @name=\"password\"]")); }
    }
}
