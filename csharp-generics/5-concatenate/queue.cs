using System;
using System.Text;

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

    /// <summary>
    /// Prints the queue starting from the head.
    /// </summary>
    public void Print()
    {
        if (Head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node? current = Head;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }

    /// <summary>
    /// Concatenates all values in the queue if it's of type String or Char.
    /// </summary>
    /// <returns>The concatenated string, or null if the queue is empty or not of type String or Char.</returns>
    public string? Concatenate()
    {
        if (Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }

        StringBuilder sb = new StringBuilder();
        Node? current = Head;
        while (current != null)
        {
            sb.Append(current.Value);
            current = current.Next;
        }
        return sb.ToString();
    }
}
