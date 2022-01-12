using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace addressbook_web_tests.AddressBook.Tests.Cycles
{
    [TestClass]
    public class Cycle2
    {
        [TestMethod]
        public void TestMethod2()
        {            
            string[] s = new string[] { "I", "want", "to", "sleep" };
            foreach (string element in s)
            {
                System.Console.Out.Write(element + "\n");
            }
        }
    }
}
