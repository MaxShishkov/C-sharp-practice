using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movies = new string[6];
            movies[1] = "15";
            movies[2] = "15";
            movies[3] = "12";
            movies[4] = "18";
            movies[5] = "U";

            Console.WriteLine("Welcome to our multiplex");
            Console.WriteLine("We are presently showing:");
            Console.WriteLine("\t1. Rush (15)");
            Console.WriteLine("\t1. How I Live Now (15)");
            Console.WriteLine("\t1. Thor (12)");
            Console.WriteLine("\t1. FIlth (18)");
            Console.WriteLine("\t1. Planes (U)");

            Console.Write("Enter the number of the film you wish to see: ");
            string movieChoice = Console.ReadLine();

            int age;
            do
            {

                try
                {
                    Console.Write("Enter your age: ");
                    age = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                

            } while (age < 0 && age > 100);
            
            

            string accept = "Enjoy the film";
            string denie = "Access denied - you are too young";

            switch(movieChoice)
            {
                case "1":
                    if (age >= 15)
                        Console.WriteLine(accept);
                    else
                        Console.WriteLine(denie);
                    break;

                case "2":
                    if (age >= 15)
                        Console.WriteLine(accept);
                    else
                        Console.WriteLine(denie);
                    break;

                case "3":
                    if (age >= 12)
                        Console.WriteLine(accept);
                    else
                        Console.WriteLine(denie);
                    break;

                case "4":
                    if (age >= 18)
                        Console.WriteLine(accept);
                    else
                        Console.WriteLine(denie);
                    break;

                case "5":
                    if (age >= 4)
                        Console.WriteLine(accept);
                    else
                        Console.WriteLine(denie);
                    break;

                default:
                    Console.WriteLine("Invalide number");
                    break;

            }

            Console.ReadLine();
            Console.ReadLine();
            
        }
    }
}
