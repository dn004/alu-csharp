using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// Base class representing an object with a name.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// The name of the object.
    /// </summary>
    public string? name;

    /// <summary>
    /// Returns a string representation of the object.
    /// </summary>
    /// <returns>A string representation of the object.</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }



    /// <summary>
    /// Represents an interactive object.
    /// </summary>

    public interface IInteractive
    {
        public void Interact();
    }



    /// <summary>
    /// Represents a breakable object.
    /// </summary>

    public interface IBreakable
    {
        public int durability{ get ; set;}
        public void Break();
    }



    /// <summary>
    /// Represents a collectable object.
    /// </summary>

    public interface ICollectable
    {
        public bool isCollected{ get ; set;}
        public void Collect();
    }
}




/// <summary>
/// Represents a test object that implements interfaces.
/// </summary>

class TestObject : Base, Base.IInteractive, Base.IBreakable, Base.ICollectable
{

    public int durability;
    public bool isCollected;

    public void Interact()
    {
    }

    public void Break()
    {
    }

    public void Collect()
    {
    }
}



/*
class Program
{
    static void Main(string[] args)
    {
        TestObject item = new TestObject();
        Type type = item.GetType();

        Console.WriteLine("Type: " + type);

        Console.WriteLine("Properties:");
        foreach (PropertyInfo info in type.GetProperties())
            Console.WriteLine(info.Name);

        Console.WriteLine("Methods:");
        foreach (MethodInfo info in type.GetMethods())
            Console.WriteLine(info.Name);
    }
}
*/