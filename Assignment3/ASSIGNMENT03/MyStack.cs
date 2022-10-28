using System;
using System.Collections;


namespace ASSIGNMENT03
{
    internal class MyStack
    {
        private int[] StackArray;
        private int top;   //index of top of the stack
        private int max;
        public MyStack(int size)
        {
            StackArray = new int[size];
            top = -1;   //empty stack
            max = size;  // size = 3 max = 3
        }

        public void push(int item)
        {
            if (top == max - 1)    // max - 1 = index of the top  
            {
                throw new StackException("Stack OverFlow !! You are trying to add items to the Stack that is full.");
            }
            else
            {
                StackArray[++top] = item;  //increment index
            }
        }

        public int pop()
        {
            if (top == -1)
            {
                throw new StackException("Error: No element to pop");
            }
            else
            {
                Console.WriteLine("Poped element is: " + StackArray[top]);
                return StackArray[top--];   // decrement the index
            }
        }
        public void displayStack()
        {
            if (top == -1)
            {
                throw new StackException("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Items inserted are: ");
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + StackArray[i]);
                }
            }
        }

    }
}
