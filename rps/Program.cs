using System;
using RockPaperScissors; //import namespace from choice.cs

class Program
{

  public static void Main()
  {
    Console.WriteLine("Welcome to the game of Rock, Paper, Scissors!");
    Console.WriteLine("Player1 enter 'rock', 'paper', or 'scissors'");
    string playerOne = Console.ReadLine().ToLower();
    
    if ( (playerOne == "rock" || playerOne == "paper" || playerOne == "scissors"))
    { 
      Console.WriteLine("Player2 enter 'rock', 'paper', or 'scissors'");
      string playerTwo = Console.ReadLine().ToLower();
      if ( (playerTwo == "rock" || playerTwo == "paper" || playerTwo == "scissors"))
      {
        RPSGame newGame = new RPSGame(playerOne, playerTwo);
        Console.WriteLine($"{newGame.GameOutcome()}");
        Console.WriteLine($"--------------------------------");
      }
      else
      {
        Console.WriteLine("Please only enter your choice from rock , paper or scissors");
        Console.WriteLine($"--------------------------------");
      }
    }
    else 
    {
    Console.WriteLine("Please only enter your choice from rock , paper or scissors");
    Console.WriteLine($"--------------------------------");
    }
  Main();
  }
}  








