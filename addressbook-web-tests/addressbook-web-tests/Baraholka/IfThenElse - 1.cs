﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IfThenElseNameSpace_1
{
    [TestClass]
    public class IfThenElseUnitTest_1
    {
        [TestMethod]

        public void TestMethod1()
        {
            double total = 999;
            bool vipClient = false;

            if (total >= 1000 || vipClient)
            //if (total > 1000 && vipClient)
            {
                total = total * 0.9;
                System.Console.Out.Write("Скидка 10%, общая сумма " + total);
            }
            else
            {
                System.Console.Out.Write("Скидки нет, общая сумма " + total);
            }
        }



    }
}
