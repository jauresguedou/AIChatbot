using System;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Security.Principal;
using Google.GenAI.Types;



public class Game
{
    private  Player _currentPlayer;

    private Enemy _currentEnemy;

    private int _roundNumber;

    private bool _isGameOver;
   

    public Player GetPlayerName()
    {
        return _currentPlayer;
    }
    
    public Enemy GetEnemy()
    {
        return _currentEnemy;
    }


    public int GetRoundNumber()
    {
        return _roundNumber;
    }
    public void ShowSpinner( int delay)
    {
       string [] Spinner = {"/","|" , "-","\\"};

       foreach(string symbol in Spinner)
        {
            Console.Write($"{symbol}");
            Thread.Sleep(delay);
            Console.Write("\b \b ");
        }
        Console.WriteLine("\b \b");
    }

    public void StartGame()
    {
        Console.WriteLine("Welcome to AI Dungeon Explorer ");
        ShowSpinner(2000);
    }

    public void ChooseCharacter()
    {
        Console.WriteLine("Choose a character:");
        Console.WriteLine();
        Console.WriteLine("  1.Warrior");
        Console.WriteLine("  2.Mage");
        Console.WriteLine("  3.Archer");
        string choice = Console.ReadLine() ?? "";

        if(choice == "1")
        {
            Console.Write("What is the name of your warrior?: ");
            string warriorName = Console.ReadLine() ?? "";

            Warrior warrior = new Warrior(warriorName);

        }
        
        else if (choice == "2")
        {
            Console.Write("What is the name of your Mage?: ");

            string mageName = Console.ReadLine() ?? "";

            Mage mage = new Mage(mageName);
        }

        else if (choice == "3")
        {
            Console.Write("What is the name your Archer?: ");
            string archerName = Console.ReadLine() ?? "";

            Archer archer = new Archer(archerName);
        }
       
        else
        {
            Console.WriteLine("This character is not on the list");
        }
    }


    public void Enemy()
    {
        Console.WriteLine("Create your enemy");
        Console.Write("What the name of your enemy?: ");
        string enemyName = Console.ReadLine()?? "";
        
        
    }


    public void Battle()
    {
        
    }
}