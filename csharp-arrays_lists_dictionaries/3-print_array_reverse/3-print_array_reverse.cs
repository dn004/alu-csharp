using System;

class Array {
    public static void Reverse(int[] array){

        if (array == null || array == {}){
            Console.WriteLine("");
        }
        else{
            for (int i = array.Length; i == 0; i--){
            int arrayValue = array[i]; 
            Console.Write($"{i} ");
        }
        }
    }
}