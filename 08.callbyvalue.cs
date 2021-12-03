/*
 C# Call By Value

In C#, value-type parameters are that pass a copy of original value to the function rather than reference.
It does not modify the original value.
A change made in passed value does not alter the actual value.
In the following example, we have pass value during function call.
*/

using System;
namespace CallByValue
{
    class Program
    {
        void func(int value)
        {
            value = value * value;
            Console.WriteLine("value inside the function"+ value);
        }

        static void Main(string[] args)
        {
            int value = 11;
            Program P = new Program();
            Console.WriteLine("Value before calling the function " + value);
            P.func(value);
            Console.WriteLine("Value after calling the function " + value);
        }
    }
}