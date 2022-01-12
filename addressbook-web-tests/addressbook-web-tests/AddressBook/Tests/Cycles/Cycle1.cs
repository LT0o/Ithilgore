using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace addressbook_web_tests.AddressBook.Tests.Cycles
{
    [TestClass]
    public class Cycle1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //string s = "test";
            string[] s = new string[] { "I", "want", "to", "sleep" };
            //for(int i = 0; i < 10; i = i + 1)
            for (int i = 0; i < s.Length; i++)
            {
                System.Console.Out.Write(s[i] + "\n");
            }
        }
    }
}
