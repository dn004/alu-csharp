using System;





public enum Modifier 
{
    Weak,
    Strong
}

/// <summary>
/// Delegate for calculating a modifier.
/// </summary>
/// <param name="baseValue">The base value.</param>
/// <param name="modifier">The modifier to apply.</param>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

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
            hp -= damage;
            System.Console.WriteLine($"{name} takes {damage} damage!");
        }

        ValidateHP(hp);


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
            hp += heal;
            System.Console.WriteLine($"{name} heals {heal} HP!");
        } 

        ValidateHP(hp);

    }


    /// <summary>
    /// Validates the health points (HP) of the player.
    /// </summary>
    /// <param name="newHp">The new health points to validate.</param>
    public void ValidateHP(float newHp)
    {
        if(newHp < 0)
        {
            hp = 0;
        }
        else if ( newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }



    /// <summary>
    /// Applies a modifier to the base value.
    /// </summary>
    /// <param name="baseValue">The base value.</param>
    /// <param name="modifier">The modifier to apply.</param>
    /// <returns>The modified value.</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if(modifier == Modifier.Weak)
            return baseValue / 2;

        if(modifier == Modifier.Strong)
            return baseValue * 1.5f;

        return baseValue;
    }
}

/// <summary>
/// Represents different modifiers.
/// </summary>
public enum Modifier 
{
    Weak,
    Strong
}

/// <summary>
/// Delegate for calculating a modifier.
/// </summary>
/// <param name="baseValue">The base value.</param>
/// <param name="modifier">The modifier to apply.</param>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

















/*
class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");
        CalculateModifier mod = new CalculateModifier(player.ApplyModifier);

        player.PrintHealth();

        player.TakeDamage(mod(50f, Modifier.Weak));

        player.PrintHealth();

        player.HealDamage(mod(10f, Modifier.Strong));

        player.PrintHealth();
    }
}
*/





