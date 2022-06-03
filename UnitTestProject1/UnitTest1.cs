using diplom.WindowMenu;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClassCl classCalc = new ClassCl();
            string login = "admin";
            string password = "123";
            classCalc.Check(login, password);
            Assert.AreEqual(true, classCalc.Check(login, password));
        }
    }
}
