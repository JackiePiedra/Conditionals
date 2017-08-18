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
            /*
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
            }*/

            //user enters the number of diners and cost per diner
            Console.WriteLine("Please enter the number of diners in your party:");
            int numberDiners = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the cost per diner:");
            double costPerDiner = double.Parse(Console.ReadLine());

            //calculating the total bill
            double totalBill = numberDiners * costPerDiner;

            //conditional to determine which discount they get
            if(totalBill >=50)
            {
                double discountedBill = totalBill * .9;
                Console.WriteLine("Thank you for dining with us! \nYou have received a 10% discount as part of our Customer Appreciation Week. \nYour total bill is "+ discountedBill+".");
            }
            else
            {
                double discountedBill = totalBill * .95;
                Console.WriteLine("Thank you for dining with us! \nYou have received a 5% discount as part of our Customer Appreciation Week. \nYour total bill is "+ discountedBill+ ".");
            }
           
        }
    }
}
