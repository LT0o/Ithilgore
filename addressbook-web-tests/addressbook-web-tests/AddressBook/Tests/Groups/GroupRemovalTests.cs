using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
        

        [Test]
        public void GroupRemovalTest()
        {
            GroupData group = new GroupData();
            group.Name = "zGroupName780000";
            group.Header = "zGroupHeader";
            group.Footer = "zGroupFooter15";

            app.Groups.Remove(group, 1);
            app.Navigator.GoToGroupsPage();
            //app.Navigator.GoToGPandLogout();
        }

        

        

        

      
    }
}
