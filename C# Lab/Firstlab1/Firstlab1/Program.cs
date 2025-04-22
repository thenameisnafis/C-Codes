using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Firstlab1
{
 
    class Program
    {
        private static int age;

        static void Main(string[] args)
        {
            /* 
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
 
            int a = 1;
            float b = 2;
            string c = "abcd";
            Console.WriteLine("Value of a: " +a);
            Console.WriteLine("Value of b: " +b);
            Console.WriteLine("Value of c: " +c);
            Console.WriteLine("Value of c: " +a+" "+b+" "+c);
            Console.WriteLine("Value of c: {0} {1} {2}",c,b,a ); */

            /*
            string name;
            int age;
            float salary;

            Console.Write("Enter Name:");
            name = Console.ReadLine();
            Console.WriteLine(name);

            Console.Write("Enter Age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine(age);

            Console.Write("Enter Salary:");
            salary = float.Parse(Console.ReadLine());
            Console.WriteLine(salary); */
            /*
            int age;
            Console.Write("Enter Age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine(age);

            if(age>50)
            { Console.WriteLine("Older"); }
            else
            { Console.WriteLine("Younger"); } */

            /*
            int i;
            for (i = 0; i < 5; i++)
            { //Console.WriteLine(i);
            }

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 15);
            */
                int i;
                Console.Write("Enter a Number : ");
                i = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    Console.Write("Entered Number is an Even Number");
                    Console.Read();
                }
                else
                {
                    Console.Write("Entered Number is an Odd Number");
                    Console.Read();
                
                Console.ReadKey();
            }
            }
        }
    }

   




