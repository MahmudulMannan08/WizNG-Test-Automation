using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WizNG_Test_Automation.Pages
{
    public class LoginPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_Login2_Login1_LoginButton")]
        public IWebElement LoginBtnElement;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_Login2_Login1_UserName")]
        public IWebElement UsernameElement;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_Login2_Login1_Password")]
        public IWebElement PasswordElement;
    }
}