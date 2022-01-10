using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            AccountData account = new AccountData();
            account.Username = "admin";
            account.Password = "secret";

            //prepare 
            app.Auth.Logout();
            //action 
            app.Auth.Login(account);
            //verification 
            Assert.IsTrue(app.Auth.IsLoggedIn(account));
        }

        [Test]
        public void LoginWithInvalidCredentials()
        {
            AccountData account = new AccountData();
            account.Username = "admin";
            account.Password = "123456789";

            //prepare 
            app.Auth.Logout();
            //action 
            app.Auth.Login(account);
            //verification 
            Assert.IsFalse(app.Auth.IsLoggedIn(account));
        }




    }
}
