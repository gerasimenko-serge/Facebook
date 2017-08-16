using Facebook.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Facebook.PageObjects
{
    public class HomePage
    {
        [FindsBy(How = How.TagName, Using = "h1")][CacheLookup]
        private IWebElement LogoFacebook { get; set; }

        public void ClickOnFacebookLogo()
        {
            LogoFacebook.ClickOnIt("LogoFacebook");
        }
    }
}
