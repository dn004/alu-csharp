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
/// Represents a decoration object that can be interacted with and potentially broken.
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Indicates whether the decoration item is a quest item.
    /// </summary>
    public bool isQuestItem;

    /// <summary>
    /// The durability of the decoration item.
    /// </summary>
    public int durability{ get ; set; }

    /// <summary>
    /// Creates a new decoration item with the specified parameters.
    /// </summary>
    public Decoration(string CName = "Decoration", int durability = 1, bool isQuestItem = false)
    {

        this.isQuestItem = isQuestItem;
        name = CName;
        if(durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        else
        {
            this.durability = durability;
        }
     
    }

    /// <summary>
    /// Performs an interaction with the decoration item.
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if(isQuestItem == true)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else if (isQuestItem == false)
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }

    }

    /// <summary>
    /// Simulates breaking the decoration item.
    /// </summary>
    public void Break()
    {
        this.durability--;

        if(durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }

        if(durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }

        if(durability < 0)
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}


/*
class Program
{
    static void Main(string[] args)
    {
        Decoration coffeeMug = new Decoration("Coffee Mug", 2);

        Console.WriteLine(coffeeMug.ToString());

        coffeeMug.Interact();
        coffeeMug.Break();
        coffeeMug.Break();
        coffeeMug.Interact();
    }
}
*/