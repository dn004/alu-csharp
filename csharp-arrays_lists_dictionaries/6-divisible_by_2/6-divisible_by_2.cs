using System;

class List{
    public static List<bool> DivisibleBy2(List<int> myList){
        List<bool> result = new List<bool>();
        for(int i = 0; i < myList.Count; i++){
            if (myList(i) % 2 == 0){
                result(i) = true;
            }
            else {
                result(i) = false;
            }
        }
    return result;
    }
}