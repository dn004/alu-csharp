using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aQueue.Count}");
        if(aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine($"First item:{aQueue.Peek()}");
        }
        aQueue.Enqueue(newItem);

        bool containsSearch = aQueue.Contains(search);
        if(containsSearch == true)
        {
            Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");
        }
        for(int i = 0; i <= aQueue.Count; i++)
         {
            if(containsSearch == true)
            {
                aQueue.Dequeue();
            }
         }
         return aQueue;

    }

}