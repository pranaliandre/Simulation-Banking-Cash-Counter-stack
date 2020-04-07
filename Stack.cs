using System;
namespace Simulation_Banking_Stack
{
    internal class Stack
    {
        static readonly int MAXIMUM = 1000;
        int top;
        int[] stack = new int[MAXIMUM];
        /// <summary>
        /// Method to check stack empty or not
        /// </summary>
        /// <returns></returns>
        bool isEmpty()
        {
            return (top < 0);
        }
        /// <summary>
        /// constructor
        /// </summary>
        public Stack()
        {
            top = -1;
        }
        /// <summary>
        /// Method to push the cash in stack
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        internal bool Push(int balance)
        {
            if(top>=MAXIMUM)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = balance;
                return true;
            }
        }
        /// <summary>
        /// Method to pop the cash from stack
        /// </summary>
        /// <returns></returns>
        internal int Pop()
        {
            if(top>0)
            {
                Console.WriteLine("Stack overflow");
                return 0;
            }
            else
            {
                int balance = stack[top--];
                return balance;
            }
        }
        /// <summary>
        /// Method to print the cash in stack
        /// </summary>
        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Customer available amount:");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
