/*
 C# Call By Reference

C# provides a ref keyword to pass argument as reference-type.
It passes reference of arguments to the function rather than copy of original value. 
The changes in passed values are permanent and modify the original variable value.
*/

using System;
namespace CallByReference
{
    class Example
    {
        void func(ref int value)
        {
            value *= value;
            Console.WriteLine("value inside the function : "+value);
        }

        static  void Main(string[] args)
        {
            int value = 20;
            Example exp = new Example();
            Console.WriteLine("value before calling function : " + value);
            exp.func(ref value);
            Console.WriteLine("value after calling function : " + value);

        }
    }
}