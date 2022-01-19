using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    class ContactsModsTests : AuthTestBase
    {

        [Test]
        public void ContactModificationTest()
        {
            #region Testdata
            ContactData newContactData = new ContactData(null, null);
            newContactData.Firstname = "zFirstName900000000";
            //newContactData.Middlename = "zMiddleName";
            newContactData.Middlename = null;
            newContactData.Lastname = "zLastName3000";
            newContactData.Nickname = "zNickname3000";
            newContactData.Title = "zTitle";
            newContactData.Company = "zCompany";
            newContactData.Address = "zAddress";
            newContactData.Home = "zHome";
            newContactData.Mobile = "zMobile";
            newContactData.Work = "zWork";
            newContactData.Fax = "zFax";
            newContactData.Email = "zEmail-1";
            newContactData.Email2 = "zEmail-2";
            newContactData.Email3 = "zEmail-3";
            newContactData.Homepage = "zHomepage";
            newContactData.Bday = "1";
            newContactData.Bmonth = "January";
            newContactData.Byear = "1990";
            newContactData.Aday = "1";
            newContactData.Amonth = "January";
            newContactData.Ayear = "1990";
            //newContactData.New_group = "zGroupName15"; - Поле отсутствует. Предполагаю баг в системе. После фикса бага строчку надо будет раскомментировать. Поэтому отсюда её не удаляю. 
            newContactData.Address2 = "zAddress-2";
            newContactData.Phone2 = "zPhone-2";
            newContactData.Notes = "zNotes-2";

            #region Test data for new contact 
            ContactData contact = new ContactData(null, null);
            contact.Firstname = "zFirstName333333333";
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
            #endregion 

            #endregion
            app.Contacts.Modify(2, contact, newContactData);
            app.Navigator.GoToHomePage();
            //app.Navigator.GoToHPandLogout();
        }

        [Test]
        public void ContactModificationTest2()
        {
            #region Testdata
            ContactData newContactData = new ContactData(null, null);
            newContactData.Firstname = "zFirstName900000000";
            //newContactData.Middlename = "zMiddleName";
            newContactData.Middlename = null;
            newContactData.Lastname = "zLastName3000";
            newContactData.Nickname = "zNickname3000";
            newContactData.Title = "zTitle";
            newContactData.Company = "zCompany";
            newContactData.Address = "zAddress";
            newContactData.Home = "zHome";
            newContactData.Mobile = "zMobile";
            newContactData.Work = "zWork";
            newContactData.Fax = "zFax";
            newContactData.Email = "zEmail-1";
            newContactData.Email2 = "zEmail-2";
            newContactData.Email3 = "zEmail-3";
            newContactData.Homepage = "zHomepage";
            newContactData.Bday = "1";
            newContactData.Bmonth = "January";
            newContactData.Byear = "1990";
            newContactData.Aday = "1";
            newContactData.Amonth = "January";
            newContactData.Ayear = "1990";
            //newContactData.New_group = "zGroupName15"; - Поле отсутствует. Предполагаю баг в системе. После фикса бага строчку надо будет раскомментировать. Поэтому отсюда её не удаляю. 
            newContactData.Address2 = "zAddress-2";
            newContactData.Phone2 = "zPhone-2";
            newContactData.Notes = "zNotes-2";

            #region Test data for new contact 
            //ContactData contact = new ContactData(null, null);
            //contact.Firstname = "zFirstName333333333";
            //contact.Middlename = "zMiddleName";
            //contact.Lastname = "zLastName";
            //contact.Nickname = "zNickname";
            //contact.Title = "zTitle";
            //contact.Company = "zCompany";
            //contact.Address = "zAddress";
            //contact.Home = "zHome";
            //contact.Mobile = "zMobile";
            //contact.Work = "zWork";
            //contact.Fax = "zFax";
            //contact.Email = "zEmail-1";
            //contact.Email2 = "zEmail-2";
            //contact.Email3 = "zEmail-3";
            //contact.Homepage = "zHomepage";
            //contact.Bday = "1";
            //contact.Bmonth = "January";
            //contact.Byear = "1990";
            //contact.Aday = "1";
            //contact.Amonth = "January";
            //contact.Ayear = "1990";
            ////contact.New_group = "zGroupName15";
            //contact.New_group = null;
            //contact.Address2 = "zAddress-2";
            //contact.Phone2 = "zPhone-2";
            //contact.Notes = "zNotes-2";
            #endregion 

            #endregion
            
            
            
            //app.Contacts.Modify(2, null, newContactData);
            //app.Navigator.GoToHomePage();
            //app.Navigator.GoToHPandLogout(); 


            List<ContactData> oldContacts = app.Contacts.GetContactList();
            ContactData oldData = oldContacts[0];

            app.Contacts.Modify2(0, newContactData);

            Assert.AreEqual(oldContacts.Count, app.Contacts.GetContactCount());


            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts[0].Firstname = newContactData.Firstname;
            oldContacts[0].Lastname = newContactData.Lastname;
            oldContacts.Sort();
            newContacts.Sort();

            Assert.AreEqual(oldContacts, newContacts);

            foreach (ContactData contact in newContacts)
            {
                if (contact.Id == oldData.Id)
                {
                    Assert.AreEqual(newContactData.Firstname, contact.Firstname);
                    Assert.AreEqual(newContactData.Lastname, contact.Lastname);                    
                }
            }
        }


    }
}
