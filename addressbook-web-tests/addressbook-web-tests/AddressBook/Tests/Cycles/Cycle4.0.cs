using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests.AddressBook.Tests.Cycles
{
    [TestClass]
    public class Cycle4
    {
        [TestMethod]
        public void TestMethod4()
        {
            IWebDriver driver = null;
            int attempt = 0; 

            while (driver.FindElements(By.Id("test")).Count == 0 && attempt <= 60)
            {
                System.Threading.Thread.Sleep(1000);
                //attempt = attempt + 1; 
                attempt++;
            }

            // ..... 
        }
    }
}
