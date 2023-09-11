using System;
using System.Collections.Generic;

class List {
    public static List<int> CreatePrint(int size){
        List<int> myList = new List<int>();

        if (size == 0 || size < 0){
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else{
            for (int i = 0; i = size; i ++){
                myList.Add(i);
                return myList;
            }
        }
    }
}