/*

namespace DemoStruct
{
    class MyStruct
    {
        public void Display()
        {
            Console.WriteLine("Method in a class");
        }
        static void Main()
        {
            MyStruct m1 = new MyStruct();
            m1.Display();
        
        }
    }
}

*/
/*
namespace DemoStruct
{
    struct MyStruct
    {
        public void Display()
        {
            Console.WriteLine("Method in a structure");
        }
        static void Main()
        {
            MyStruct m1 = new MyStruct();
            m1.Display();

        }
    }
}

*/
/*
namespace DemoStruct
{
    struct MyStruct
    {
        public void Display()
        {
            Console.WriteLine("Method in a structure");
        }
        static void Main()
        {
            MyStruct m1;
            m1.Display();

        }
    }
}

*/

/*
namespace DemoStruct
{
    class MyStruct
    {
        int i;
        public void Display()
        {
            Console.WriteLine("Method in a class " + i);
        }
        static void Main()
        {
            MyStruct m1 = new MyStruct();
            m1.Display();

        }
    }
}
*/

/*
namespace DemoStruct
{
    struct MyStruct
    {
        int i;
        public void Display()
        {
            Console.WriteLine("Method in a structure " + i);
        }
        static void Main()
        {
            MyStruct m1 = new MyStruct();
            m1.Display();

        }
    }
}

*/

/*
namespace DemoStruct
{
    class MyStruct
    {
        int i = 10;
        public void Display()
        {
            Console.WriteLine("Method in a class " + i);
        }
        static void Main()
        {
            MyStruct m1 = new MyStruct();
            m1.Display();

        }
    }
}

*/
/*
namespace DemoStruct
{
    struct MyStruct
    {
        int i;
        public void Display()
        {
            Console.WriteLine("Method in a structure " + i);
        }
        static void Main()
        {
            MyStruct m1 = new MyStruct();
            //m1.i = 10;         //  default constructor is initializing this currently, thts why its not throwing any error
            m1.Display();

        }
    }
}
*/
/*
namespace DemoStruct
{
    struct MyStruct
    {
        int i;
        public void Display()
        {
            Console.WriteLine("Method in a structure " + i);
        }
        static void Main()
        {
            MyStruct m1;
            //m1.i = 10;     //error -  mandatory to initialize like this bcoz we are not using new keyword in above line
            m1.Display();

        }
    }
}

*/

/*

namespace DemoStruct
{
    struct MyStruct
    {
        int i;

        public MyStruct()   // error -- point 6 in theory
        {

        }
        public void Display()
        {
            Console.WriteLine("Method in a structure " + i);
        }
        static void Main()
        {
            MyStruct m1 = new MyStruct();
            m1.i = 10;
            m1.Display();

        }
    }
}

*/

namespace DemoStruct
{
    struct MyStruct
    {
        int i;

        public MyStruct(int i)
        {
            this.i = i;
        }
        public void Display()
        {
            Console.WriteLine("Method in a structure " + i);
        }
        static void Main()
        {
            MyStruct m1 = new MyStruct();
            m1.i = 10;
            m1.Display();
            
            MyStruct m2 = new MyStruct();
            m2.Display();

            MyStruct m3 = new MyStruct();
            m3.Display();
        }
    }
}

