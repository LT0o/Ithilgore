using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

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
            manager.Navigator.GoToHomePage();
            return this;
        }
        private List<ContactData> contactCache = null;

        public List<ContactData> GetContactList()
        {
            if (contactCache == null)
            {
                contactCache = new List<ContactData>();
                manager.Navigator.GoToHomePage();
                //List<ContactData> contacts = new List<ContactData>();
                ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("tr[name='entry']"));


                foreach (IWebElement element in elements)
                {
                    IWebElement Firstname = element.FindElement(By.CssSelector("td:nth-child(3)"));
                    IWebElement Lastname = element.FindElement(By.CssSelector("td:nth-child(2)"));

                    //ContactData contact = new ContactData(null, null);
                    //contact.Firstname = element.Text;
                    //contact.Lastname = element.Text;
                    //contactCache.Add(contact); 
                    ContactData contact = new ContactData(element.Text)
                    {
                        Id = element.FindElement(By.TagName("input")).GetAttribute("value")
                    };
                    contactCache.Add(contact);



                }
            }


            return new List<ContactData>(contactCache);
        }





        public ContactsHelper Modify(int v, ContactData contact, ContactData newContactData)
        {
            ContactExistenceVer(contact);
            SelectContact(v);
            InitContactModification(v);
            FillContactForm2(newContactData);
            SubmitContactModification();
            return this;
        }

        

        public ContactsHelper Remove(ContactData contact, int v)
        {

            ContactExistenceVer(contact);
            SelectContact(v);
            RemoveContact();



            return this;
        }





        public ContactsHelper InitNewContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public ContactsHelper FillContactForm(ContactData contact)
        {

            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("middlename"), contact.Middlename);
            Type(By.Name("lastname"), contact.Lastname);
            Type(By.Name("nickname"), contact.Nickname);
            Type(By.Name("title"), contact.Title);
            Type(By.Name("company"), contact.Company);
            Type(By.Name("address"), contact.Address);
            Type(By.Name("home"), contact.Home);
            Type(By.Name("mobile"), contact.Mobile);
            Type(By.Name("work"), contact.Work);
            Type(By.Name("fax"), contact.Fax);
            Type(By.Name("email"), contact.Email);
            Type(By.Name("email2"), contact.Email2);
            Type(By.Name("email3"), contact.Email3);
            Type(By.Name("homepage"), contact.Homepage);                        
            //new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText(contact.Bday);
            Type2(By.Name("bday"), contact.Bday);
            //new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText(contact.Bmonth);
            Type2(By.Name("bmonth"), contact.Bmonth);
            Type(By.Name("byear"), contact.Byear);
            //new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText(contact.Aday);
            Type2(By.Name("aday"), contact.Aday);
            //new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText(contact.Amonth);
            Type2(By.Name("amonth"), contact.Amonth);
            Type(By.Name("ayear"), contact.Ayear);
            //new SelectElement(driver.FindElement(By.Name("new_group"))).SelectByText(contact.New_group);
            Type2(By.Name("new_group"), contact.New_group);
            Type(By.Name("address2"), contact.Address2);
            Type(By.Name("phone2"), contact.Phone2);
            Type(By.Name("notes"), contact.Notes);           
            return this;
        }

        #region SEE COMMENT - extra test 
        //Данный метод необходимо удалить после фикса бага с недостающим полем в форме редактирования контакта. 
        public ContactsHelper FillContactForm2(ContactData contact)
        {
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("middlename"), contact.Middlename);
            Type(By.Name("lastname"), contact.Lastname);
            Type(By.Name("nickname"), contact.Nickname);
            Type(By.Name("title"), contact.Title);
            Type(By.Name("company"), contact.Company);
            Type(By.Name("address"), contact.Address);
            Type(By.Name("home"), contact.Home);
            Type(By.Name("mobile"), contact.Mobile);
            Type(By.Name("work"), contact.Work);
            Type(By.Name("fax"), contact.Fax);
            Type(By.Name("email"), contact.Email);
            Type(By.Name("email2"), contact.Email2);
            Type(By.Name("email3"), contact.Email3);
            Type(By.Name("homepage"), contact.Homepage);
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText(contact.Bday);
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText(contact.Bmonth);
            Type(By.Name("byear"), contact.Byear);
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText(contact.Aday);
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText(contact.Amonth);
            Type(By.Name("ayear"), contact.Ayear);
            Type(By.Name("address2"), contact.Address2);
            Type(By.Name("phone2"), contact.Phone2);
            Type(By.Name("notes"), contact.Notes);
            return this;
        }
        #endregion



        public ContactsHelper SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            contactCache = null;
            return this;
        }


        //public ContactsHelper SelectContact(int index) - Это работает, но не является удобным. Оставлено для истории. 
        public ContactsHelper SelectContact(int index)
        {
            //driver.FindElement(By.Id(index.ToString())).Click();  - Это работает, но не является удобным. Оставлено для истории. 
            driver.FindElement(By.XPath("//table[@id='maintable']/tbody/tr[" + index + "]/td/input")).Click();
            return this;
        }

        public ContactsHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            driver.SwitchTo().Alert().Accept();
            contactCache = null;
            return this;
        }

        public int GetContactCount()
        {
            return driver.FindElements(By.CssSelector("tr[name='entry']")).Count;
        }

        public ContactsHelper InitContactModification(int index)
        {
            driver.FindElement(By.XPath("//table[@id='maintable']/tbody/tr[" + index + "]/td[8]/a/img")).Click();

            return this;
        }
        public ContactsHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();


            return this;
        }
        public void ContactExistenceVer(ContactData contact)
        {
            if (ContactExist())
            {
                return;
            }
            manager.Navigator.GoToHomePage();
            InitNewContactCreation();
            FillContactForm(contact);
            SubmitContactCreation();
            manager.Navigator.GoToHomePage();
        }

        public bool ContactExist()
        {            
            return IsElementPresent(By.XPath("//table[@id='maintable']/tbody/tr[2]/td/input"));
        }



    }
}
