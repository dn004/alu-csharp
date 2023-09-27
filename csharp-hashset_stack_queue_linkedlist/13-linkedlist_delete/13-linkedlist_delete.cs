using System; 

class LList
{
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