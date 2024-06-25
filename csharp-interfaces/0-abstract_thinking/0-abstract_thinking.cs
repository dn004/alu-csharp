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
}

/*
class Program
{
    static void Main(string[] args)
    {
        SoftwareEngineer engineer = new SoftwareEngineer();

        engineer.name = "Betty";

        Console.WriteLine(engineer.ToString());
    }
}
class SoftwareEngineer : Base
{
    // Empty class
}
*/