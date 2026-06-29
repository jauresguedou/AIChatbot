using System;



public class Enemy:Character
{
    public Enemy(string name, int health):base(name,health)
    {
        
    }


    public override void Attack()
    {
        if (GetName() == "Goblin")
        {
            Console.WriteLine($"{GetName()} attacks with sharp claws!");
        }

        else if(GetName() == "Wolf")
        {
            Console.WriteLine($"{GetName()} attacks with a powerful bite!");
        }

        else if(GetName() == "Dragon")
        {
            Console.WriteLine($"{GetName()} attacks with hot fire!");
        }

        else if(GetName() == "Skeleton")
        {
            Console.WriteLine($"{GetName()} attacks with dark magic!");
        }

        else
        {
            Console.WriteLine($"{GetName()} attacks with unknown weapon !");
        }
    }
}