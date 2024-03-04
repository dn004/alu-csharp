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
    /// <param name="element">The element to be added to the queue.</param>
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
}


/*
class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();

        myStrQ.Enqueue("Hello");
        Console.WriteLine("Number of nodes in queue: " + myStrQ.Count());

        myStrQ.Enqueue("World");
        Console.WriteLine("Number of nodes in queue: " + myStrQ.Count());

        Console.WriteLine("----------");

        Queue<float> myFloatQ = new Queue<float>();

        myFloatQ.Enqueue(4.2f);
        myFloatQ.Enqueue(4.2f);
        myFloatQ.Enqueue(4.2f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        myFloatQ.Enqueue(-9.8f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());
    }
}
*/