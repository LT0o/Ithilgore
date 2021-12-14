using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        

        [Test]

        #region Test1
        public void GroupCreationTest()
        {
            GroupData group = new GroupData();
            group.Name = "zGroupName23";
            group.Header = "zGroupHeader";
            group.Footer = "zGroupFooter15";

            
            app.Groups.CreateGroup(group);
            app.Navigator.GoToGroupsPage();
            app.Auth.Logout();
        }
        #endregion

        [Test]

        #region Test2
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData();
            group.Name = "";
            group.Header = "";
            group.Footer = "";

            
            app.Groups.CreateGroup(group); 
            app.Navigator.GoToGroupsPage();
            app.Auth.Logout();
        }
        #endregion



        



    }
}
