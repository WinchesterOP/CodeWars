using System.Collections.Generic;

/**
 * https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp
 * 
 * Description:
 *  If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 *
 *  Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.
 *
 *  Note: If the number is a multiple of both 3 and 5, only count it once.
 */

public class Kata
{
    public static int Solution(int value)
    {
        int belowValue = value - 1;
        int amountOfThree = belowValue / 3;
        int amountOfFive = belowValue / 5;

        List<int> allNumbers = new List<int>();

        GetAllNumbers(3, amountOfThree, allNumbers);
        GetAllNumbers(5, amountOfFive, allNumbers);

        return GetResult(allNumbers);
    }

    private static void GetAllNumbers(int multiplier, int howOften, List<int> allNumbers)
    {
        int temp;

        for (int i = 1; i <= howOften; i++)
        {
            temp = multiplier * i;
            if (!allNumbers.Contains(temp))
            {
                allNumbers.Add(temp);
            }
        }
    }

    private static int GetResult(List<int> allNumbers)
    {
        int result = 0;

        for (int i = 0; i < allNumbers.Count ; i++)
        {
            result += allNumbers[i];
        }

        return result;
    }
}

