
/**
* https://www.codewars.com/kata/52597aa56021e91c93000cb0/train/csharp
* 
* Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
* 
* Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
* 
*/

using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        List<int> tempArr = arr.ToList();
        int zeroCounter = 0;

        for (int i = tempArr.Count - 1; i >= 0; i--)
        {
            if (tempArr[i] == 0)
            {
                zeroCounter++;
                tempArr.RemoveAt(i);
            }
        }

        for (int i = 0; i < zeroCounter; i++)
        {
            tempArr.Add(0);
        }

        return tempArr.ToArray();
    }
}