using System;

public class SwitchExample
{
    public static void Main(string[] args)
        {
            Console.Write("Enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
                {
                case 11: Console.WriteLine("It is eleven");
                    break;
                case 22: Console.WriteLine("It is twenty two");
                    break;
                case 33: Console.WriteLine("It is thirty three");
                    break ;
                default: Console.WriteLine("Your Number is " + number);
                    break;
                 }
       }
}