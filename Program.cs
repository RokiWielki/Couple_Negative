//Napisz program, który dla podanej przez użytkownika liczby całkowitej sprawdza, czy
//jest parzysta oraz czy jest ujemna. 

using System;

namespace Couple_Negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Your number is: "+Couple(a));
            Console.WriteLine("Your number is: "+Negative(a));
        }
        static string Couple(int a)
        {
            if (a == 0)
            {
                return "Zero";
            }
            else if (a % 2 == 0)
            {
                return "Couple";
            }
            else
            {
                return "Odd";
            }
        }
        static string Negative(int a)
        {
            if (a == 0)
            {
                return "Zero";
            }
            else if (a > 0)
            {
                return "Positive";
            }
            else
            {
                return "Negative";
            }
        }
    }
}
