using System;

class Array{
    public static int[] ReplaceElement(int[] array, int index, int n){

        if (index < 0 ||index > array.Length){
                Console.WriteLine ("Index Out Of Range");
                return array;
            }
            else{
                array[index] = n;
                return array;
                
            }
    }
}