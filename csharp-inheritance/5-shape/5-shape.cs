using System;

/// <summary>
/// Represents a basic shape.
/// </summary>
public class Shape
{
    /// <summary>
    /// Calculates the area of the shape. This method should be overridden in derived classes.
    /// </summary>
    /// <returns>The calculated area, or an exception if not implemented.</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
