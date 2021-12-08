/*
 
C# Goto Statement

The C# goto statement is also known jump statement.
It is used to transfer control to the other part of the program.
It unconditionally jumps to the specified label.

It can be used to transfer control from deeply nested loop or switch case label.

Currently, it is avoided to use goto statement in C# because it makes the program complex.

*/
/*
using System;
public class GotoExample
{
    public static void Main(string[] args)
    {
    ineligible:
        Console.WriteLine("You are not eligible to vote!");

        Console.WriteLine("Enter your age:\n");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 18)
        {
            goto ineligible;
        }
        else
        {
            Console.WriteLine("You are eligible to vote!");
        }
    }
}
*/

using System;
public class EE
{
    public static void Main(string[] args)
    {
    l1 : Console.WriteLine("number is less than 10");

    Console.WriteLine("Enter a number");
    int i = Convert.ToInt32(Console.ReadLine());
    if (i < 10)
    {
        goto l1;
    }
    else
    {
        Console.WriteLine("Number is Greater Than 10");
    }

    }
}
