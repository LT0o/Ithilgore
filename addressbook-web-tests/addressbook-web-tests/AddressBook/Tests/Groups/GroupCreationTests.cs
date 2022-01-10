using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
        

        [Test]

        #region Test1
        public void GroupCreationTest()
        {
            GroupData group = new GroupData();
            group.Name = "zGroupName27";
            group.Header = "zGroupHeader";
            group.Footer = "zGroupFooter15";

            
            app.Groups.CreateGroup(group);
            app.Navigator.GoToGroupsPage();
            //app.Navigator.GoToGPandLogout();
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
            app.Navigator.GoToGPandLogout();
        }
        #endregion



        



    }
}
