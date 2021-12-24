

/*
// if statement

using System;

class IfExample
{
    static void Main(string[] args)
    {
        int num = 10;

        if (num % 2 == 0)
        {
            Console.WriteLine("This is even number");
        }
    }
}


*/

/*
// if - else statement

using System;
public class IfElse
{
    public static void Main(string[] args)
    {
        int num = 18;

        if (num % 2 == 0)
        {
            Console.WriteLine("This is even number");
        }
        else
        {
            Console.WriteLine("This is odd number");
        }
    }
}

*/


/*
// if - else example with user input

public class IFElse
{
    public static void Main(string[] args)
    {
        Console.WriteLine("please enter a number");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num%2==0)
        {
            Console.WriteLine("Input number is even");
        }
        else
        { 
            Console.WriteLine("Input number is odd");
        }
    }

}

*/

// if - else-if ladder statement

using System;

public class Ladder
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your marks : ");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks > 100 | marks < 0)
        {
            Console.WriteLine("Wrong Input, Please Enter Correctly");
        }

        else if (marks >= 60 & marks < 100)
        {
            Console.WriteLine("Result is : First Division");
        }

        else if (marks < 60 & marks >= 45)
        {
            Console.WriteLine("Result is : Second Division");
        }
        else if (marks < 45 & marks >= 33)
        {
            Console.WriteLine("Result is : Pass");
        }
        else 
        {
            Console.WriteLine("Result is : Fail");
        }
    }
}
