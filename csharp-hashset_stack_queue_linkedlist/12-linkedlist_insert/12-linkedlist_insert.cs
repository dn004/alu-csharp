using System;

class LList
{
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();
        LinkedListNode<int> current;

        myLList.AddLast(1);
        myLList.AddLast(4);
        myLList.AddLast(9);
        myLList.AddLast(16);
        myLList.AddLast(25);
        myLList.AddLast(36);
        myLList.AddLast(49);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }

        Console.WriteLine("------------------");
        LList.Insert(myLList, 21);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {   
        LinkedListNode<int> Noode = new LinkedListNode<int>(n);
        Noode = myLList.First;
        while(Noode != null)
        {
            if(Noode.Value >= n)
            {
                myLList.AddBefore(Noode, n);
                return Noode.Previous;
            }
              Noode = Noode.Next;
        }
           
            return Noode;
    }
}