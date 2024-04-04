using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Console_projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  double a = 3.5d;
              double b = 3.5D;
              double c = 3.5;
              Console.WriteLine(a + b + c);*/

            /* string v;
             Console.WriteLine("please inter  your grade");
             v = Console.ReadLine();*/


            Console.WriteLine("Enter your Score:");
            string input = Console.ReadLine();

            
            int Grade = int.Parse(input);
           
            if (Grade >= 90)
            {
                Console.WriteLine("your grade is A");
            }
            else if (Grade >= 80)
            {
                Console.WriteLine("your grade is B");
            }
            else if (Grade >= 70)
            {
                Console.WriteLine("your grade is C");
            }
            else if(Grade >= 60)
            {
                Console.WriteLine("YOUR GRADE IS D");
            }
            else if ((Grade >= 50))
            {
                Console.WriteLine("you are pass in this course ");
            }
            else
            {
                Console.WriteLine("Sorry you are FAILD in this course!!!!");
            }

          /*  switch (v) {
                case "A":
                    Console.WriteLine("YOUR GRADE IS A");
                    break;
                case "B":
                    Console.WriteLine("your grade is B thanks");
                    break;
                default:
                    Console.WriteLine("incorrect input plase try again");
                    break;}*/
           
            Console.ReadKey();
        }
    }
}
/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        string input = Console.ReadLine();

        // Using int.Parse()
        int number = int.Parse(input);
        Console.WriteLine("Number entered: " + number);

        // Using int.TryParse()
        int parsedNumber;
        bool success = int.TryParse(input, out parsedNumber);
        if (success)
        {
            Console.WriteLine("Number entered: " + parsedNumber);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}*/