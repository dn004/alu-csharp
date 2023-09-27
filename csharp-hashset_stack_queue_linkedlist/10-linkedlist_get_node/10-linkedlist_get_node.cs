using System;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if(n > myLList.Count)
        {
            return 0;
        }
        
        int count = -1;
        foreach (int value in myLList)
        {
            count ++;
            if(count == n)
            {
                return value;
            }
        }
        return 0;
    }
}