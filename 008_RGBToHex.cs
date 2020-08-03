/**
* URL: https://www.codewars.com/kata/513e08acc600c94f01000001/train/csharp
* 
* The rgb function is incomplete. Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned. Valid decimal values for RGB are 0 - 255. Any values that fall out of that range must be rounded to the closest valid value.
* 
* Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.
* 
* The following are examples of expected output values:
* 
* Rgb(255, 255, 255) # returns FFFFFF
* Rgb(255, 255, 300) # returns FFFFFF
* Rgb(0,0,0) # returns 000000
* Rgb(148, 0, 211) # returns 9400D3
* 
*/

using System;

public static class Kata
{
    public static string Rgb(int r, int g, int b)
    {
        return DecToHexConverter(r) + DecToHexConverter(g) + DecToHexConverter(b);
    }

    private static string DecToHexConverter(int dec)
    {
        int tempdec = 0;

        if (dec < 0)
        {
            tempdec = 0;
        } else if (dec > 255)
        {
            tempdec = 255;
        } else
        {
            tempdec = dec;
        }

        string result = tempdec.ToString("X");

        if ( result.Length <= 1 )
        {
            return "0" + result;
        } else
        {
            return result;
        }
    }
}