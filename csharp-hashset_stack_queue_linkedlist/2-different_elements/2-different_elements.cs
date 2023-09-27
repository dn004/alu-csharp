using System;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();
        HashSet<int> HashList1 = new HashSet<int>(list1){};
        HashSet<int> HastList2 = new HashSet<int>(list2){};
        int num;
        bool checkHash = HashList2.Contains(num);
        foreach(num in HashList1){
                if (checkHash = false){
                    newList.Add(num);
                    }
        }
        newList.Sort();
        return newList;
    }
}