/*
namespace DemoProject


{
    class TestClass
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hello World");

        }
    }
}
*/

/*
namespace DemoProject
{
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    class TestClass
    {
        static void Main()
        {
            Days d = 0;
            
            Console.WriteLine(d);
        }

    }
}
*/

/*
namespace DemoProject
{
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    class TestClass
    {
        static void Main()
        {
            //Days d = 0;
            Days d = 1;        // error - we can only write for 0 for others not possible
            Console.WriteLine(d);
        }

    }
}
*/
/*
namespace DemoProject
{
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    class TestClass
    {
        static void Main()
        {
            //Days d = 0;
            Days d = (Days) 1;       
            Console.WriteLine(d);
        }

    }
}
*/

/*
namespace DemoProject
{
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    class TestClass
    {
        static void Main()
        {
            //Days d = 0;
            Days d = (Days)3;
            Console.WriteLine(d);
        }

    }
}

*/
/*
namespace DemoProject
{
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    class TestClass
    {
        static void Main()
        {
            //Days d = 0;
            Days d = Days.Wednesday;
            Console.WriteLine(d);
        }

    }
}
*/
/*
namespace DemoProject
{
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    class TestClass
    {
        static void Main()
        {
            //Days d = 0;
            Days d = Days.Wednesday;
            Console.WriteLine((int)d);
        }

    }
}
*/
/*
namespace DemoProject
{
    public enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    class TestClass
    {
        static void Main()
        {
            //Days d = 0;
            Days d = Days.Wednesday;
            Console.WriteLine((int)d);
        }

    }
}
*/
/*
namespace DemoProject
{
    public enum Days
    {
        Monday = 1,
        Tuesday = 11,
        Wednesday = 21,
        Thursday = 31,
        Friday = 41
    }
    class TestClass
    {
        static void Main()
        {
            //Days d = 0;
            Days d = Days.Wednesday;
            Console.WriteLine((int)d);
        }

    }
}
*/
/*
namespace DemoProject
{
    public enum Days
    {
        Monday = 1,
        Tuesday = 11,
        Wednesday = 21,
        Thursday = 31,
        Friday = 41
    }
    class TestClass
    {
        static void Main()
        {
            foreach (int i in Enum.GetValues(typeof(Days))) 
                Console.WriteLine(i+ " : "+(Days)i);
            Console.WriteLine();
            foreach (string s in Enum.GetNames(typeof(Days)))
                Console.WriteLine(s);
        }

    }
}
*/
/*
namespace DemoProject
{
    public enum Days : byte    // default is int but supported options are byte, short,int, long,uint, ushort,ulong,and sbyte
    {
        Monday = 1,
        Tuesday = 11,
        Wednesday = 21,
        Thursday = 31,
        Friday = 41
    }
    class TestClass
    {
        static void Main()
        {
            foreach (int i in Enum.GetValues(typeof(Days)))
                Console.WriteLine(i + " : " + (Days)i);
            Console.WriteLine();
            foreach (string s in Enum.GetNames(typeof(Days)))
                Console.WriteLine(s);
        }

    }
}
*/
/*
namespace DemoProject
{
    public enum Days : byte 
    {
        Monday ,       // not giving value , default is 0
        Tuesday = 11,
        Wednesday = 21,
        Thursday = 31,
        Friday = 41
    }
    class TestClass
    {
        public static  Days MeetingDate
        {
            get; set;
        } = 0;         // only work for 0,, otherwise error
        static void Main()
        {
            Console.WriteLine(MeetingDate);
        }

    }
}
*/
/*
namespace DemoProject
{
    public enum Days : byte
    {
        Monday = 1,
        Tuesday = 11,
        Wednesday = 21,
        Thursday = 31,
        Friday = 41
    }
    class TestClass
    {
        public static Days MeetingDate
        {
            get; set;
        } = (Days)1;         
        static void Main()
        {
            Console.WriteLine(MeetingDate);
        }

    }
}
*/
/*
namespace DemoProject
{
    public enum Days : byte
    {
        Monday = 1,
        Tuesday = 11,
        Wednesday = 21,
        Thursday = 31,
        Friday = 41
    }
    class TestClass
    {
        public static Days MeetingDate
        {
            get; set;
        } = Days.Monday;
        static void Main()
        {
            Console.WriteLine(MeetingDate);
        }

    }
}
*/

namespace DemoProject
{
    public enum Days : byte
    {
        Monday = 1,
        Tuesday = 11,
        Wednesday = 21,
        Thursday = 31,
        Friday = 41
    }
    class TestClass
    {
        public static Days MeetingDate
        {
            get; set;
        } = Days.Monday;
        static void Main()
        {
            Console.WriteLine(MeetingDate);

            Console.WriteLine();

            MeetingDate = Days.Friday;
            Console.WriteLine(MeetingDate);
        }

    }
}