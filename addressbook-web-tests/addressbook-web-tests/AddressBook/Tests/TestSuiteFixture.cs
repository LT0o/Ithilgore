using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [SetUpFixture]
    public class TestSuiteFixture
    {
       
        [SetUp]
        public void InitApplicationManager()
        {
            ApplicationManager app = ApplicationManager.GetInstance();
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }




    }
}
