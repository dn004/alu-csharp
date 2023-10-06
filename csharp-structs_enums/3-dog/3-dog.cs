using System;

public enum Rating 
{
    Good,
    Great,
    Excellent,
}

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string name, float age, string owner, Rating rating)
    {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }

    public override string ToString()
    {
        return $"Dog Name: {name}\nAge: {age}\nOwner: {owner}\nRating: {rating}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog poppy = new Dog("Poppy", 0.7f, "Kris", Rating.Excellent);

        Console.WriteLine(poppy.ToString());
    }
}