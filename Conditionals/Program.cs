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
            if (age == 21)
            {
                Console.WriteLine("Let's get a drink");
            }
            else if (age ==18)
            {
                Console.WriteLine("You are now an adult");
            }
            else if (age>=17)
            {
                Console.WriteLine("You can see this movie.");
            }
            else
            {
                Console.WriteLine("Sorry! You're too young! :(");
            }*/

            
            //ask the user to enter the number of diners and cost per diner
            Console.WriteLine("Please enter the number of diners in your party:");
            int numberDiners = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the cost per diner:");
            double costPerDiner = double.Parse(Console.ReadLine());
            
            //calculating the total bill
            double totalBill = numberDiners * costPerDiner;

            /* 
            //conditional to determine which discount they get
            if(totalBill >=50)
            {
                double discountedBill = totalBill * .9;
                Console.WriteLine("Thank you for dining with us! \nYou have received a 10% discount as part of our Customer Appreciation Week. \nYour total bill is $"+ discountedBill+". The total per guest is $" +(discountedBill/numberDiners)+".");
            }
            else
            {
                double discountedBill = totalBill * .95;
                Console.WriteLine("Thank you for dining with us! \nYou have received a 5% discount as part of our Customer Appreciation Week. \nYour total bill is $"+ discountedBill+". The total per guest is $" + (discountedBill / numberDiners) + ".");
            } */

            double discount = 0.0;
            if(totalBill >= 50)
            {
                discount = 1.10;
                totalBill /= discount;
            }
            else
            {
                discount = 1.05;
                totalBill = totalBill / discount;
            }

            double perGuest = totalBill / numberDiners;
            Console.WriteLine("Thank you for dining with us! Your new total is $"+totalBill+ ". Each guest will pay $"+perGuest+".");
           
            /*Console.WriteLine("Enter your percentage");
            int grade = int.Parse(Console.ReadLine());
            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("You got an A!");
            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine("You got a B! Not Bad");
            }*/

            //creating a demographic report based on age
            //ask the user to enter their age
            //determine which category each user fits into based on age

            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());
            if (age <= 2)
            {
                Console.WriteLine("Still in Mama's arms");
            }
            else if (age ==3 || age == 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if(age >=5 && age <= 11)
            {
                Console.WriteLine("Elementary School");
            }
            else if(age >=12 && age <=14)
            {
                Console.WriteLine("Middle School");
            }
            else if (age >=15 && age <= 18)
            {
                Console.WriteLine("High School");
            }
            else if (age >19 && age <=22)
            {
                Console.WriteLine("College");
            }
            else if(age >=23 && age <=65)
            {
                Console.WriteLine("Working for the Man");
            }
            else if (age >=66 && age <=100)
            {
                Console.WriteLine("The Golden Years");
            }
            else if (age <0 || age >100)
            {
                Console.WriteLine("This program is for humans.");
            }

            //Write a console application that asks the user for a number. Tell the user if that number is even or odd
            //Modulus operator %

            Console.WriteLine("Please enter a number:");
            int inputNumber = int.Parse(Console.ReadLine());
            //int test = inputNumber % 2;
            //if (test == 0)
            if(inputNumber % 2 == 0) //can perform the calculation in the IF statement
            {
                Console.WriteLine("This number is even.");
            }                   
            else
            {
                Console.WriteLine("This number is odd.");
            }
        }
    }
}
