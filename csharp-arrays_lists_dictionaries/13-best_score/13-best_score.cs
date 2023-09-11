using System;

class Dictionary{
    public static string BestScore(Dictionary<string, int> myList){
        int count = 0;
        foreach (KeyValuePair<string, int> kvp in myList){
            count ++
            int dValue = myList(kvp.Value);
            if(count == 0){
                return "None";
            }
            else if (kvp.Value > dValue){
                dValue = kvp.Value;
            }

        }
        return dValue;
    }
}