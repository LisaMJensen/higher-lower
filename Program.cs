using System;
using Highlow.Models;

namespace Highlow
{
  class Program
  {
    private static string answer;

    static void makeGuesses()
    {
      Console.WriteLine("Is your number higher or lower than " + Game.GetNumber() + "? (Higher/Lower/Correct)");
      answer = Console.ReadLine();

      if (answer == "correct" || answer == "Correct" || answer == "c")
      {
        Console.WriteLine("Great! Thanks for playing!");
      }
      else if (answer == "Higher" || answer == "higher" || answer == "h")
      {
        Game.higherGuess(Game.GetNumber());
        makeGuesses();
      }
      else if (answer == "Lower" || answer == "lower" || answer == "l")
      {
        Game.lowerGuess(Game.GetNumber());
        makeGuesses();
      }
      else
      {
        Console.WriteLine("Please enter a valid response.");
        makeGuesses();
      }
    }

    static void userGuesses()
    {
      int intAnswer = int.Parse(Console.ReadLine());
      if (intAnswer == Game.GetNumber())
      {
        Console.WriteLine("That is correct! Thanks for playing the game.");
      }
      else if (intAnswer < Game.GetNumber())
      {
        Console.WriteLine("You need to go higher.");
        userGuesses();
      }
      else if (intAnswer > Game.GetNumber())
      {
        Console.WriteLine("You need to go lower.");
        userGuesses();
      }
    }

    static void Main()
    {
      Console.WriteLine("Let's play a number guessing game. Would you like to pick a number (Option 1), or should I pick a number for you to guess (Option 2)?");
      answer = Console.ReadLine();

      if (answer == "1" || answer == "option 1" || answer == "Option 1")
      {
        Console.WriteLine("Okay. Pick a number between 1 and 100. Hit 'Y' when you are ready.");
        answer = Console.ReadLine();
        if (answer == "y" || answer == "Y")
        {
          Game.initialGuess();
          makeGuesses();
        }
      }

      if (answer == "2" || answer == "option 2" || answer == "Option 2")
      {
        Game.initialGuess();
        Console.WriteLine("Okay. I have chosen a number between 1 and 100. Tell me your guess.");
        userGuesses();
      }
    }
  }
}
