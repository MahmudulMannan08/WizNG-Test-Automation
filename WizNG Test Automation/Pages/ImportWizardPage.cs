using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WizNG_Test_Automation.Pages
{
    public class ImportWizardPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_ImportUserControl1_importWizard_fileUploader")]
        public IWebElement ChooseFileElement;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_ImportUserControl1_importWizard_wizardStartStepNext")]
        public IWebElement NextBtnElement;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_ImportUserControl1_importWizard_txtDataFileName")]
        public IWebElement NewFileNameElement;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_ImportUserControl1_importWizard_chkColumnNameinFirstDatarow")]
        public IWebElement FirstRowColumnChkBoxElement;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_ImportUserControl1_importWizard_chkBatchGeoCode")]
        public IWebElement GeocodeChkBoxElement;

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ContentPlaceHolder1_ImportUserControl1_importWizard']/tbody/tr[1]/td/table[2]/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr/td[2]/input[1]")]
        public IWebElement AutoMapBtnElement;

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_ImportUserControl1_importWizard_FinishNavigationTemplateContainerID_FinishButton")]
        public IWebElement FinishBtnElement;

        [FindsBy(How = How.LinkText, Using = "Data Files")]
        public IWebElement DataFilesLinkElement;

        //[FindsBy(How = How.Name, Using = "ctl00$ContentPlaceHolder1$ImportUserControl1$importWizard$StepNavigationTemplateContainerID$StepNextButton")]
        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_ImportUserControl1_importWizard_StepNavigationTemplateContainerID_StepNextButton")]
        public IWebElement NextStep2BtnElement;

        [FindsBy(How = How.TagName, Using = "table")]
        public IWebElement MyTableElement;
    }
}
