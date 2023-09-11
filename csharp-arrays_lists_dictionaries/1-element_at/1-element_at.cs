    using System;

    class Array{
        public static int elementAt(int[] array, int index){

            if (index < 0 ||index > array.Length){
                Console.WriteLine ("Index Out Of Range");
                return -1;
            }
            else{
                int element = array[index];
                return element;
                
            }
        }
    }