using System;
using System.Reflection;

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
/// Represents a test object that inherits from Base and implements all three interfaces.
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// Gets or sets the durability of the object.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the object has been collected.
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Interacts with the object.
    /// </summary>
    public void Interact()
    {
        // Implement interaction logic
    }

    /// <summary>
    /// Breaks the object.
    /// </summary>
    public void Break()
    {
        // Implement break logic
    }

    /// <summary>
    /// Collects the object.
    /// </summary>
    public void Collect()
    {
        // Implement collect logic
    }
}