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

/// <summary>
/// Represents a rectangle, a specific type of shape.
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Gets or sets the width of the rectangle.
    /// </summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    /// <summary>
    /// Gets or sets the height of the rectangle.
    /// </summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }

    /// <summary>
    /// Calculates and returns the area of the rectangle.
    /// </summary>
    /// <returns>The calculated area of the rectangle.</returns>
    public override int Area()
    {
        return height * width;
    }

    /// <summary>
    /// Returns a string representation of the rectangle.
    /// </summary>
    /// <returns>A string in the format "[Rectangle] width / height".</returns>
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}
