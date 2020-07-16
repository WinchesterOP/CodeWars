/**
 * URL: https://www.codewars.com/kata/558fc85d8fd1938afb000014/train/csharp
 * 
 * Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers. 
 * No floats or non-positive integers will be passed.
 * 
 * For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.
 * 
 * [10, 343445353, 3453445, 3453545353453] should return 3453455.
 */

using System;
using System.Linq;

public static class Kata
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{
		int[] _numbers = numbers;

        int lowestNumber;
        int indexTemp;
        int result = 0;

        for (int i = 0; i < 2; i++) 
        {
            lowestNumber = _numbers.Min();
            indexTemp = Array.IndexOf(numbers, lowestNumber);
            _numbers = _numbers.Where((val, idx) => idx != indexTemp).ToArray();
            result += lowestNumber;
        }

        return result;
	}
}