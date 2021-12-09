
// *******************************************
// *******************************************

// C# Object and Class


/*
Since C# is an object-oriented language, program is designed using objects and classes in C#.
C# Object

In C#, Object is a real world entity, for example, chair, car, pen, mobile, laptop etc.

In other words, object is an entity that has state and behavior. Here, state means data and behavior means functionality.

Object is a runtime entity, it is created at runtime.

Object is an instance of a class. All the members of the class can be accessed through object.

Let's see an example to create object using new keyword.

    Student s1 = new Student();//creating an object of Student    

In this example, Student is the type and s1 is the reference variable that refers to the instance of Student class.
The new keyword allocates memory at runtime.

C# Class

In C#, class is a group of similar objects. It is a template from which objects are created. It can have fields, methods, constructors etc.

Let's see an example of C# class that has two fields only.

    public class Student  
     {  
         int id;//field or data member   
         String name;//field or data member  
     }  

C# Object and Class Example

Let's see an example of class that has two fields: id and name. 
It creates instance of the class, initializes the object and prints the object value.

*/

/*
using System;
public class ExampleClass
{
    int num;
    string name;

    public static void Main(string[] args)
    {
        ExampleClass C = new ExampleClass();
        C.num = 369;
        C.name = "Three Six Nine";
        Console.WriteLine(C.num);
        Console.WriteLine(C.name);

    }
}

*/


// C# Class Example 2: Having Main() in another class

// Let's see another example of class where we are having Main() method in another class. In such case, class must be public.

/*
using System;
public class Class1
{
    public int number;
    public string name;
}

class Class2
{
    public static void Main(string[] args)
    {
        Class1 C1 = new Class1();
        C1.number = 45;
        C1.name = "ABCD";

        Console.WriteLine(C1.number);  
        Console.WriteLine(C1.name);
    }
}

*/

// C# Class Example 3: Initialize and Display data through method

// Let 's see another example of C# class where we are initializing and displaying object through method.

/*
using System;
public class Class1
{
    public int num;
    public string name;

    public void insert(int i, string j)
    {
        num = i;
        name = j;

    }

    public void Display()
    {
        Console.WriteLine(num + " " + name);
    }


}
class Class2
{
    public static void Main(string[] args)
    {
        Class1 c1 = new Class1();
        Class1 c2 = new Class1();

        c1.insert(1, "one");
        c2.insert(2, "two");

        c1.Display();
        c2.Display();
    }
}

*/

// C# Class Example 4: Store and Display Employee Information

/*
using System;
public class Employee
{
    public int id;
    public string name;
    public float salary;

    public void insert(int i, string j, float k)
    {
        id = i;
        name = j;
        salary = k;

    }

    public void display()
    {
        Console.WriteLine(id + " " + name+" "+salary);
    }
}

class TestEmployee
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee();

        e1.insert(999, "ABD", 500000f);
        e2.insert(777, "PQR", 600000f);

        e1.display();
        e2.display();
    }
}
*/


// *********************************************
//**********************************************

/*
 C# Constructor

In C#, constructor is a special method which is invoked automatically at the time of object creation. 
It is used to initialize the data members of new object generally. The constructor in C# has the same name as class or struct.

There can be two types of constructors in C#.

    Default constructor
    Parameterized constructor

C# Default Constructor

A constructor which has no argument is known as default constructor. It is invoked at the time of creating object.
*/

/*
//  C# Default Constructor Example: Having Main() within class


using System;
class C1
{
    C1()
    {
        Console.WriteLine("Default Constructor invoked");

    }

    static void Main(string[] args)
    {
        C1 c = new C1();
        C1 c2 = new C1();   
    }
}
*/


/*
// C# Default Constructor Example: Having Main() in another class

using System;
public class C1
{
    public C1()
        {
            Console.WriteLine("Default Constructor Invoked");
        }
}

class C2
{
    static void Main(string[] args)
    {
        C1 c1 = new C1();
        C1 c2 = new C1();
    }
}
*/


/*
  C# Parameterized Constructor

A constructor which has parameters is called parameterized constructor.
It is used to provide different values to distinct objects.

*/
 