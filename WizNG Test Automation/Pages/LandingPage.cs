using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WizNG_Test_Automation.Pages
{
    public class LandingPage : IPage
    {
        public string Url
        {
            get
            {
                return "/";
            }
        }

        [FindsBy(How = How.LinkText, Using = "Sign In")]
        public IWebElement SignInElement;
    }
}
