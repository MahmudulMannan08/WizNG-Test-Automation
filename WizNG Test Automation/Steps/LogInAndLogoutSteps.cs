using System;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WizNG_Test_Automation.Pages;

namespace WizNG_Test_Automation.Steps
{
    [Binding]
    public class LogInAndLogoutSteps : TestBase
    {
        public static LandingPage landingPage;
        public static LoginPage loginPage;
        public static DashboardPage dashboardPage;

        [Given(@"I am on WizNg landing page")]
        public void GivenIAmOnWizNgLandingPage()
        {
            driver.IgnoreSynchronization = true;

            if (FeatureContext.Current.ContainsKey("error"))
            {
                return;
            }

            UIHelper.GoTo<LandingPage>(HostUrl, false);
        }

        [Given(@"I click on log in link")]
        public void GivenIClickOnLogInLink()
        {
            landingPage = UIHelper.PageInit<LandingPage>(driver);
            UIHelper.ClickOnLink(landingPage.SignInElement);

            loginPage = UIHelper.PageInit<LoginPage>(driver);
            Wait.Until(UIHelper.ElementIsClickable(loginPage.LoginBtnElement));
        }

        [Then(@"I provide my login credentials")]
        public void ThenIProvideMyLoginCredentials()
        {
            loginPage = UIHelper.PageInit<LoginPage>(driver);
            UIHelper.EnterText(loginPage.UsernameElement, "plladmin");
            UIHelper.EnterText(loginPage.PasswordElement, "onirban123@");
            UIHelper.ClickOnLink(loginPage.LoginBtnElement);
        }

        [Then(@"I log in to WizNg and verify")]
        public void ThenILogInToWizNgAndVerify()
        {
            dashboardPage = UIHelper.PageInit<DashboardPage>(driver);
            Thread.Sleep(4000);
            Assert.True(dashboardPage.DashboardElement.Displayed);
        }

        [Then(@"I click logout link")]
        public void ThenIClickLogoutLink()
        {
            dashboardPage = UIHelper.PageInit<DashboardPage>(driver);
            UIHelper.ClickOnLink(dashboardPage.AccountDropdownElement);
            UIHelper.ClickOnLink(dashboardPage.LogOutElement);
            Thread.Sleep(2000);
        }

        [Then(@"I verify I am logged out")]
        public void ThenIVerifyIAmLoggedOut()
        {
            loginPage = UIHelper.PageInit<LoginPage>(driver);
            Assert.True(loginPage.LoginBtnElement.Displayed, "User could not be logged out");
        }
    }
}