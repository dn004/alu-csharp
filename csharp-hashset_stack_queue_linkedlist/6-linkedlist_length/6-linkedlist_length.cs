using System;

class LList
{
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(972);
        myLList.AddLast(0);
        myLList.AddLast(8);
        myLList.AddLast(98);
        myLList.AddLast(-4);
        myLList.AddLast(8);

        Console.WriteLine(LList.Length(myLList));
    }
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