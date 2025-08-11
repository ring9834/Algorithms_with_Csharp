using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class ArrayStack
    {
        private int[] stackArray;
        private int top;
        private int capacity;

        public ArrayStack(int size)
        {
            capacity = size;
            stackArray = new int[capacity];
            top = -1;
        }

        public void Push(int item)
        {
            if (top == capacity - 1)
            {
                Console.WriteLine("Stack Overflow! Cannot push item.");
                return;
            }
            stackArray[++top] = item;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow! Cannot pop item.");
                return -1; // Or throw exception
            }
            return stackArray[top--];
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return -1; // Or throw exception
            }
            return stackArray[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return;
            }
            Console.WriteLine("Stack elements:");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stackArray[i]);
            }
        }
    }
}
