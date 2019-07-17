using System;

namespace Highlow.Models
{
  class Game
  {
    private static int _number;
    private static int _highestLowerLimit = 1;
    private static int _lowestHigherLimit = 101;

    public static int GetNumber()
    {
      return _number;
    }

    public static int GetHighestLowerLimit()
    {
      return _highestLowerLimit;
    }

    public static int GetLowestHigherLimit()
    {
      return _lowestHigherLimit;
    }

    public static void initialGuess()
    {
      Random rand = new Random();
      _number = rand.Next(_highestLowerLimit, _lowestHigherLimit);
    }

    public static void higherGuess(int lowerLimit)
    {
      Random rand = new Random();
      if (lowerLimit > _highestLowerLimit)
      {
        _highestLowerLimit = lowerLimit;
      }
      _number = rand.Next(_highestLowerLimit, _lowestHigherLimit);
    }

    public static void lowerGuess(int higherLimit)
    {
      Random rand = new Random();
      if (higherLimit < _lowestHigherLimit)
      {
        _lowestHigherLimit = higherLimit;
      }
      _number = rand.Next(_highestLowerLimit, _lowestHigherLimit);
    }
  }
}
