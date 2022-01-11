﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {


        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData();
            newData.Name = "zGroupName900900900";
            //newData.Header = "zGroupHeader10027";
            //newData.Footer = "zGroupFooter10027";
            newData.Header = null;
            newData.Footer = null;
            GroupData group = new GroupData();
            group.Name = "zGroupName27000";
            group.Header = "zGroupHeader";
            group.Footer = "zGroupFooter15";

            app.Groups.Modify(1, group, newData );
            app.Navigator.GoToGroupsPage();
            //app.Navigator.GoToGPandLogout();




        }








    }
}
