using System;

public class Player
{
    private string _playerName;
    private Character _character;

    
    public string GetPlayerName()
    {
        return _playerName;
    }

    public Character GetCharacter()
    {
        return _character;
    }
    public Player(string playerName, Character characterName)
    {
        _playerName = playerName;
        _character = characterName;
    }
}