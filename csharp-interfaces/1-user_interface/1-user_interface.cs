using System;

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


    public interface IInteractive
    {
        public void Interact();
    }

    public interface IBreakable
    {
        public int durability{ get ; set;}
        public void Break();
    }

    public interface ICollectable
    {
        public bool isCollected{ get ; set;}
        public void Collect();
    }
}

class TestObject : Base, Base.IInteractive, Base.IBreakable, Base.ICollectable
{

    public int durability{ get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool isCollected{ get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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