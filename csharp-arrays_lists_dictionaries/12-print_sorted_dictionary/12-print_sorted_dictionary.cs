using System;
public class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var sortedDict = myDict.OrderBy(pair => pair.Key);

        foreach (var kvp in sortedDict)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
