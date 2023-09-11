using System;

class Dictionary{
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key){
        
        foreach (KeyValuePair<string, string> kvp in myDict){
            if(myDict[key] == kvp.Key){
                myDict.Remove[key];
            }
        }
        return myDict;
    }
}