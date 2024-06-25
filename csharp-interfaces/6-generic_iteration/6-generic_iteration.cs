﻿using System;
using System.Collections;
using System.Collections.Generic;



/// <summary>
/// interace for interactions
/// </summary>
public interface IInteractive{

    /// <summary>
    /// interact method
    /// </summary>
    public void Interact();
}


/// <summary>
/// interface for breakables
/// </summary>
public interface IBreakable {

    // durability
    public int durability { get ; set;}

    /// <summary>
    /// breaking stuff
    /// </summary>
    public void Break();
}


/// <summary>
/// collecting stuff
/// </summary>
public interface ICollectable{

    // collecting
    public bool isCollected { get ; set; }
    /// <summary>
    /// for collecting objects.
    /// </summary>
    public void Collect();
}

/// <summary>
/// Door class for controlling a door
/// </summary>
public class Door : Base , IInteractive{

    public Door(string value = "Door"){
        name = value;
    }

    public void Interact(){
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}


/// <summary>
///  decoration class defination
/// </summary>
public class Decoration : Base , IInteractive, IBreakable{
    public bool isQuestItem = false;

    public int durability { get ; set; }


    public Decoration(string CName = "Decoration", int durability = 1, bool isQuestItem = false){

        this.isQuestItem = isQuestItem;
        name = CName;
        if(durability <= 0){
            throw new Exception("Durability must be greater than 0");
        }else{
            this.durability = durability;
        }
     
    }


/// <summary>
/// called when interacting with an object
/// </summary>
    public void Interact(){

        if(durability <= 0 ){
            Console.WriteLine($"The {name} has been broken.");
        }else if(isQuestItem){
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }else{
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
     
    }


/// <summary>
/// breaking an object function
/// </summary>
    public void Break(){
        this.durability--;

        if(durability > 0){
            Console.WriteLine($"You hit the {name}. It cracks.");
        }

        if(durability == 0){
            Console.WriteLine($"You smash the {name}. What a mess.");
        }

        if(durability < 0){
            Console.WriteLine($"The {name} is already broken.");
        }
    }

}


/// <summary>
/// method for picking up key.
/// </summary>
public class Key : Base , ICollectable {


/// <summary>
/// check collections options.
/// </summary>
    public bool isCollected { set ; get ; }


/// <summary>
/// manages default setup values
/// </summary>
/// <param name="name"></param>
/// <param name="isCollected"></param>
    public Key (string name = "Key", bool isCollected = false){
        this.name = name;
        this.isCollected = isCollected;
    }


/// <summary>
///  manages collections states
/// </summary>
    public void Collect(){
        if(!isCollected){
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }else{
               Console.WriteLine($"You have already picked up the {name}.");
        }

    }


}


/// <summary>
/// generic template for IEnumerable
/// </summary>
/// <typeparam name="T"></typeparam>
public class Objs<T> : IEnumerable<T>{

    private readonly List<T> items = new List<T>();


    public void Add(T item){
        items.Add(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
       // throw new NotImplementedException();\
       foreach(var item in items){
         yield return item;
       }
        
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}



/// <summary>
/// base class for everythign.
/// </summary>
public abstract class Base{

    public string? name { get ; set; }

    public override String ToString(){
        return $"{name} is a {this.GetType()}";
    }
}





/*
class Program
{
    static void Main(string[] args)
    {
        Door sideDoor = new Door("Side Door");
        Decoration photo = new Decoration("Awkward Family Portrait");
        Decoration antiqueVase = new Decoration("Antique Vase", 5, true);

        Objs<Decoration> decorations = new Objs<Decoration>();

        decorations.Add(photo);
        decorations.Add(antiqueVase);

        foreach (Decoration deco in decorations)
        {
            Console.WriteLine(deco);
            while (deco.durability > 0)
                deco.Break();
        }

        Console.WriteLine("------------");

        Objs<IInteractive> interactables = new Objs<IInteractive>();

        interactables.Add(sideDoor);
        interactables.Add(photo);
        interactables.Add(antiqueVase);

        foreach (IInteractive obj in interactables)
        {
            Console.WriteLine(obj);
            obj.Interact();
        }
    }
}
*/