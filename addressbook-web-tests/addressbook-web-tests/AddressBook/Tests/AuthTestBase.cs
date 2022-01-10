﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    public class AuthTestBase : TestBase
    {


        [SetUp]
        public void SetupLogin()
        {
            #region preset
            AccountData account = new AccountData();
            account.Username = "admin";
            account.Password = "secret";
            #endregion
            app = ApplicationManager.GetInstance();
            app.Auth.Login(account);

        }







    }
}
