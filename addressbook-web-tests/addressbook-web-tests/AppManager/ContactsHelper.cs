﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ContactsHelper : HelperBase
    {


        public ContactsHelper(ApplicationManager manager)
            : base(manager)
        {
        }



        public ContactsHelper CreateContact(ContactData contact)
        {
            InitNewContactCreation();
            FillContactForm(contact);
            SubmitContactCreation();
            return this;
        }




     

        public ContactsHelper InitNewContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public ContactsHelper FillContactForm(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
            driver.FindElement(By.Name("middlename")).SendKeys(contact.Middlename);
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
            driver.FindElement(By.Name("nickname")).SendKeys(contact.Nickname);
            driver.FindElement(By.Name("title")).SendKeys(contact.Title);
            driver.FindElement(By.Name("company")).SendKeys(contact.Company);
            driver.FindElement(By.Name("address")).SendKeys(contact.Address);
            driver.FindElement(By.Name("home")).SendKeys(contact.Home);
            driver.FindElement(By.Name("mobile")).SendKeys(contact.Mobile);
            driver.FindElement(By.Name("work")).SendKeys(contact.Work);
            driver.FindElement(By.Name("fax")).SendKeys(contact.Fax);
            driver.FindElement(By.Name("email")).SendKeys(contact.Email);
            driver.FindElement(By.Name("email2")).SendKeys(contact.Email2);
            driver.FindElement(By.Name("email3")).SendKeys(contact.Email3);
            driver.FindElement(By.Name("homepage")).SendKeys(contact.Homepage);
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText(contact.Bday);
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText(contact.Bmonth);
            driver.FindElement(By.Name("byear")).SendKeys(contact.Byear);
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText(contact.Aday);
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText(contact.Amonth);
            driver.FindElement(By.Name("ayear")).SendKeys(contact.Ayear);
            new SelectElement(driver.FindElement(By.Name("new_group"))).SelectByText(contact.New_group);
            driver.FindElement(By.Name("address2")).SendKeys(contact.Address2);
            driver.FindElement(By.Name("phone2")).SendKeys(contact.Phone2);
            driver.FindElement(By.Name("notes")).SendKeys(contact.Notes);





            return this;
        }


        public ContactsHelper SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }


        







        


    }
}