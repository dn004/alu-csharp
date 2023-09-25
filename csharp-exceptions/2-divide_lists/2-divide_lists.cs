using System;

class List
{
    static void Main(string[] args)
    {
        List<int> list1 = new List<int>() {1, 20, 16, 15, 54};
        List<int> list2 = new List<int>() {1, 0, 2, 3};
        List<int> result;

        result = List.Divide(list1, list2, 5);

        foreach (int i in result)
            Console.WriteLine(i);
    }
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> dvdlist = new List<int>{};
        int result = 0;
        for(int i = 0;i < listLength;i++)
        {
            try
            {
               result = list1[i]/list2[i];
               dvdlist.Add(result);
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                dvdlist.Add(0);
            }
        }
        return dvdlist;
    }
}