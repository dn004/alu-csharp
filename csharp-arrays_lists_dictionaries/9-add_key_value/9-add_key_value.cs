using system;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        foreach (KeyValuePair<string, string> kvp in myDict){
            if(myDict[key] == kvp.Key || myDict[key] != kvp.Key){
                myDict[key] = value;
            }
        }
    return myDict;
    }
}