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
        private bool acceptNextAlert = true;

        zMethods Methods = new zMethods();

        [SetUp]
        public void SetupTest()
        {
            Methods.SetupTest();
            driver = Methods.driver;
            verificationErrors = Methods.verificationErrors;
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

        #region Test
        [Test]
        public void ContactCreationTest()
        {
            Methods.zOpenHomePage();
            Methods.zLogin(new MyMethods.AccountData("admin", "secret"));
            InitNewContactCreation();
            FillContactForm();
            ReturnToHomePage();
            LogOut();
        }
        #endregion

        #region TestMethods
        private void InitNewContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        private void FillContactForm()
        {
            driver.FindElement(By.Name("firstname")).SendKeys("zFirstName17");
            driver.FindElement(By.Name("middlename")).SendKeys("zMiddleName");
            driver.FindElement(By.Name("lastname")).SendKeys("zLastName");
            driver.FindElement(By.Name("nickname")).SendKeys("zNickname");
            driver.FindElement(By.Name("title")).SendKeys("zTitle");
            driver.FindElement(By.Name("company")).SendKeys("zCompany");
            driver.FindElement(By.Name("address")).SendKeys("zAddress");
            driver.FindElement(By.Name("home")).SendKeys("zHome");
            driver.FindElement(By.Name("mobile")).SendKeys("zMobile");
            driver.FindElement(By.Name("work")).SendKeys("zWork");
            driver.FindElement(By.Name("fax")).SendKeys("zFax");
            driver.FindElement(By.Name("email")).SendKeys("zE-mail");
            driver.FindElement(By.Name("email2")).SendKeys("zE-mail2");
            driver.FindElement(By.Name("email3")).SendKeys("zE-mail3");
            driver.FindElement(By.Name("homepage")).SendKeys("zHomepage");
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText("1");
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText("January");
            driver.FindElement(By.Name("byear")).SendKeys("1990");
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText("1");
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText("January");
            driver.FindElement(By.Name("ayear")).SendKeys("1990");
            new SelectElement(driver.FindElement(By.Name("new_group"))).SelectByText("zGroupName15");
            driver.FindElement(By.Name("address2")).SendKeys("zAddress-2");
            driver.FindElement(By.Name("phone2")).SendKeys("zPhone-2");
            driver.FindElement(By.Name("notes")).SendKeys("zNotes");
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
        }

        private void ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
        }

        private void LogOut()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
        #endregion


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