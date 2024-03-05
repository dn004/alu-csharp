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


/// <summary>
/// Door class for enganging the door
/// </summary>

class Door : Base, IInteractive
{
    public Door (string intake)
    {
        if(intake != null)
        {
            name = intake;
        }
        else
        {
            name = "Door";
        }
    }
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}


/*
class Program
{
    static void Main(string[] args)
    {
        Door frontDoor = new Door("Front Door");

        Console.WriteLine(frontDoor.ToString());

        frontDoor.Interact();
    }
}
*/