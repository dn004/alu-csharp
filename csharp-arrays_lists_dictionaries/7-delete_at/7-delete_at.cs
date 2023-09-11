using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        List<int> updatedList = new List<int>();
        
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        for (int i = 0; i < myList.Count; i++)
        {
            if (i != index)
            {
                updatedList.Add(myList[i]);
            }
        }

        return updatedList;
    }
}