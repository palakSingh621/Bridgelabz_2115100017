using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Nunit_Assignment
{
    [TestFixture]
    public class TaskManagerTests
    {
        private TaskManager _taskManager;

        [SetUp]
        public void Setup()
        {
            _taskManager = new TaskManager();
        }

        [Test, Timeout(2000)] // Fail if it takes more than 2 seconds
        public void LongRunningTask_ShouldFailIfExceedsTimeout()
        {
            string result = _taskManager.LongRunningTask();
            Assert.AreEqual("Task Completed", result);
        }
    }
}
