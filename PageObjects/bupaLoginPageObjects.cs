using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTestDemoProject.PageObjects
{
    public class bupaLoginPageObjects
    {
        private IWebDriver driver;
   
        public bupaLoginPageObjects(IWebDriver driver)
        {
            this.driver = driver;
        }

       
        public void navigateToURL(string url)
        {
            driver.Url = url;
        }

      public void clickOnHealthInsuranceLink()
        {
            driver.FindElement(By.TagName("shared-ui.mega-menu")).GetShadowRoot().FindElement(By.CssSelector("header")).FindElement(By.CssSelector("div")).FindElement(By.CssSelector("div")).FindElement(By.CssSelector("div")).FindElement(By.CssSelector("ul")).FindElement(By.CssSelector("li")).FindElement(By.CssSelector("a")).Click();

        }
        public void verifyUrl(string urlSubString)
        {
           string currentURL = driver.Url;
            Assert.IsTrue(currentURL.Contains(urlSubString));
        }
    }
}
