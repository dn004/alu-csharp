using System;

class LList
{
    static void Main(string[] args)
    {
        LinkedList<int> llist;
        int size;

        size = 8;

        llist = LList.CreatePrint(size);
        Console.WriteLine("-------------");
        Console.WriteLine("Linked List Length: " + llist.Count);
    }
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