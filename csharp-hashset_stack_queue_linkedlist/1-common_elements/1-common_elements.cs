using System;

class List{
    public static List<int> CommonElements(List<int> list1, List<int> list2){
        List<int> newList = new List<int>();
        foreach(int num in list1){
                if (list2.Contains(num)){
                    newList.Add(num);
                    }
            
        }

        
        foreach(int kk in newList){
            Console.WriteLine(kk);
        }
        return newList;
    }

}