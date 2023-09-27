using System;

class LList
{
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