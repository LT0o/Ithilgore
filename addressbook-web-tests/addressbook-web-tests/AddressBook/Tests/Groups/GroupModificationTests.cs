using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {


        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData();
            newData.Name = "zGroupName10027";
            newData.Header = "zGroupHeader10027";
            newData.Footer = "zGroupFooter10027";


            app.Groups.Modify(1, newData );
            app.Navigator.GoToGPandLogout();




        }








    }
}
