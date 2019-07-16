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

  static void Main()
  {
    Console.WriteLine("Would you like to play? Hit Y when you have chosen a number between 1 and 100");
    answer = Console.ReadLine();

    if (answer == "y" || answer == "Y")
    {
      Highlow.initialGuess();
      makeGuesses();
    }
  }
}
