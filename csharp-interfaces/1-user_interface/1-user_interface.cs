using System;
using System.Collections.Generic;
using System.Reflection;


/// <summary>
/// interace for interactions
/// </summary>
public interface IInteractive{

    /// <summary>
    /// interact method
    /// </summary>
    public void Interact();
}


/// <summary>
/// interface for breakables
/// </summary>
public interface IBreakable {

    // durability
    public int durability { get ; set;}

    /// <summary>
    /// breaking stuff
    /// </summary>
    public void Break();
}


/// <summary>
/// collecting stuff
/// </summary>
public interface ICollectable{

    // collecting
    public bool isCollected { get ; set; }
    /// <summary>
    /// for collecting objects.
    /// </summary>
    public void Collect();
}

/// <summary>
/// main class for testing
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable{
    public int durability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool isCollected { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Interact(){

    }

    public void Break(){

    }

    public void Collect(){

    }

}



/// <summary>
/// base class for everythign.
/// </summary>

public abstract class Base{

    public String? name { get ; set; }

    public override String ToString(){
        return $"{name} is a {this.GetType()}";
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