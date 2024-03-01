using System;

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