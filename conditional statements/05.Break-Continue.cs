/*

C# Break Statement

The C# break is used to break loop or switch statement. It breaks the current flow of the program at the given condition. In case of inner loop, it breaks only inner loop.

Syntax:

    jump-statement;    
    break;   

*/


/*
using System;
public class BreakStatement
{
    public static void Main(string[] args)
    {
        for (int i = 1; i < 20; i++)
        {
            if (i == 11)
            {
                Console.WriteLine("this is eleven, breakpoint of program!!");
                break;
            }
            Console.WriteLine(i);
        }
        
    }
}

*/


/*
// Break Statement with Inner Loop

using System;
public class BreakInner
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 6; i++)
        {
            for (int j = 1; j <= 6; j++)
            {
                if (j == 6)
                {
                    break;
                    

                }
                Console.WriteLine(i + "" + j);
            }
        }
    }
}

*/

/*
using System;
public class BreakExample
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                if (i == 2 && j == 2)
                {
                    break;
                }
                Console.WriteLine(i + " " + j);
            }
        }
    }
}

*/


//*****************************************
//*****************************************




/*
 
C# Continue Statement

The C# continue statement is used to continue loop.
It continues the current flow of the program and skips the remaining code at specified condition. 
In case of inner loop, it continues only inner loop.

*/

/*
// C# Continue Statement Example

using System;
public class ContinueStatement
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 11; i++)
        {
            if(i==8)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}
*/


/*
// Continue Statement with Inner Loop
using System;
public class InnerContinue
{
    public static void Main(string[] args)
    {
        for(int i =1; i <=6; i++)
        {
            for(int j = 1; j<=6; j++)
            {
                if (i+j == 9)
                {
                    continue;
                }
                Console.WriteLine(i + "" + j);
            }

        }
    }
}
*/