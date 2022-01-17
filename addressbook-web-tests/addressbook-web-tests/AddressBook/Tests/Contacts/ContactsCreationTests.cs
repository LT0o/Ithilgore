using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactsCreationTests : AuthTestBase
    {


        [Test]
        public void ContactsCreationTest()
        {
            ContactData contact = new ContactData();
            contact.Firstname = "zFirstName129";
            contact.Middlename = "zMiddleName";
            contact.Lastname = "zLastName";
            contact.Nickname = "zNickname";
            contact.Title = "zTitle";
            contact.Company = "zCompany";
            contact.Address = "zAddress";
            contact.Home = "zHome";
            contact.Mobile = "zMobile";
            contact.Work = "zWork";
            contact.Fax = "zFax";
            contact.Email = "zEmail-1";
            contact.Email2 = "zEmail-2";
            contact.Email3 = "zEmail-3";
            contact.Homepage = "zHomepage";
            contact.Bday = "1";
            contact.Bmonth = "January";
            contact.Byear = "1990";
            contact.Aday = "1";
            contact.Amonth = "January";
            contact.Ayear = "1990";
            //contact.New_group = "zGroupName15";
            contact.New_group = null;
            contact.Address2 = "zAddress-2";
            contact.Phone2 = "zPhone-2";
            contact.Notes = "zNotes-2";
            



            app.Contacts.CreateContact(contact);

            app.Navigator.GoToHomePage();
            //app.Navigator.GoToHPandLogout();




        }


        [Test]
        public void ContactsCreationTest_2()
        {
            ContactData contact = new ContactData();
            contact.Firstname = "zFirstName129";
            contact.Middlename = "zMiddleName";
            contact.Lastname = "zLastName";
            contact.Nickname = "zNickname";
            contact.Title = "zTitle";
            contact.Company = "zCompany";
            contact.Address = "zAddress";
            contact.Home = "zHome";
            contact.Mobile = "zMobile";
            contact.Work = "zWork";
            contact.Fax = "zFax";
            contact.Email = "zEmail-1";
            contact.Email2 = "zEmail-2";
            contact.Email3 = "zEmail-3";
            contact.Homepage = "zHomepage";
            contact.Bday = "1";
            contact.Bmonth = "January";
            contact.Byear = "1990";
            contact.Aday = "1";
            contact.Amonth = "January";
            contact.Ayear = "1990";
            //contact.New_group = "zGroupName15";
            contact.New_group = null;
            contact.Address2 = "zAddress-2";
            contact.Phone2 = "zPhone-2";
            contact.Notes = "zNotes-2";



            List<ContactData> oldContacts = app.Contacts.GetContactList();
            app.Contacts.CreateContact(contact);
            app.Navigator.GoToHomePage();
            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.Add(contact);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);


        }





    }
}
