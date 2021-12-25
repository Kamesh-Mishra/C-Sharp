/*
 C# Out Parameter

C# provides out keyword to pass arguments as out-type. 
It is like reference-type, except that it does not require variable to initialize before passing. 
We must use out keyword to pass argument as out-type. It is useful when we want a function to return multiple values. 
*/


/*
using System;
namespace OutParameter
{
    public class OutP
    {
        void func(out int value)
        {
            int k = 5;
            value = k;
            value = value * value;

        }

        static void Main(string[] args)
        {
            int value = 10;
            OutP rfr = new OutP();
            Console.Write("value before calling the function "+value);
            rfr.func(out value);
            Console.WriteLine("\nvalue after calling the function " + value);

        }
    }
}


*/



// The following example demonstrates that how a function can return multiple values.

using System;
namespace OutP
{
    class OutExp
    {
        void func(out int a, out int b)
        {
            int value = 55;
            a = value;
            b = value;

            a *= a; b *= b;

        }

        static void Main(string[] args)
        {
            int value1 = 10, value2 = 20;
            OutExp cls = new OutExp();
            Console.WriteLine("Value before function call \nvalue1 = " + value1 + "\nValue2 = " + value2);
            cls.func(out value1, out value2);
            Console.WriteLine("Value after function call \nvalue1 = " + value1 + "\nvalue2 = " + value2);


        }
    }
}