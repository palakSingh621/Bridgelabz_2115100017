using System;
namespace Assignment_15_DSA2
{
    class Node
    {
        public int Data { get; set; }
        public Node Next;
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    class Stack
    {
        public Node head;
        public Stack()
        {
            head = null;
        }
        //Method to push the node in stack
        public void push(int data)
        {
            Node node = new Node(data);
            node.Next = head;
            head = node;
        }
        //Method to pop the node in stack
        public int pop()
        {
            if (head == null)
            {
                return -1;
            }
            int data = head.Data;
            head = head.Next;
            return data;
        }
        //Method to peep the top node in stack
        public int peek()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return head.Data;
        }
        //Method to display stack
        public void displayStack()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Node temp = head;
            while (temp.Next != null)
            {
                Console.WriteLine($" {temp.Data} ");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack1 = new Stack();
            Stack stack2 = new Stack();
            while (true)
            {
                Console.WriteLine("List of Queue Methods: ");
                Console.WriteLine("1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. View Queue");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the number to Enqueue: ");
                        int data = Convert.ToInt32(Console.ReadLine());
                        stack1.push(data);
                        stack1.displayStack();
                        break;
                    case 2:
                        if (stack2 == null)
                        {
                            while (stack1 != null)
                            {
                                stack2.push(stack1.pop());
                            }
                        }
                        int s = stack2.pop();
                        Console.WriteLine($"{s} is removed from the queue");
                        while (stack2 != null)
                        {
                            stack1.push(stack2.pop());
                        }
                        break;
                    case 3:
                        stack1.displayStack();
                        break;
                    case 4:
                        return;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
