using System;
using System.Threading;
using System.Collections.Generic;
using OpenAI;
using OpenAI.Chat;
using Microsoft.Extensions.Configuration;
using Google.GenAI;
using System.Security.Cryptography;


var configuration = new ConfigurationBuilder()
   .AddUserSecrets<Program>()
   .Build();




string apiKey = configuration ["Gemini:ApiKey"] ?? "";
var client = new Client(apiKey:apiKey);


var response = await client.Models.GenerateContentAsync(
    model:"gemini-2.5-flash",
    contents : "hello man"
);

var text = response?.Candidates?[0]?.Content?.Parts?[0]?.Text;
Console.WriteLine(text??"No response from AI");


Console.WriteLine("Welcome to my  AIChatbot");
string [] spinner = {"|","/","-","\\"};


List<string> chatHistory = new List<string>();



void ShowSpinner(int delay)
{
    foreach (string  symbol in spinner)
    {
        Console.Write($"{symbol}");
        Thread.Sleep(delay);
        Console.Write("\b \b");
    }
    Console.Write("\b \b");

}


while(true)
{
    Console.Write("You:");
    

    string userMessage = ( Console.ReadLine() ??"").ToLower().Trim();


    


    if (userMessage == "bye")
    {
        
        ShowSpinner(500);
        Console.Write("Bot: Goodbye");
        break;
    }
    chatHistory.Add("user: " +  userMessage);

    string  prompt = string.Join("\n", chatHistory.ToArray() );

    var geminiResponse = await client.Models.GenerateContentAsync(
    model: "gemini-2.5-flash",
    contents: prompt
   );

   var geminiText = 
            geminiResponse?.Candidates?[0]?.Content?.Parts?[0]?.Text;

    chatHistory.Add("AI:" + (geminiText ??""));
    Console.WriteLine($"Bot: {geminiText?? "No response"}");

   

    
    
}