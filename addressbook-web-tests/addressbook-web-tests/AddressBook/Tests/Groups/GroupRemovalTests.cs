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
            GroupData group = new GroupData();
            group.Name = "zGroupName780000";
            group.Header = "zGroupHeader";
            group.Footer = "zGroupFooter15";

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Remove(group, 1);
            app.Navigator.GoToGroupsPage();
            //app.Navigator.GoToGPandLogout();

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0); 
            //RemoveAt(0) не работает для изначально пустого списка. Гетгрупп получает список - он пуст. Затем ремув создаёт группу и удаляет её. Затем Гетгрупп снова получает список. И он, естественно, снова пуст. 
            //Затем РемувЭт пытается удалить элемент из списка, но список-то пуст. 
            Assert.AreEqual(oldGroups, newGroups);
        }






    }
}
