using System;


public class Mage: Character
{
    public Mage(string name):base(name,150)
    {
        
    }

    public override void Attack()
    {
        Console.WriteLine($"{GetName()} throws fireball !");
    }
}