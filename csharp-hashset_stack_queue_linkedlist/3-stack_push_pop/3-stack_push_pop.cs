using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");
        
        if(aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine($"Top item:{aStack.Peek()}");
        }
        bool containsSearch = aStack.Contains(search);
        Console.WriteLine($"Stack contains {search}: {containsSearch}");

         for(int i = 0; i <= aStack.Count; i++)
         {
            if(containsSearch == true)
            {
                aStack.Pop();
            }
         }

        aStack.Push(newItem);

        return aStack;
    }
}