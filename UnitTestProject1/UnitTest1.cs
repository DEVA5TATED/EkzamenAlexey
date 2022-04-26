using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using MyLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() //GetName
        {
            List<Task> list = new List<Task>();
            TaskList taskList = new TaskList("Name", list);
            Assert.AreEqual(taskList.GetName(), "Name");
        }
    }
}
