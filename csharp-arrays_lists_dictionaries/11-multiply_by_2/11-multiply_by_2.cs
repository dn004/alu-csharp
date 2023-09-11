using System;

class Dictionary{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict){

        Dictionary<string, int> newDict = new Dictionary<string, int>();

        foreach (KeyValuePair<string, int> kvp in myDict){

            newDict[kvp.Key] = kvp.Value * 2; 
        }
        return newDict;
    }
}