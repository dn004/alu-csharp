using System;
using System.Collections.Generic;
class LList
{
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