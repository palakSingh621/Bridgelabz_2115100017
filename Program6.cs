using System;
namespace Assignment_14_LinkedList
{
    class ProcessNode
    {
        public int ProcessID { get; set; }
        public int BurstTime { get; set; }
        public int Priority { get; set; }
        public ProcessNode Next { get; set; }

        public ProcessNode(int processId, int burstTime, int priority)
        {
            ProcessID = processId;
            BurstTime = burstTime;
            Priority = priority;
            Next = null;
        }
    }
    class RoundRobinScheduler
    {
        private ProcessNode tail;

        public void AddProcess(int processId, int burstTime, int priority)
        {
            ProcessNode newNode = new ProcessNode(processId, burstTime, priority);
            if (tail == null)
            {
                tail = newNode;
                tail.Next = tail;
            }
            else
            {
                newNode.Next = tail.Next;
                tail.Next = newNode;
                tail = newNode;
            }
            Console.WriteLine($"Process {processId} added.");
        }
        public void RemoveProcess(int processId)
        {
            if (tail == null)
            {
                Console.WriteLine("No processes to remove.");
                return;
            }

            ProcessNode current = tail;
            ProcessNode previous = null;
            do
            {
                if (current.Next.ProcessID == processId)
                {
                    if (current.Next == tail)
                    {
                        tail = current;
                    }
                    current.Next = current.Next.Next;
                    Console.WriteLine($"Process {processId} removed.");
                    return;
                }
                previous = current;
                current = current.Next;
            } while (current != tail);

            Console.WriteLine($"Process {processId} not found.");
        }

        public void SimulateRoundRobin(int timeQuantum)
        {
            if (tail == null)
            {
                Console.WriteLine("No processes to schedule.");
                return;
            }

            Console.WriteLine("Starting Round-Robin Scheduling...");
            int totalWaitingTime = 0;
            int totalTurnaroundTime = 0;
            int processCount = 0;
            int elapsedTime = 0;

            ProcessNode current = tail.Next;

            while (true)
            {
                bool allProcessesDone = true;
                ProcessNode startingPoint = current;
                do
                {
                    if (current.BurstTime > 0)
                    {
                        allProcessesDone = false;
                        int executionTime = Math.Min(current.BurstTime, timeQuantum);
                        Console.WriteLine($"Executing Process {current.ProcessID} for {executionTime} time units.");
                        current.BurstTime -= executionTime;
                        elapsedTime += executionTime;

                        if (current.BurstTime == 0)
                        {
                            totalTurnaroundTime += elapsedTime;
                            totalWaitingTime += elapsedTime - executionTime;
                            Console.WriteLine($"Process {current.ProcessID} completed execution.");
                            RemoveProcess(current.ProcessID);
                            if (tail == null)
                            {
                                break;
                            }
                        }
                    }
                    current = current.Next;
                } while (current != startingPoint);

                if (allProcessesDone)
                {
                    break;
                }

                DisplayProcesses();
            }

            Console.WriteLine("Scheduling completed.");
            processCount = totalTurnaroundTime == 0 ? 0 : elapsedTime / timeQuantum;

            if (processCount > 0)
            {
                Console.WriteLine($"Average Waiting Time: {(double)totalWaitingTime / processCount:F2}");
                Console.WriteLine($"Average Turnaround Time: {(double)totalTurnaroundTime / processCount:F2}");
            }
        }
        public void DisplayProcesses()
        {
            if (tail == null)
            {
                Console.WriteLine("No processes in the queue.");
                return;
            }

            Console.WriteLine("Current Process Queue:");
            ProcessNode current = tail.Next;
            do
            {
                Console.WriteLine($"Process ID: {current.ProcessID}, Burst Time: {current.BurstTime}, Priority: {current.Priority}");
                current = current.Next;
            } while (current != tail.Next);
        }
    }
    internal class Program6
    {
        static void Main()
        {
            RoundRobinScheduler scheduler = new RoundRobinScheduler();
            scheduler.AddProcess(1, 10, 1);
            scheduler.AddProcess(2, 5, 2);
            scheduler.AddProcess(3, 8, 1);
            scheduler.AddProcess(4, 6, 3);

            scheduler.DisplayProcesses();

            int timeQuantum = 3;
            Console.WriteLine($"Running simulation with time quantum {timeQuantum}...");
            scheduler.SimulateRoundRobin(timeQuantum);
        }
    }
}
