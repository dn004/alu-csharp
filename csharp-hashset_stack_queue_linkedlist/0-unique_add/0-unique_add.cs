using System;

class List{
    public static int Sum(List<int> myList){
        int dsum = 0;
        foreach(int num in myList){
            for(int i; i < myList; i++){
                if (myList[i] != num){
                    dsum + num;
                }
            }
        }
    return dsum;    
    }
}