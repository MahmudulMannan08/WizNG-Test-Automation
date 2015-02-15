using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;
using WizNG_Test_Automation.Pages;
using System.Diagnostics;
using System.IO;

namespace WizNG_Test_Automation.Steps
{
    [Binding]
    public class ImportFileSteps : TestBase
    {
        public static DashboardPage dashboardPage;
        public static ImportWizardPage importWizardPage;
        string NewFilename = null;
        int i = 0;

        [Then(@"I click on import wizard")]
        public void ThenIClickOnImportWizard()
        {
            dashboardPage = UIHelper.PageInit<DashboardPage>(driver);
            UIHelper.ClickOnLink(dashboardPage.ImportWizardElement);
            Thread.Sleep(1000);

            importWizardPage = UIHelper.PageInit<ImportWizardPage>(driver);
            UIHelper.ClickOnLink(importWizardPage.ChooseFileElement);
            Thread.Sleep(1000);
        }

        [Then(@"I select \.csv file and file name")]
        public void ThenISelect_CsvFileAndFileName()
        {
            System.Windows.Forms.SendKeys.SendWait("C:\\TFS_Ehasan\\HMDAWiz\\SQA\\Test Scripts\\Import\\10RecordComma09.csv");
            System.Windows.Forms.SendKeys.SendWait("{ENTER}");
            //Thread.Sleep(2000);

            importWizardPage = UIHelper.PageInit<ImportWizardPage>(driver);
            NewFilename = "Testfile " + RandomString(5);
            UIHelper.EnterText(importWizardPage.NewFileNameElement, NewFilename);
        }

        [Then(@"I select \.txt file and file name")]
        public void ThenISelect_TxtFileAndFileName()
        {
            System.Windows.Forms.SendKeys.SendWait("C:\\TFS_Ehasan\\HMDAWiz\\SQA\\Test Scripts\\Import\\10RecordComma08.txt");
            System.Windows.Forms.SendKeys.SendWait("{ENTER}");
            //Thread.Sleep(2000);

            importWizardPage = UIHelper.PageInit<ImportWizardPage>(driver);
            NewFilename = "Testfile " + RandomString(5);
            UIHelper.EnterText(importWizardPage.NewFileNameElement, NewFilename);
            Thread.Sleep(1000);
        }


        [Then(@"I click on next")]
        public void ThenIClickOnNext()
        {
            importWizardPage = UIHelper.PageInit<ImportWizardPage>(driver);
            UIHelper.ClickOnLink(importWizardPage.NextBtnElement);
            Thread.Sleep(1000);
        }

        [Then(@"I check first row column checkbox")]
        public void ThenICheckFirstRowColumnCheckbox()
        {
            importWizardPage = UIHelper.PageInit<ImportWizardPage>(driver);
            UIHelper.SetCheckbox(importWizardPage.FirstRowColumnChkBoxElement, "ON");
            Thread.Sleep(1000);
        }

        [Then(@"I click on next of step two")]
        public void ThenIClickOnNextOfStepTwo()
        {
            importWizardPage = UIHelper.PageInit<ImportWizardPage>(driver);
            UIHelper.ClickOnLink(importWizardPage.NextStep2BtnElement);
            Thread.Sleep(2000);
        }

        [Then(@"I check dont auto geocode checkbox")]
        public void ThenICheckDontAutoGeocodeCheckbox()
        {
            importWizardPage = UIHelper.PageInit<ImportWizardPage>(driver);
            UIHelper.SetCheckbox(importWizardPage.GeocodeChkBoxElement, "ON");
            Thread.Sleep(1000);
        }

        [Then(@"I AutoMap my files")]
        public void ThenIAutoMapMyFiles()
        {
            //Thread.Sleep(2000);
            importWizardPage = UIHelper.PageInit<ImportWizardPage>(driver);
            UIHelper.ClickOnLink(importWizardPage.AutoMapBtnElement);
        }

        [Then(@"I click on finish")]
        public void ThenIClickOnFinish()
        {
            importWizardPage = UIHelper.PageInit<ImportWizardPage>(driver);
            UIHelper.ClickOnLink(importWizardPage.FinishBtnElement);
        }

        [Then(@"I verify my file is saved")]
        public void ThenIVerifyMyFileIsSaved()
        {
            importWizardPage = UIHelper.PageInit<ImportWizardPage>(driver);
            UIHelper.ClickOnLink(importWizardPage.DataFilesLinkElement);
            Thread.Sleep(2000);

            driver.Navigate().Refresh();
            Thread.Sleep(1000);

            for (i = 0; i < 20; )
            {
                var xpat = "//*[@id='ctl00_ContentPlaceHolder1_rGridDataFile_ctl00__" + i + "']/td[3]";
                if (driver.WrappedDriver.FindElement(By.XPath(xpat)).Text.Contains(NewFilename) )
                {
                    break;
                }
                else
                {
                    i++;
                }
                   
            }
            if (i==20)
            {
                Assert.Fail("Could not find my LAR file");
            }
        }

        public string filePath { get; set; }
    }
}
