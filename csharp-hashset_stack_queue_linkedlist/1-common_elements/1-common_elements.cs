using System;

class List{
    public static List<int> CommonElements(List<int> list1, List<int> list2){
        List<int> newList = new List<int>();
        HashSet<int> HashList1 = new HashSet<int>(list1);
        HashSet<int> HastList2 = new HashSet<int>(list2);

        HashList1.IntersectWith(HastList2);
        
        foreach(int num in HashList1)
            {
                    newList.Add(num);
            }
            newList.Sort();
            return newList;
        }
    }