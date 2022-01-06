using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    class ContactsModsTests : TestBase
    {

        [Test]
        public void ContactModificationTest()
        {
            #region Testdata
            ContactData contact = new ContactData();
            contact.Firstname = "zFirstName3000";
            //contact.Middlename = "zMiddleName";
            contact.Middlename = null;
            contact.Lastname = "zLastName3000";
            contact.Nickname = "zNickname3000";
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
            //contact.New_group = "zGroupName15"; - Поле отсутствует. Предполагаю баг в системе. После фикса бага строчку надо будет раскомментировать. Поэтому отсюда её не удаляю. 
            contact.Address2 = "zAddress-2";
            contact.Phone2 = "zPhone-2";
            contact.Notes = "zNotes-2";
            #endregion
            app.Contacts.Modify(2, contact);
            app.Navigator.GoToHPandLogout();
        }


    }
}
