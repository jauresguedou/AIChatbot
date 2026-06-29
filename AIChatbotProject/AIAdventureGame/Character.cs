using System;
using OpenAI.Responses;


public abstract class Character
{
    private string _name;
    private int _health;


    public string GetName()

    {
        return _name;
    }
    
    public int  GetHealth()
    {
        return _health;
    }


    public Character(string name , int health)
    {
        _name = name;
        _health= health;
    }
    
    public void TakeDamage(int damage)
    {
        _health = _health - damage;
    }

    public void Health(int points)
    {
        _health = _health + points;
    }

    public abstract void  Attack ();


}