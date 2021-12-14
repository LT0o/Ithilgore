using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        

        [Test]
        public void GroupRemovalTest()
        {
            app.Groups.Remove(11);

            app.Navigator.GoToGroupsPage();
            app.Auth.Logout();
        }

        

        

        

      
    }
}
