using System;

class LList
{
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(21);
        myLList.AddLast(9);
        myLList.AddLast(-8);
        myLList.AddLast(54);
        myLList.AddLast(23);
        myLList.AddLast(-6);
        myLList.AddLast(5);

        Console.WriteLine(LList.Sum(myLList));
    }
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;
        foreach (int value in myLList)
        {
            sum += value;
        }
        return sum;
    }
}