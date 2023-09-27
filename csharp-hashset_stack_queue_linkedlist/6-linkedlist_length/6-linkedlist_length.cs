using System;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;
        foreach(int integer in myLList)
        {
            count++;
        }

        return count;
    }
}