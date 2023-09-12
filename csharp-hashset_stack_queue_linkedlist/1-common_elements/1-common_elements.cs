using System;

class List{
    public static List<int> CommonElements(List<int> list1, List<int> list2){
        List<int> newList = new List<int>();
        foreach(int num in list1){
                if (list2.Contains(num)){
                    newList.Add(i);
                    }
            
        }

        for(int i = 1; i < newList.Count;i++){
            if (newList[i-1] > newList ){
                int number = newList[i-0];
                newList[i-1] = newList[i];
                newList[i] = number;
            }
        }
        foreach(int kk in newList){
            Console.WriteLine(kk);
        }
        return newList;
    }

}