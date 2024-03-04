using System;

/// <summary>
/// Represents a generic queue data structure.
/// </summary>
/// <typeparam name="T">The type of elements stored in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Represents a node in the queue.
    /// </summary>
    private class Node<TNode>
    {
        public TNode Value;
        public Node<TNode> Next;

        /// <summary>
        /// Creates a new instance of Node with the given value.
        /// </summary>
        /// <param name="newValue">The value to be stored in the node.</param>
        public Node(TNode newValue)
        {
            Value = newValue;
            Next = null;
        }
    }

    private Node<T> head;
    private Node<T> tail;
    private int count = 0;

    /// <summary>
    /// Adds an element to the end of the queue.
    /// </summary>
    /// <param name="element">The element to add to the queue.</param>
    public void Enqueue(T element)
    {
        Node<T> newNode = new Node<T>(element);
        
        if (head == null)
            head = tail = newNode;
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
        
        count++;
    }

    /// <summary>
    /// Gets the number of elements in the queue.
    /// </summary>
    /// <returns>The number of elements in the queue.</returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Removes and returns the element at the beginning of the queue.
    /// </summary>
    /// <returns>The element that was removed from the queue, or default value if the queue is empty.</returns>
    public T Dequeue()
    {
        T theValue;

        if (head != null)
        {
            theValue = head.Value;
            head = head.Next;
        }
        else
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return theValue;
    }
}



/*

class Program
{
    static void Main(string[] args)
    {
        Queue<int> myIntQ = new Queue<int>();

        myIntQ.Enqueue(100);
        myIntQ.Enqueue(101);
        Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());

        Console.WriteLine("First value: " + myIntQ.Dequeue());
        Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());

        Console.WriteLine("----------");

        Queue<float> myFloatQ = new Queue<float>();

        myFloatQ.Enqueue(9.8f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        Console.WriteLine("First value: " + myFloatQ.Dequeue());

        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        Console.WriteLine("First value: " + myFloatQ.Dequeue());
    }
}
*/