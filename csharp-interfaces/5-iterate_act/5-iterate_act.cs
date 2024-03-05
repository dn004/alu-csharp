using System;
using System.Collections.Generic;


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
/// Represents a utility class for iterating actions on room objects.
/// </summary>
public class RoomObjects
{
    /// <summary>
    /// Iterates actions based on the type of room objects.
    /// </summary>
    public static void IterateAction(List<Base> roomObjects, Type? type)
    {
        foreach(var temp in roomObjects)
        {
            if(typeof(Door).GetInterfaces().Contains(type))
            {
                IInteractive? current = temp as IInteractive;
                current?.Interact();
            }
            else if(typeof(Decoration).GetInterfaces().Contains(type))
            {
                IBreakable? current = temp as IBreakable;
                current?.Break();
            }

            if(typeof(Key).GetInterfaces().Contains(type))
            {
                ICollectable? current = temp as ICollectable;
                current?.Collect();
            }
        }
    }
}




/*
class Program
{
    static void Main(string[] args)
    {
        Door frontDoor = new Door("Front Door");
        Decoration photo = new Decoration("Awkward Family Portrait");
        Decoration antiqueVase = new Decoration("Antique Vase", 2, true);
        Key carKey = new Key("Car Key");

        List<Base> allObjects = new List<Base>();

        allObjects.Add(frontDoor);
        allObjects.Add(photo);
        allObjects.Add(antiqueVase);
        allObjects.Add(carKey);

        RoomObjects.IterateAction(allObjects, typeof(IInteractive));
        RoomObjects.IterateAction(allObjects, typeof(IBreakable));
        RoomObjects.IterateAction(allObjects, typeof(ICollectable));
    }
}

*/