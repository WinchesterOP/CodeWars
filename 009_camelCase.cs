
/**
* https://www.codewars.com/kata/5208f99aee097e6552000148/train/csharp
* 
* Complete the solution so that the function will break up camel casing, using a space between words.
* 
* Example
* solution("camelCasing")  ==  "camel Casing"
* 
*/


using System;
using System.Collections.Generic;

public static class Kata
{
    public static string BreakCamelCase(string str)
    {
        List<string> result = new List<string>();

        for (int i = 0; i < str.Length; i++)
        {
            if (Char.IsUpper(str[i]))
            {
                result.Add(" " + str[i].ToString());
            } else
            {
                result.Add(str[i].ToString());
            }
        }

        return String.Join("",result);
    }
}