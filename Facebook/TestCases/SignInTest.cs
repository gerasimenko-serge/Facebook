using NUnit.Framework;
using Facebook.PageObjects;
using System.Configuration;
using Facebook.WrapperFactory;

namespace Facebook.TestCases
{
    class SignInTest
    {
        [SetUp]
        public void SetUp()
        {
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
        }

        [Test]
        public void Test()
        {
            Page.Home.ClickOnFacebookLogo();
            Page.Login.LoginToApplication();
            Page.Account.SearchProfilePhoto();

            BrowserFactory.CloseAllDrivers();
        }
    }
}