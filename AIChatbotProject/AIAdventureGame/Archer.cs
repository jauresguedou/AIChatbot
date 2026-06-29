using System;



public class Archer:Character
{
    

    public Archer(string name):base(name,175)
    {
        
    }

    public override void Attack()
    {
        Console.WriteLine($"{GetName()} fires two arrows!");
    }
}