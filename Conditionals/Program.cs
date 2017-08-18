using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //conditional example
            //int age = 15;
            Console.WriteLine("Please enter your age");
            int age = int.Parse(Console.ReadLine());
            if(age>=17)
            {
                Console.WriteLine("You can see this movie.");
            }
            else
            {
                Console.WriteLine("Sorry! You're too young! :(");
            }
            
            /*//Collect info, number of diners and cost per diner
            Console.WriteLine("Please enter the number of diners:");
            double numberDiners = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the cost per diner:");
            double costPerDiner = double.Parse(Console.ReadLine());*/
        }
    }
}
