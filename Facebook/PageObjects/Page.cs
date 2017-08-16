using Facebook.WrapperFactory;
using OpenQA.Selenium.Support.PageObjects;

namespace Facebook.PageObjects
{
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(BrowserFactory.Driver, page);
            return page;
        }

        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static AccountPage Account
        {
            get { return GetPage<AccountPage>(); }
        }
    }
}
