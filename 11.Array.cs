/*
 C# Arrays

Like other programming languages, array in C# is a group of similar types of elements that have contiguous memory location. 
In C#, array is an object of base type System.Array. In C#, array index starts from 0.
We can store only fixed set of elements in C# array.


Advantages of C# Array

    Code Optimization (less code)
    Random Access
    Easy to traverse data
    Easy to manipulate data
    Easy to sort data etc.

Disadvantages of C# Array

    Fixed size



C# Array Types

There are 3 types of arrays in C# programming:

    Single Dimensional Array
    Multidimensional Array
    Jagged Array



C# Single Dimensional Array

To create single dimensional array, you need to use square brackets [] after the type.

    int[] arr = new int[5];//creating array  

You cannot place square brackets after the identifier.

    int arr[] = new int[5];//compile time error  

*/

/*
using System;
public class ArrayExample
{
    public static void Main(string[] args)
    {
        int[] arr = new int[6];

        arr[0] = 11;
        arr[2] = 22;
        arr[4] = 33;
        
        for (int i = 0; i < arr.Length;i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

*/

/*
 C# Array Example: Declaration and Initialization at same time

There are 3 ways to initialize array at the time of declaration.

    int[] arr = new int[5]{ 10, 20, 30, 40, 50 };  

We can omit the size of array.

    int[] arr = new int[]{ 10, 20, 30, 40, 50 };  

We can omit the new operator also.

    int[] arr = { 10, 20, 30, 40, 50 };  

Let's see the example of array where we are declaring and initializing array at the same time.

*/


/*
using System;
public class A
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 5, 6, 7, 8, 00 };

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i])

        }
    }
}

*/


/*
// C# Array Example: Traversal using foreach loop

using System;
class Arr
{
    public static void Main(string[] args)
    {
        int[] arr = { 9, 8, 7, 6, 5, 4 };


        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}

*/


/*
 
C# Passing Array to Function

In C#, to reuse the array logic, we can create function. 
To pass array to function in C#, we need to provide only array name.

    functionname(arrayname);//passing array  

C# Passing Array to Function Example: print array elements
*/

/*
// Let's see an example of C# function which prints the array elements.

using System;
public class ArrFunc
{
    static void func(int[] arr)
    {
        Console.WriteLine("Printing array elements : ");
        for (int i = 0; i< arr.Length; i++)
        {
            Console.WriteLine(arr[i]);  
        }
    }

    static void Main(string[] args)
        {
            int[] array1 = { 11, 22, 33 };
            int[] array2 = { 999, 888, 7777 };

            func(array1);
            func(array2);
        }
    
}

*/


/*
// C# Passing Array to Function Example: Print minimum number

using System;
class ArrMin
{
    static void Min(int[] arr)
    {
        int min = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        Console.WriteLine("minimum number in array is : "+ min);

    }

    static void Main(string[] args)
    {
        int[] arr = { 11, 56, 29, 3333, 090, 100 };

        Min(arr);
    }
}
*/



/*
// C# Passing Array to Function Example: Print maximum number

using System;
class ArrMax
{
    static void Func(int[] arr)
    {
        int max = arr[0];
        for (int i= 0; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
        }
        Console.WriteLine("max of the array is : "+max);
    }
    static void Main(string[] args)
    {
        int[] arr = { 33, 99, 66, 77, 11, 22 };

        Func(arr);
    }
}

*/


/* 
 C# Multidimensional Arrays

The multidimensional array is also known as rectangular arrays in C#. 
It can be two dimensional or three dimensional. The data is stored in tabular form (row * column) which is also known as matrix.

To create multidimensional array, we need to use comma inside the square brackets. For example:

    int[,] arr=new int[3,3];//declaration of 2D array  
    int[,,] arr=new int[3,3,3];//declaration of 3D array  

*/

/*
// C# Multidimensional Array Example

using System;
public class MulDimArr
{
    public static void Main(string[] args)
    {
        int[,] arr = new int[3, 3];

        arr[0, 1] = 10;
        arr[1, 2] = 22;
        arr[2, 0] = 33;


        
        for (int i =0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine("");
        }
    }
}
*/


/* 
 C# Multidimensional Array Example: Declaration and initialization at same time

There are 3 ways to initialize multidimensional array in C# while declaration.

    int[,] arr = new int[3,3]= { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };  

We can omit the array size.

    int[,] arr = new int[,]{ { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };  

We can omit the new operator also.

    int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };  

Let's see a simple example of multidimensional array which initializes array at the time of declaration.

*/

/*
using System;
public class MulArr
{
    public static void Main(string[] args)
    {
        int[,] arr = { { 3, 2, 1 }, { 6, 5, 4 }, { 9, 8, 7 } };

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(arr[i, j] + " ");
            }

            Console.WriteLine("");
        }
    }
}

*/

/*
 C# Jagged Arrays

In C#, jagged array is also known as "array of arrays" because its elements are arrays. 
The element size of jagged array can be different.
Declaration of Jagged array

Let's see an example to declare jagged array that has two elements.

    int[][] arr = new int[2][];  

Initialization of Jagged array

Let's see an example to initialize jagged array. The size of elements can be different.

    arr[0] = new int[4];  
    arr[1] = new int[6];  

Initialization and filling elements in Jagged array

Let's see an example to initialize and fill elements in jagged array.

     arr[0] = new int[4] { 11, 21, 56, 78 };         
    arr[1] = new int[6] { 42, 61, 37, 41, 59, 63 };  

Here, size of elements in jagged array is optional. So, you can write above code as given below:

    arr[0] = new int[] { 11, 21, 56, 78 };         
    arr[1] = new int[] { 42, 61, 37, 41, 59, 63 };  


// C# Jagged Array Example

Let's see a simple example of jagged array in C# which declares, initializes and traverse jagged arrays.
 
 */

/*
using System;
public class JaggedArray
{
    public static void Main(string[] args)
    {
        int[][] arr = new int[2][];

        arr[0] = new int[] { 111, 222, 333, 444 };
        arr[1] = new int[] { 10, 20, 30, 40, 50, 60 };


        for (int i= 0; i<arr.Length;i++)
        {
            for (int j=0; j<arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");

            }
            Console.WriteLine("");
        }
    }
}
*/

/*
 Initialization of Jagged array upon Declaration

Let's see an example to initialize the jagged array while declaration.

    int[][] arr = new int[3][]{  
            new int[] { 11, 21, 56, 78 },  
            new int[] { 2, 5, 6, 7, 98, 5 },  
            new int[] { 2, 5 }  
            };  
*/

// Let's see a simple example of jagged array which initializes the jagged arrays upon declaration.


/*
using System;
public class JaggedArr
{
    public static void Main(string[] args)
    {
        int[][] arr = new int[3][]
        {
            new int[] { 3,4,5,6,7,8,9},
            new int[] {77,88,99},
            new int[] {2,1 }
        };

        for (int i=0; i< arr.Length; i++)
        {
            for (int j=0; j<arr[i].Length; j++)
            {
                Console.Write(arr[i][j]+" ");
            }
            Console.WriteLine("");
        }
    }
}

*/

/*
 C# Params

In C#, params is a keyword which is used to specify a parameter that takes variable number of arguments. 
It is useful when we don't know the number of arguments prior. 
Only one params keyword is allowed and no additional parameter is permitted after params keyword in a function declaration.
*/

/*
using System;
class Program
{
    public void func(params int[] val)
    {
        for (int i =0; i < val.Length; i++)
        {
            Console.WriteLine(val[i]);
        }

    }

    public static void Main(string[] args)
    {
        Program  p = new Program();
        p.func(4, 3, 2, 1, 00, 55, 66, 77, 88, 99, 00);
    }
}

*/

/* C# Params Example 2

In this example, we are using object type params that allow entering any number of inputs of any type.
*/

/*
using System;
class ParM
{
    void func(params object[] items)
    {
        for (int i = 0; i< items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }
    }

    static void Main(string[] args)
    {
        ParM p = new ParM();
        p.func("kamesh", "mishra", 20, 05, 96, "today", "yesterday", "@");
    }
}

*/


