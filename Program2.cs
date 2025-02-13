using System;
namespace Assignment_15_DSA2
{
    internal class StackRecur
    {
        static int MAX = 1000;
        int top = -1;
        int[] Stack = new int[MAX];

        public void Push(int value)
        {
            if (top >= MAX)
            {
                Console.WriteLine("The stack is full");
            }
            else
            {
                Stack[++top] = value;
            }
        }

        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("The stack is empty");
                return -1;
            }
            return Stack[top--];
        }

        public int Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                return Stack[top];
            }
        }

        public void DisplayStack()
        {
            int i = top;
            while (i >= 0)
            {
                Console.WriteLine(Stack[i]);
                i--;
            }
        }

        public void SortStack()
        {
            if (top < 0)
            {
                return;
            }
            int temp = Pop();
            SortStack();
            sortInserted(temp);
        }

        public void sortInserted(int x)
        {
            if (top < 0 || Stack[top] < x)
            {
                Push(x);
                return;
            }
            int temp = Pop();
            sortInserted(x);
            Push(temp);

        }
    }
    internal class Program2
    {
        public static void Main(String[] args)
        {
            StackRecur stack = new StackRecur();
            stack.Push(-11);
            stack.Push(-13);
            stack.Push(91);
            stack.Push(91);
            stack.Pop();
            stack.Push(19);
            stack.DisplayStack();
            stack.SortStack();
            stack.DisplayStack();
        }
    }
}
