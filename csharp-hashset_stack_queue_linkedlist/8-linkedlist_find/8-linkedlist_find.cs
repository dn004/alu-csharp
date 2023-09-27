using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int count = -1;
        foreach(int noode in myLList)
        {
            count++;

            if(noode == value)
            {
                return count;
            }
        }

        return -1;
    }
}