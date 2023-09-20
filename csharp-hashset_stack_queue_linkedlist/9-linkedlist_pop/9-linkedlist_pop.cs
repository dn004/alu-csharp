using System;
using System.Collections.Generic;
class LList
{
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(11);
        myLList.AddLast(3);
        myLList.AddLast(-9);
        myLList.AddLast(47);
        myLList.AddLast(0);
        myLList.AddLast(-9);

        Console.WriteLine(LList.Pop(myLList));
    }
    public static int Pop(LinkedList<int> myLList)
    {
        LinkedListNode<int> firstNode = myLList.First;
        int valueNode = firstNode.Value;

        if (firstNode != null)
        {
            myLList.Remove(firstNode);
        }
        else
        {
            return 0;
        }
        return valueNode;
    }
}