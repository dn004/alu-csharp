using System;

/// <summary>
/// Represents a generic queue.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Represents a node in the queue.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Gets or sets the value of the node.
        /// </summary>
        public T Value { get; }

        /// <summary>
        /// Gets or sets the reference to the next node.
        /// </summary>
        public Node? Next { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class with the specified value.
        /// </summary>
        /// <param name="value">The value of the node.</param>
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    private Node? Head { get; set; }
    private Node? Tail { get; set; }
    private int Count { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Queue{T}"/> class.
    /// </summary>
    public Queue()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    /// <summary>
    /// Adds a new node with the specified value to the end of the queue.
    /// </summary>
    /// <param name="value">The value of the new node.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail!.Next = newNode;
            Tail = newNode;
        }
        Count++;
    }

    /// <summary>
    /// Removes and returns the value of the first node in the queue.
    /// </summary>
    /// <returns>The value of the first node in the queue.</returns>
    public T Dequeue()
    {
        if (Head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T)!; // Return default value if queue is empty
        }

        T value = Head.Value;
        Head = Head.Next;
        Count--;
        return value;
    }

    /// <summary>
    /// Returns the value of the first node in the queue without removing it.
    /// </summary>
    /// <returns>The value of the first node in the queue.</returns>
    public T Peek()
    {
        if (Head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T)!; // Return default value if queue is empty
        }

        return Head.Value;
    }

    /// <summary>
    /// Gets the number of nodes in the queue.
    /// </summary>
    /// <returns>The number of nodes in the queue.</returns>
    public int CountNodes()
    {
        return Count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Queue<int> myIntQ = new Queue<int>();

        myIntQ.Enqueue(100);
        myIntQ.Enqueue(101);
        myIntQ.Enqueue(102);

        Console.WriteLine("First value: " + myIntQ.Peek());
        Console.WriteLine("Number of nodes in queue: " + myIntQ.CountNodes());

        Console.WriteLine("----------");

        Queue<char> myCharQ = new Queue<char>();
        Console.WriteLine("First value: " + myCharQ.Peek());
    }
}
