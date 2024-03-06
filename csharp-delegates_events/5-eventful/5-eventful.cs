using System;

/// <summary>
/// Represents a player entity with health points.
/// </summary>
public class Player
{
    private string? name;
    private float maxHp;
    private float hp;

    EventHandler<CurrentHPArgs> HPCheck;

    private string status;

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

        status = $"{name} is ready to go!";
        HPCheck = CheckStatus;
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

        OnCheckStatus(new CurrentHPArgs(hp));
    }



    /// <summary>
    /// Applies a modifier to the base value.
    /// </summary>
    /// <param name="baseValue">The base value.</param>
    /// <param name="modifier">The modifier to apply.</param>
    /// <returns>The modified value.</returns>
    public float ApplyModifier(float baseValue, Modifier modifier){

        if(modifier == Modifier.Weak)
        {
            return baseValue/2;
        } 
        
        if(modifier == Modifier.Base)
        {
            return baseValue;
        }
        
        if(modifier == Modifier.Strong)
        {
            return baseValue * 1.5f;
        }

        return default(float);
    }



    // <summary>
    /// Checks the status based on current health points (HP) data.
    /// </summary>
    /// <param name="Sender">The object that triggered the event.</param>
    /// <param name="e">The event data containing the current HP.</param>
    private void CheckStatus(object? Sender, CurrentHPArgs e)
    {
        if(e.currentHp == maxHp)
        {
            Console.WriteLine($"{name} is in perfect health!");
        }

        else if(e.currentHp >= (maxHp * 0.5) && e.currentHp < maxHp)
        {
            Console.WriteLine($"{name} is doing well!");
        }

        else if(e.currentHp >= (maxHp * 0.25) && e.currentHp < maxHp)
        {
             Console.WriteLine($"{name} isn't doing too great...");
        }

        else if(e.currentHp > 0 && e.currentHp <= (0.25 * maxHp))
        {
            Console.WriteLine($"{name} needs help!");
        }

        else if(e.currentHp == 0)
        {
            Console.WriteLine($"{name} is knocked out!");
        }
    }




    /// <summary>
    /// health value warning
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HPValueWarning(object? sender, CurrentHPArgs e){
        if(e.currentHp == 0){
            Console.WriteLine("Health has reached zero!");
        }else{
            Console.WriteLine("Health is low!");
        }
    }

    /// <summary>
    /// check status of health
    /// </summary>
    /// <param name="e"></param>
        public void OnCheckStatus(CurrentHPArgs e){
            if(e.currentHp <= (0.25 * maxHp)){
                HPCheck += HPValueWarning;
            }

            HPCheck.Invoke(this, e);
        }
}

/// <summary>
/// Represents different modifiers.
/// </summary>
public enum Modifier 
{
    Weak,
    Base,
    Strong
}

/// <summary>
/// Delegate for calculating a modifier.
/// </summary>
/// <param name="baseValue">The base value.</param>
/// <param name="modifier">The modifier to apply.</param>
public delegate float CalculateModifier(float baseValue, Modifier modifier);


/// <summary>
/// Represents current health points (HP) data. 
/// </summary>
public class CurrentHPArgs : EventArgs{
    
    public float currentHp;

    public CurrentHPArgs(float newHp){
        currentHp = newHp;
    }
}




/*
class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");
        CalculateModifier mod = new CalculateModifier(player.ApplyModifier);

        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(75f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.HealDamage(mod(25f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(50f, Modifier.Base));
        player.PrintHealth();
    }
}

*/