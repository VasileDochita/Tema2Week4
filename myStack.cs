using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8._1
{
    public class Mystack
    {
        internal class Stack
        {
            static readonly int maximum = 100;
            int top;
            int[] stack = new int[maximum];
            bool IsEmpty()
            {
                return (top < 0);
            }
            public Stack()
            {
                top = -1;
            }
            internal bool Push(int data)
            {
                if (top >= maximum)
                {
                    Console.WriteLine("Stack Overflow");
                    return false;
                }
                else
                {
                    stack[++top] = data;
                    return true;
                }
            }
            internal int Pop()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return 0;
                }
                else
                {
                    int value = stack[top--];
                    return value;
                }
            }
            internal void Peek()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                    Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
            }
            public void PrintStack()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                {
                    Console.WriteLine("Items in the Stack are :");
                    for (int i = top; i >= 0; i--)
                    {
                        Console.WriteLine(stack[i]);
                    }
                }
            }
        }
    }
}



    
    //public void Stack
    //{
    //    Stack<int> stack = new Stack<int>();
    //    stack.Push(1);
    //    stack.Push(2);
    //    stack.Push(3);
    //    stack.Push(4);
    //    stack.Push(5);
    //    stack.Push(6);
    //    stack.Push(7);
    //    stack.Push(8);
    //    stack.Push(9);

    //    foreach (var nr in stack)
    //    {
    //        Console.WriteLine(nr);

    //    }

    //    Console.WriteLine("\n Number of elements in out stack is : " + stack.Count);
    //    //Console.ReadLine();


    //    Console.WriteLine("\n let's pop an element : " + stack.Pop());
    //    Console.WriteLine("\n let's pop another element : " + stack.Pop());
    //    Console.WriteLine("\n Peek at the next item to be popped : " + stack.Peek());


    //    Console.ReadLine();


    //}

