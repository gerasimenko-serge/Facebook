using Facebook.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;

namespace Facebook.PageObjects
{
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "email")][CacheLookup]
        private IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "pass")][CacheLookup]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "loginbutton")][CacheLookup]
        private IWebElement Submit { get; set; }

        public void LoginToApplication()
        {
            var userData = ConfigurationManager.AppSettings;
            Email.EnterText(userData["UserName"], "email");
            Password.EnterText(userData["Password"], "password");
            Submit.ClickOnIt("\"login\"");
        }
    }
}
