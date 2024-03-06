using System;

/// <summary>
/// Represents a player entity with health points.
/// </summary>
public class Player
{
    private string? name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class with default values.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="maxHp">The maximum health points of the player.</param>
    public Player(string? name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            System.Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }

        this.name = name;
        hp = this.maxHp;
    }

    /// <summary>
    /// Prints the current health of the player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }




    delegate void CalculateHealth(float value);

    /// <summary>
    /// Inflicts damage on the player.
    /// </summary>
    /// <param name="damage">The amount of damage to inflict.</param>
    public void TakeDamage(float damage)
    {
        if(damage < 0)
        {
            System.Console.WriteLine($"{name} takes 0 damage!");
        }
        else
        {
            System.Console.WriteLine($"{name} takes {damage} damage!");
        }
    }

    /// <summary>
    /// Heals the player by a certain amount.
    /// </summary>
    /// <param name="heal">The amount of health to restore.</param>
    public void HealDamage(float heal)
    {
        if(heal < 0)
        {
            System.Console.WriteLine($"{name} heals 0 HP!");
        }
        else
        {
            System.Console.WriteLine($"{name} heals {heal} HP!");
        } 
    }
}
















/*
class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");

        player.TakeDamage(25f);

        player.HealDamage(10f);

        player.TakeDamage(-25f);
    }
}
*/




