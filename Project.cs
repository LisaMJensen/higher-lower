using System;

class Highlow
{
  public static int index;

  public static void Randomize()
  {
    Random rand = new Random();
    index = rand.Next(1, 101);
  }
}

class Program
{
  static void Main()
  {
    Console.WriteLine("Would you like to play? Y or N");
    string answer = Console.ReadLine();

    if (answer == "y" || answer == "Y")
    {
      Console.WriteLine("Choose a number between 1 and 100!");
      Highlow.Randomize();
      Console.WriteLine("Is your number higher or lower than " + Highlow.index + "? (Higher/Lower/Correct)");
    }
  }
}
