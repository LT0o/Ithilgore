using System;
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
            newData.Name = "zGroupName300";
            //newData.Header = "zGroupHeader10027";
            //newData.Footer = "zGroupFooter10027";
            newData.Header = null;
            newData.Footer = null;

            app.Groups.Modify(1, newData );
            app.Navigator.GoToGroupsPage();
            //app.Navigator.GoToGPandLogout();




        }








    }
}
