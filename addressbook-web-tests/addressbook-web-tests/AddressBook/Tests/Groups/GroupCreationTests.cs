using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
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

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.CreateGroup(group);
            //app.Navigator.GoToGroupsPage();
            List<GroupData> newGroups = app.Groups.GetGroupList();
            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);

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


            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.CreateGroup(group);
            Assert.AreEqual(oldGroups.Count + 1, app.Groups.GetGroupCount());
            //app.Navigator.GoToGroupsPage();
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
        #endregion

        [Test]

        #region Test3
        public void BadNameGroupCreationTest()
        {
            GroupData group = new GroupData();
            group.Name = "z'z";
            group.Header = "";
            group.Footer = "";


            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.CreateGroup(group);
            Assert.AreEqual(oldGroups.Count + 1, app.Groups.GetGroupCount());
            //app.Navigator.GoToGroupsPage();
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
        #endregion

        [Test]

        #region Test4
        public void GroupCreationTest_2()
        {
            GroupData group = new GroupData();
            group.Name = "zGroupName27";
            group.Header = "zGroupHeader";
            group.Footer = "zGroupFooter15";

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.CreateGroup(group);
            Assert.AreEqual(oldGroups.Count + 1, app.Groups.GetGroupCount());
            //app.Navigator.GoToGroupsPage();
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

            //app.Navigator.GoToGPandLogout();
        }
        #endregion



    }
}
