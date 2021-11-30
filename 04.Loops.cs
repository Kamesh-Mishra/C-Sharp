// for loop

/*
 Syntax:

    for(initialization; condition; incr/decr)
    {  
    //code to be executed  
    } 
*/

/*
using System;
public class ForLoop
{
    public static void Main(string[] args)
    {
        for (int i =0; i < 10; i++)
        {
            Console.WriteLine(i);   
        }
    }
}
*/

/*
using System;

class Program
{
    public static void Main()
    {
        string input = "C-Sharp is a object oriented programming language.";
        int spaces = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ')
            {
                spaces++;
            }
        }
        Console.WriteLine("SPACES: " + spaces);
    }
}

*/



/*
// Nested for loop
using System;
    public class NestedFor
        {
            public static void Main(string[] args)
            {
                for (int i = 1; i <=6; i++)
                {
                    for (int j =1; j<=6; j++)
                    {
                        Console.WriteLine(i+" "+j);
                    }
                }
            }
        }

*/


/*
// Infinite For Loop
using System;
public class InfiniteForLoop
{
    public static void Main()
    {
        for (; ;)
        {
            Console.WriteLine("Infinite For Loop");
        }
    }
}
*/









//***************************************************
//***************************************************



// While Loop
/*
Syntax:

while (condition)
{
    //code to be executed  
}
*/

/*
using System;
public class WhileLoop
{
    public static void Main(string[] args)
    {
        int i = 1;
        while(i <= 10)
        {
            Console.WriteLine(i);
            i++;

        }
    }
}
*/


/*
// Nested While Loop
using System;
public class NestedWhile
{
    public static void Main(string[] args)
    {
        int i = 1;
        while(i<=6)
        {
            int j = 1;
            while (j<=6)
            {
                Console.WriteLine(i + " " + j);
                j++;
            }
            i++;

        }
    }
}
*/

/*
// Infinitive While Loop
using System;
public class InfiniteWhileLoop
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Infinite While Loop");

        }
    }
}
*/




//*********************************************
//*********************************************



/* 


C# Do-While Loop

The C# do-while loop is used to iterate a part of the program several times.
If the number of iteration is not fixed and you must have to execute the loop at least once,
it is recommended to use do-while loop.

The C# do-while loop is executed at least once because condition is checked after loop body.



Syntax:

    do{  
    //code to be executed  
    }while(condition);  
*/

/*
using System;

public class DoWhile
{
    public static void Main(string[] args)
    {
        int i = 1;
        do
        {
            Console.WriteLine(i * i);
            i++;
        }
        while (i <= 10);
    }
}
*/


/*
// Nested do-while Loop

using System;
public class NestedDoWhile
{
    public static void Main(string[] args)
    {
        int i = 1;
        do
        {
            int j = 1;
            do
            {
                Console.WriteLine(i + " " + j);
                j++;

            }
            while (j <= 6);
            i++;
        }
        while (i <= 6);
    }
}

*/



/*
// Infinitive do-while Loop

using System;
public class InfiniteDoWhile
{
    public static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Infinitive do-while Loop");
        }
        while (true);
    }
}
*/