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
            app.Contacts.Remove(3);
            app.Navigator.GoToHomePage();
            //app.Navigator.GoToHPandLogout();
        }








    }
}
