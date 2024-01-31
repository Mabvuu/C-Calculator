using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int result;

            string answer;


            Console.WriteLine("Hello!, Welcome to my calculator program");
            Console.WriteLine("....");
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Please Enter Your First Number");

            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please Enter Your First Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What Type of Operation would you like to do?");
            Console.WriteLine("Please type a for Addition, s for Subtraction, m for Multiplication, any other key for Division");

            answer = Console.ReadLine();

            if(answer == "a")
            {
                result = num1 + num2;
            }
            else if(answer == "s")
            {
                result = num1 - num2;
            }
            else if( answer == "m")
            {
                result = num1 * num2;
            }
            else  { 
              result = num1 / num2;
            }
            Console.WriteLine("The answer is " + result);
            Console.WriteLine("Thank you for using my calculator! :)");


            Console.ReadKey(); //this makes the console to not close down immediately when the code is done running
        }
    }
}
