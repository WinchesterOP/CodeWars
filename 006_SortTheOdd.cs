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
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int[] SortArray(int[] array)
  {
    int inputLength = array.Length;
    int[] resultArray = new int[inputLength];
    List<int> indexOfTheOdd = new List<int>();
    List<int> tempforTheOdd = new List<int>();

    if(inputLength == 0)
    {
        return array;
    }

    for (int i = 0; i < inputLength; i++)
    {
        if(array[i] % 2 != 0)
        {
            indexOfTheOdd.Add(i);
            tempforTheOdd.Add(array[i]);
        }
    }

    if (!indexOfTheOdd.Any())
    {
        return array;
    }

    tempforTheOdd.Sort();

    for (int i = 0; i < inputLength; i++)
    {
        if (indexOfTheOdd.Any())
        {
            if (indexOfTheOdd.First() == i)
            {
                resultArray[i] = tempforTheOdd.First();
                tempforTheOdd.RemoveAt(0);
                indexOfTheOdd.RemoveAt(0);
            } else
            {
                resultArray[i] = array[i];
            }

        } else
        {
            resultArray[i] = array[i];
        }
        
    }

    return resultArray;
  }
}