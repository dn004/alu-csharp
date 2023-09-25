using System;

class List
{
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