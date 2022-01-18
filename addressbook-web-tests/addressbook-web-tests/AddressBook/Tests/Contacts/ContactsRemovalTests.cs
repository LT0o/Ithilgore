using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    class ContactsRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            //4tester: Учитывается шапка таблицы. Выбираем число на +1 от необходимого. Хотим удалить третью строчку - в параметр вбиваем 4. 
            #region Test data for new contact 
            ContactData contact = new ContactData(null, null);
            contact.Firstname = "zFirstName783783783";
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

            app.Contacts.Remove(contact, 2);
            app.Navigator.GoToHomePage();
            //app.Navigator.GoToHPandLogout();
        }








    }
}
