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

        Console.WriteLine($" Dog Name: {name}\n Age: {age}\n Owner: {owner}\n Rating: {rating}");
        
    }
}