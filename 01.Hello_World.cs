/* in C# we can write hello world program in multiple ways, here is some example 

>> Simple Example

>> using System

>> Using public modifier

>>Using namespace

*/



// C# Simple Example

/*

class Helloworld
{
    static void Main(String[] args)
    {
        System.Console.WriteLine("Hello, World!!" +
                           "\nThis is C#");
    }
}

*/

/*
// using System
using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!!");
        }

    }
*/

/*
//using public modifier

using System;
    public class Program
    {
        public static void Main(string[] args)
        {
        Console.WriteLine("Hello World!!");
        }
    }
*/

//using namespace

using System;

namespace MyNamespace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
        }
    }
}
