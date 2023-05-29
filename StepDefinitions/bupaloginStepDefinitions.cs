using MsTestDemoProject.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MsTestDemoProject.StepDefinitions
{
    [Binding]
    public sealed class bupaloginStepDefinitions
    {
        private IWebDriver driver;
        bupaLoginPageObjects bupaLoginPageObjects;
       public bupaloginStepDefinitions(IWebDriver driver, bupaLoginPageObjects bupaLoginPageObjects)
        {
            this.driver = driver;
            this.bupaLoginPageObjects = bupaLoginPageObjects;
                
        }

        
        [Given(@"navigate to Bupa Insurance page '([^']*)'")]
        public void GivenNavigateToBupaInsurancePage(string url)
        {
            bupaLoginPageObjects = new bupaLoginPageObjects(driver);
            bupaLoginPageObjects.navigateToURL(url);
        }

        [When(@"Click on health insurance")]
        public void WhenClickOnHealthInsurance()

        {
            
            bupaLoginPageObjects.clickOnHealthInsuranceLink();
            Thread.Sleep(1000);
            
        }

        [Then(@"Validate the Url has '([^']*)'")]
        public void ThenValidateTheUrlHas(string urlSubs)
        {
            bupaLoginPageObjects.verifyUrl(urlSubs);
        }


    }
}
