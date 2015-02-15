using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WizNG_Test_Automation.Pages
{
    public class DashboardPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "ctl00_LeftMenu1_divDASHBOARD")]
        public IWebElement DashboardElement;

        [FindsBy(How = How.Id, Using = "welcomeImg")]
        public IWebElement AccountDropdownElement;

        [FindsBy(How = How.Id, Using = "Td1")]
        public IWebElement LogOutElement;

        [FindsBy(How = How.LinkText, Using = "Import Wizard")]
        public IWebElement ImportWizardElement;
    }
}
