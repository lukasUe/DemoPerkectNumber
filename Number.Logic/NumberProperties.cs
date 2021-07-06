using System;

namespace Number.Logic
{
  public static class NumberProperties
  {
    public static bool IsPerfect(long number)
    {
      long sum = 1;

      for (int i = 2; i < number / 2; i++)
      {
        if (number % i == 0)
        {
          sum += i;
        }
      }

      return sum == number;
    }

    public static bool IsPrime(long number)
    {
      bool valid = false;

      for (int i = 3; i < number / 2; i++)
      {

        if (number == 2)
        {
          valid = true;
        }
        else if (number % 2 != 0)
        {
          valid = true;
        }
        else
        {
          valid = false;
        }
      }

      return valid;
    }
  }
}
