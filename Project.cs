using System;

class Highlow
{
  public static int number;

  public static void initialGuess()
  {
    Random rand = new Random();
    number = rand.Next(1, 101);
  }

  public static void higherGuess(int lowerLimit)
  {
    Random rand = new Random();
    number = rand.Next(lowerLimit, 101);
  }

  public static void lowerGuess(int higherLimit)
  {
    Random rand = new Random();
    number = rand.Next(1, higherLimit);
  }
}

class Program
{
  public static string answer;

  public static void makeGuesses()
  {
    Console.WriteLine("Is your number higher or lower than " + Highlow.number + "? (Higher/Lower/Correct)");
    answer = Console.ReadLine();

    if (answer == "correct" || answer == "Correct")
    {
      Console.WriteLine("Great! Thanks for playing!");
    }
    else if (answer == "Higher" || answer == "higher")
    {
      Highlow.higherGuess(Highlow.number);
      makeGuesses();
    }
    else if (answer == "Lower" || answer == "lower")
    {
      Highlow.lowerGuess(Highlow.number);
      makeGuesses();
    }
    else
    {
      Console.WriteLine("Please enter a valid response. (Higher/Lower/Correct)");
    }
  }

  static void Main()
  {
    Console.WriteLine("Would you like to play? Y or N");
    answer = Console.ReadLine();

    if (answer == "y" || answer == "Y")
    {
      Console.WriteLine("Choose a number between 1 and 100!");
      Highlow.initialGuess();
      makeGuesses();
    }
  }
}
