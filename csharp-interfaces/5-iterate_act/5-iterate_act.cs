using System;
using System.Collections.Generic;

/// <summary>
/// Represents a base class with a name property.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name of the base entity.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Overrides the ToString() method to return the name and type of the entity.
    /// </summary>
    /// <returns>A string representing the name and type of the entity.</returns>
    public override string ToString()
    {
        return $"{name} is a {GetType().Name}";
    }
}

/// <summary>
/// Represents an interface for interactive objects.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Interacts with the object.
    /// </summary>
    void Interact();
}

/// <summary>
/// Represents an interface for breakable objects.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Gets or sets the durability of the object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Breaks the object.
    /// </summary>
    void Break();
}

/// <summary>
/// Represents an interface for collectable objects.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Gets or sets a value indicating whether the object has been collected.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collects the object.
    /// </summary>
    void Collect();
}

/// <summary>
/// Represents a door entity.
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Door"/> class with the specified name.
    /// </summary>
    /// <param name="name">The name of the door.</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Interacts with the door.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

/// <summary>
/// Represents a class for handling room objects.
/// </summary>
public class RoomObjects
{
    /// <summary>
    /// Iterates through a list of room objects and executes methods based on the specified interface type.
    /// </summary>
    /// <param name="roomObjects">The list of room objects to iterate through.</param>
    /// <param name="type">The type of interface to interact with.</param>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var obj in roomObjects)
        {
            if (type == typeof(IInteractive) && obj is IInteractive)
            {
                ((IInteractive)obj).Interact();
            }
            else if (type == typeof(IBreakable) && obj is IBreakable)
            {
                ((IBreakable)obj).Break();
            }
            else if (type == typeof(ICollectable) && obj is ICollectable)
            {
                ((ICollectable)obj).Collect();
            }
        }
    }
}

/// <summary>
/// Represents a decoration entity.
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Gets or sets the durability of the decoration.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the decoration is a quest item.
    /// </summary>
    public bool isQuestItem { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Decoration"/> class with the specified name, durability, and quest item status.
    /// </summary>
    /// <param name="name">The name of the decoration.</param>
    /// <param name="durability">The durability of the decoration.</param>
    /// <param name="isQuestItem">A value indicating whether the decoration is a quest item.</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        this.name = name;
        this.durability = durability;

        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }

        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interacts with the decoration.
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Breaks the decoration.
    /// </summary>
    public void Break()
    {
        durability--;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

/// <summary>
/// Represents a key entity.
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// Gets or sets a value indicating whether the key has been collected.
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Key"/> class with the specified name and collection status.
    /// </summary>
    /// <param name="name">The name of the key.</param>
    /// <param name="isCollected">A value indicating whether the key has been collected.</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Collects the key.
    /// </summary>
    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}

