using System;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> myllist = new LinkedList<int>();

        if(size <= 0)
        {
            return myllist;
        }
        else
        {
            for(int i = 0; i<size; i++)
            {
                myllist.AddLast(i);
                Console.WriteLine(i);
            }
        }

        return myllist;
    }
}