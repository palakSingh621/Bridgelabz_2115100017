using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nunit_Assignment
{
    public class TaskManager
    {
        public string LongRunningTask()
        {
            Thread.Sleep(3000); // Simulating a long-running task (3 seconds)
            return "Task Completed";
        }
    }
}
