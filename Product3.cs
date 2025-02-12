using System;
namespace Assignment_14_LinkedList
{
    class TaskNode
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public int Priority { get; set; }
        public DateTime DueDate { get; set; }
        public TaskNode Next { get; set; }
        public TaskNode(int taskId, string taskName, int priority, DateTime dueDate)
        {
            TaskID = taskId;
            TaskName = taskName;
            Priority = priority;
            DueDate = dueDate;
            Next = null;
        }
    }
    class TaskScheduler
    {
        private TaskNode tail;
        public void AddTaskAtStart(int taskId, string taskName, int priority, DateTime dueDate)
        {
            TaskNode newNode = new TaskNode(taskId, taskName, priority, dueDate);
            if (tail == null)
            {
                tail = newNode;
                tail.Next = tail;
            }
            else
            {
                newNode.Next = tail.Next;
                tail.Next = newNode;
            }
            Console.WriteLine($"Task {taskId} added at the start.");
        }
        public void AddTaskAtEnd(int taskId, string taskName, int priority, DateTime dueDate)
        {
            TaskNode newNode = new TaskNode(taskId, taskName, priority, dueDate);
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
            Console.WriteLine($"Task {taskId} added at the end.");
        }
        public void AddTaskAtPosition(int taskId, string taskName, int priority, DateTime dueDate, int position)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position.");
                return;
            }
            TaskNode newNode = new TaskNode(taskId, taskName, priority, dueDate);
            if (position == 1)
            {
                AddTaskAtStart(taskId, taskName, priority, dueDate);
                return;
            }

            TaskNode current = tail.Next;
            int count = 1;

            while (current != tail && count < position - 1)
            {
                current = current.Next;
                count++;
            }

            if (count != position - 1)
            {
                Console.WriteLine("Position out of bounds.");
                return;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
            Console.WriteLine($"Task {taskId} added at position {position}.");
        }

        public void RemoveTaskById(int taskId)
        {
            if (tail == null)
            {
                Console.WriteLine("No tasks to remove.");
                return;
            }

            TaskNode current = tail;
            TaskNode previous = null;
            do
            {
                if (current.Next.TaskID == taskId)
                {
                    if (current.Next == tail)
                    {
                        tail = current;
                    }
                    if (current.Next == current)
                    {
                        tail = null;
                    }
                    else
                    {
                        current.Next = current.Next.Next;
                    }
                    Console.WriteLine($"Task {taskId} removed.");
                    return;
                }
                previous = current;
                current = current.Next;
            } while (current != tail);

            Console.WriteLine($"Task {taskId} not found.");
        }

        public void ViewCurrentTaskAndMoveNext(ref TaskNode currentTask)
        {
            if (tail == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            if (currentTask == null) currentTask = tail.Next;

            Console.WriteLine($"Current Task: Task ID: {currentTask.TaskID}, Task Name: {currentTask.TaskName}, Priority: {currentTask.Priority}, Due Date: {currentTask.DueDate.ToShortDateString()}");
            currentTask = currentTask.Next;
        }

        public void DisplayAllTasks()
        {
            if (tail == null)
            {
                Console.WriteLine("No tasks in the list.");
                return;
            }

            Console.WriteLine("Task List:");
            TaskNode current = tail.Next;
            do
            {
                Console.WriteLine($"Task ID: {current.TaskID}, Task Name: {current.TaskName}, Priority: {current.Priority}, Due Date: {current.DueDate.ToShortDateString()}");
                current = current.Next;
            } while (current != tail.Next);
        }

        public void SearchTaskByPriority(int priority)
        {
            if (tail == null)
            {
                Console.WriteLine("No tasks to search.");
                return;
            }

            bool found = false;
            TaskNode current = tail.Next;
            do
            {
                if (current.Priority == priority)
                {
                    Console.WriteLine($"Task Found: Task ID: {current.TaskID}, Task Name: {current.TaskName}, Due Date: {current.DueDate.ToShortDateString()}");
                    found = true;
                }
                current = current.Next;
            } while (current != tail.Next);

            if (!found)
            {
                Console.WriteLine($"No tasks found with priority {priority}.");
            }
        }
    }
    class Program3
    {
        static void Main()
        {
            TaskScheduler scheduler = new TaskScheduler();
            scheduler.AddTaskAtEnd(1, "Design UI", 2, DateTime.Parse("2025-02-20"));
            scheduler.AddTaskAtStart(2, "Write Documentation", 1, DateTime.Parse("2025-02-15"));
            scheduler.AddTaskAtPosition(3, "Implement Feature", 3, DateTime.Parse("2025-03-01"), 2);

            scheduler.DisplayAllTasks();

            scheduler.RemoveTaskById(2);
            scheduler.DisplayAllTasks();

            TaskNode currentTask = null;
            Console.WriteLine("Viewing tasks in round-robin order:");
            for (int i = 0; i < 5; i++)
            {
                scheduler.ViewCurrentTaskAndMoveNext(ref currentTask);
            }

            scheduler.SearchTaskByPriority(3);
        }
    }
}
