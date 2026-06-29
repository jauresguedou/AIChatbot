using System;


public class Warrior: Character
{


   
    public Warrior(string name): base (name,200)
    {
        
        
    }

    public override void Attack()
    {

        Console.WriteLine($"{GetName()} points his sword at the enemy");
       
    }
}