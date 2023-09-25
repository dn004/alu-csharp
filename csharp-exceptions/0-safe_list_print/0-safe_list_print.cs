using System;

class List
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() {1, 2, 3, 4, 5};
        int count;

        count = List.SafePrint(myList, myList.Count);
        Console.WriteLine("Number of integers printed: " + count);
        Console.WriteLine();

        count = List.SafePrint(myList, myList.Count - 2);
        Console.WriteLine("Number of integers printed: " + count);
        Console.WriteLine();

        count = List.SafePrint(myList, myList.Count + 2);
        Console.WriteLine("Number of integers printed: " + count);
    }
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        try
        {
            for(int i = 0;i < n;i++)
            {
                Console.WriteLine(myList[i]);
                count++;
            }
        }
        catch(System.Exception)
        {
            return count;
        }
        return count;
    }
}