using System;

class List {
    public static int MaxInteger(List<int> myList){
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        else
        {
            int lrgNum = myList[0];
            for (int i = 1; i < myList.Count; i++)
            {
                if (myList[i] > lrgNum)
                {
                    lrgNum = myList[i];
                }
            }
        return lrgNum;
    
        }
    }
}