using System;

class Highlow
{
  public static int number;
  public static int highestLowerLimit = 1;
  public static int lowestHigherLimit = 101;

  public static void initialGuess()
  {
    Random rand = new Random();
    number = rand.Next(highestLowerLimit, lowestHigherLimit);
  }

  public static void higherGuess(int lowerLimit)
  {
    Random rand = new Random();
    if (lowerLimit > highestLowerLimit)
    {
      highestLowerLimit = lowerLimit;
    }
    number = rand.Next(highestLowerLimit, lowestHigherLimit);
  }

  public static void lowerGuess(int higherLimit)
  {
    Random rand = new Random();
    if (higherLimit < lowestHigherLimit)
    {
      lowestHigherLimit = higherLimit;
    }
    number = rand.Next(highestLowerLimit, lowestHigherLimit);
  }
}

class Program
{
  public static string answer;

  public static void makeGuesses()
  {
    Console.WriteLine("Is your number higher or lower than " + Highlow.number + "? (Higher/Lower/Correct)");
    answer = Console.ReadLine();

    if (answer == "correct" || answer == "Correct" || answer == "c")
    {
      Console.WriteLine("Great! Thanks for playing!");
    }
    else if (answer == "Higher" || answer == "higher" || answer == "h")
    {
      Highlow.higherGuess(Highlow.number);
      makeGuesses();
    }
    else if (answer == "Lower" || answer == "lower" || answer == "l")
    {
      Highlow.lowerGuess(Highlow.number);
      makeGuesses();
    }
    else
    {
      Console.WriteLine("Please enter a valid response.");
      makeGuesses();
    }
  }

  public static void userGuesses()
  {
    int intAnswer = int.Parse(Console.ReadLine());
    if (intAnswer == Highlow.number)
    {
      Console.WriteLine("That is correct! Thanks for playing the game.");
    }
    else if (intAnswer < Highlow.number)
    {
      Console.WriteLine("You need to go higher.");
      userGuesses();
    }
    else if (intAnswer > Highlow.number)
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
        Highlow.initialGuess();
        makeGuesses();
      }
    }

    if (answer == "2" || answer == "option 2" || answer == "Option 2")
    {
      Highlow.initialGuess();
      Console.WriteLine("Okay. I have chosen a number between 1 and 100. Tell me your guess.");
      userGuesses();
    }
  }
}
