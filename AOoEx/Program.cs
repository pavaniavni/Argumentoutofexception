using System;
using System.Collections.Generic;

public class Argumentoutofexception
{
    public static void Main()
    {
        var list = new List<string>();

        try
        {
            Console.WriteLine("The first item: '{0}'", list[0]);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
