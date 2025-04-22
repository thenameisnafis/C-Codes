using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{

    /* 
    //tasl 01//
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a character: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (ch)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine("It is a vowel.");
                    break;
                default:
                    if (Char.IsLetter(ch))
                        Console.WriteLine("It is a consonant.");
                    else
                        Console.WriteLine("Not a letter.");
                    break;
            }
        }

    */



    /*  
     //tasl 02//
class Program
       {
           static void Main()
           {
               int i = 1, sum = 0;
               while (i <= 50)
               {
                   sum += i;
                   i++;
               }
               Console.WriteLine("Sum of all numbers from 1 to 50 is: " + sum);
           }
       }
   */


    /*
    //tasl 03//
    class Program
       {
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;

        if (num <= 1)
            isPrime = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
            Console.WriteLine(num + " is a prime number.");
        else
            Console.WriteLine(num + " is not a prime number.");
    }
    */

    /*
    //tasl 04//
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
    */


    /*
    //tasl 05//
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[5];
            Console.WriteLine("Enter 5 integers:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers);

            Console.WriteLine("Sorted numbers:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
*/
}

