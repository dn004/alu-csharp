using System;

/// <summary>
/// queue of type defined
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>  {
    
    public Type CheckType(){
        return typeof(T);
    }

    
}




/*
class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();
        Queue<object> myObjQ = new Queue<object>();

        Console.WriteLine($"{nameof(myStrQ)} Queue Type: " + myStrQ.CheckType());
        Console.WriteLine($"{nameof(myObjQ)} Queue Type: " + myObjQ.CheckType());
    }
}
*/
