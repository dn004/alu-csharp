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