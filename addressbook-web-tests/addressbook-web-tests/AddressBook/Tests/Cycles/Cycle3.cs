using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests.AddressBook.Tests.Cycles
{
    [TestClass]
    public class Cycle3
    {
        [TestMethod]
        public void TestMethod3()
        {
            IWebDriver driver = null; 

            while (driver.FindElements(By.Id("test")).Count == 0)
            {
                System.Threading.Thread.Sleep(1000);
            }

            // ..... 
        }
    }
}
