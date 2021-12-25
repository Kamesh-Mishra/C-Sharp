/*
 C# Function

Function is a block of code that has a signature. Function is used to execute statements specified in the code block. 
A function consists of the following components:

Function name: It is a unique name that is used to make Function call.

Return type: It is used to specify the data type of function return value.

Body: It is a block that contains executable statements. 

Access specifier: It is used to specify function accessibility in the application.

Parameters: It is a list of arguments that we can pass to the function during call.
C# Function Syntax

    <access-specifier><return-type>FunctionName(<parameters>)  
    {  
    // function body  
    // return statement  
    }  

Access-specifier, parameters and return statement are optional.
*/





/*
// C# Function: using no parameter and return type

using System;
namespace MyFunction
{
    class Program
    {
        public void func()
        {
            Console.WriteLine("This is user defined function without any parameter");

        }

        static void Main(string[] args)
        {
            Program P = new Program();
            P.func();
        }
    }
}

*/

/*
// C# Function: using parameter but no return type

using System;
namespace Myfunction
{
    class Program
    {
        public void func(string parm)
        {
            Console.WriteLine("this is "+parm+" Programming language");
        }

        static void Main(string[] args)
        {
            Program P = new Program();
            P.func("C-Sharp");
        }
    }
}


*/


/*

//  C# Function: using parameter and return type


using System;
namespace MyFunc
{
    class Program
    {
        public string func(string msg)
        {
            Console.WriteLine("Inside the function");
            return msg;
        }

        static void Main(string[] args)
        {
            Program P = new Program();
            // Console.Write(P.func("Kamesh"));        // print function return
            string message = P.func("Kamesh");
            Console.WriteLine("Hello "+message);
        }
    }
}

*/