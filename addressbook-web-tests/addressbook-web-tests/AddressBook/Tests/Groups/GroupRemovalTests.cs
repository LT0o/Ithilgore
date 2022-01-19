using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
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

        [Test]
        public void GroupRemovalTest_2()
        {
            //GroupData group = new GroupData();
            //group.Name = "zGroupName780000";
            //group.Header = "zGroupHeader";
            //group.Footer = "zGroupFooter15";

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Remove2(0);
            //app.Navigator.GoToGroupsPage();
            //app.Navigator.GoToGPandLogout();
            Assert.AreEqual(oldGroups.Count - 1, app.Groups.GetGroupCount());
            List<GroupData> newGroups = app.Groups.GetGroupList();
            GroupData toBeRemoved = oldGroups[0];
            oldGroups.RemoveAt(0); 
            
            Assert.AreEqual(oldGroups, newGroups);

            foreach (GroupData group in newGroups)
            {
                Assert.AreNotEqual(group.Id, toBeRemoved.Id);
            }
        }

        





    }
}
