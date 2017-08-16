using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

using Facebook.Extensions;

namespace Facebook.PageObjects
{
    public class AccountPage
    {
        [FindsBy(How = How.Id, Using = "profile_pic_header_100005031017798")]
        private IWebElement ProfilePhoto { get; set; }

        public void SearchProfilePhoto()
        {
            ProfilePhoto.IsDisplayed("profile photo");
        }
    }
}
