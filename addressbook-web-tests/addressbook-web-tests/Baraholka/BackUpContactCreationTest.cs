using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using MyMethods;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        //private string baseURL;
        private bool acceptNextAlert = true;

        zMethods Methods = new zMethods();

        [SetUp]
        public void SetupTest()
        {
            Methods.SetupTest();
            driver = Methods.driver;
            verificationErrors = Methods.verificationErrors;
            //driver = new ChromeDriver();
            //baseURL = "http://localhost/addressbook";
            //verificationErrors = new StringBuilder();
        }

        #region TearDown
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        #endregion

        [Test]
        public void ContactCreationTest()
        {
            Methods.zOpenHomePage();
            Methods.zLogin(new MyMethods.AccountData("admin", "secret"));
           

            driver.FindElement(By.LinkText("add new")).Click();

            //driver.FindElement(By.Name("firstname")).Click();
            //driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys("zFirstName9");
            //driver.FindElement(By.Name("middlename")).Click();
            //driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys("zMiddleName");
            //driver.FindElement(By.Name("lastname")).Click();
            //driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys("zLastName");
            //driver.FindElement(By.Name("nickname")).Click();
            //driver.FindElement(By.Name("nickname")).Clear();
            driver.FindElement(By.Name("nickname")).SendKeys("zNickname");
            //driver.FindElement(By.Name("title")).Click();
            //driver.FindElement(By.Name("title")).Clear();
            driver.FindElement(By.Name("title")).SendKeys("zTitle");
            //driver.FindElement(By.Name("company")).Click();
            //driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("company")).SendKeys("zCompany");
            //driver.FindElement(By.Name("address")).Click();
            //driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys("zAddress");         
            //driver.FindElement(By.Name("home")).Click();
            //driver.FindElement(By.Name("home")).Clear();
            driver.FindElement(By.Name("home")).SendKeys("zHome");
            //driver.FindElement(By.Name("mobile")).Click();
            //driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("mobile")).SendKeys("zMobile");
            //driver.FindElement(By.Name("work")).Click();
            //driver.FindElement(By.Name("work")).Clear();
            driver.FindElement(By.Name("work")).SendKeys("zWork");
            //driver.FindElement(By.Name("fax")).Click();
            //driver.FindElement(By.Name("fax")).Clear();
            driver.FindElement(By.Name("fax")).SendKeys("zFax");
            //driver.FindElement(By.Name("email")).Click();
            //driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("zE-Mail");            
            //driver.FindElement(By.Name("email")).Click();
            //driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("zE-mail");
            //driver.FindElement(By.Name("email2")).Click();
            //driver.FindElement(By.Name("email2")).Clear();
            driver.FindElement(By.Name("email2")).SendKeys("zE-mail2");
            //driver.FindElement(By.Name("email3")).Click();
            //driver.FindElement(By.Name("email3")).Clear();
            driver.FindElement(By.Name("email3")).SendKeys("zE-mail3");
            //driver.FindElement(By.Name("homepage")).Click();
            //driver.FindElement(By.Name("homepage")).Clear();
            driver.FindElement(By.Name("homepage")).SendKeys("zHomepage");
            //driver.FindElement(By.Name("bday")).Click();
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText("1");
            //driver.FindElement(By.Name("bmonth")).Click();
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText("January");
            //driver.FindElement(By.Name("byear")).Click();
            //driver.FindElement(By.Name("byear")).Clear();
            driver.FindElement(By.Name("byear")).SendKeys("1990");
            //driver.FindElement(By.Name("aday")).Click();
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText("1");
            //driver.FindElement(By.Name("amonth")).Click();
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText("January");
            //driver.FindElement(By.Name("ayear")).Click();
            //driver.FindElement(By.Name("ayear")).Clear();
            driver.FindElement(By.Name("ayear")).SendKeys("1990");
            //driver.FindElement(By.Name("new_group")).Click();
            new SelectElement(driver.FindElement(By.Name("new_group"))).SelectByText("zGroupName");
            //driver.FindElement(By.Name("address2")).Click();
            //driver.FindElement(By.Name("address2")).Clear();
            driver.FindElement(By.Name("address2")).SendKeys("zAddress-2");
            //driver.FindElement(By.Name("theform")).Click();
            //driver.FindElement(By.Name("phone2")).Click();
            //driver.FindElement(By.Name("phone2")).Clear();
            driver.FindElement(By.Name("phone2")).SendKeys("zHome-2");
            //driver.FindElement(By.Name("theform")).Click();
            //driver.FindElement(By.Name("notes")).Click();
            //driver.FindElement(By.Name("notes")).Clear();
            driver.FindElement(By.Name("notes")).SendKeys("zNotes");
            //driver.FindElement(By.Name("theform")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();

            driver.FindElement(By.LinkText("home")).Click();

            driver.FindElement(By.LinkText("Logout")).Click();
        }



        #region DriverMethods

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
        #endregion
    }
}