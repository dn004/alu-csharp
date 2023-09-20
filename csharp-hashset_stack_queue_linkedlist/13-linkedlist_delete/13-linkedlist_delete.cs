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

        Console.WriteLine("-------------------");
        LList.Delete(myLList, 5);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> Noode = myLList.First;
        int count = -1;
        while(Noode != null)
        {
            count ++;

            if(count == index)
            {
                myLList.Remove(Noode);
            }
              Noode = Noode.Next;
        }
    }
}