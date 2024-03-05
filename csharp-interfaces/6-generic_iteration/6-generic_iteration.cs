using System;
using System.Collections.Generic;
using System.Collections;


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



/// <summary>
/// Door class for controlling a door
/// </summary>
public class Door : Base , IInteractive{

    public Door(string value = "Door"){
        name = value;
    }

    public void Interact(){
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}






/// <summary>
/// Represents a key item that can be collected.
/// </summary>
class Key : Base, ICollectable
{
    /// <summary>
    /// Indicates whether the key has been collected.
    /// </summary>
    public bool isCollected{ get ; set;}
    
    /// <summary>
    /// Collects the key item if it has not already been collected.
    /// </summary>
    public void Collect()
    {
        if(!isCollected)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    } 

    /// <summary>
    /// Creates a new key item with the specified name and collected status.
    /// </summary>
    public Key (string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }
}

/// <summary>
/// Represents a generic collection of objects.
/// </summary>
public class Objs<T> : IEnumerable<T>
{
    private readonly List<T> items = new List<T>();

    /// <summary>
    /// Adds an item to the collection.
    /// </summary>
    /// <param name="item">The item to add.</param>
    public void Add(T item)
    {
        items.Add(item);
    }

    /// <summary>
    /// Returns an enumerator that iterates through the collection.
    /// </summary>
    /// <returns>An enumerator that can be used to iterate through the collection.</returns>
    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in items)
        {
            yield return item;
        }
    }

    /// <summary>
    /// Returns an enumerator that iterates through the collection.
    /// </summary>
    /// <returns>An enumerator that can be used to iterate through the collection.</returns>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}






/*

class Program
{
    static void Main(string[] args)
    {
        Door sideDoor = new Door("Side Door");
        Decoration photo = new Decoration("Awkward Family Portrait");
        Decoration antiqueVase = new Decoration("Antique Vase", 5, true);

        Objs<Decoration> decorations = new Objs<Decoration>();

        decorations.Add(photo);
        decorations.Add(antiqueVase);

        foreach (Decoration deco in decorations)
        {
            Console.WriteLine(deco);
            while (deco.durability > 0)
                deco.Break();
        }

        Console.WriteLine("------------");

        Objs<IInteractive> interactables = new Objs<IInteractive>();

        interactables.Add(sideDoor);
        interactables.Add(photo);
        interactables.Add(antiqueVase);

        foreach (IInteractive obj in interactables)
        {
            Console.WriteLine(obj);
            obj.Interact();
        }
    }
}

*/