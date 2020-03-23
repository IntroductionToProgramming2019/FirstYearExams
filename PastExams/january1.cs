/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : Final Exam Semester One Year One
 * 
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int custAge, ticketCost;
            string custName, doAgain; ;

            do
            {
                Console.Write("Please enter name : ");
                custName = Console.ReadLine();

                Console.Write("Please enter age  : ");
                custAge = int.Parse(Console.ReadLine());

                ticketCost = GetCost(custAge);


                Console.WriteLine("\n{0} the cost of your ticket is {1:c}", custName, ticketCost);

                Console.Write("\nDo you wish to buy another (y/ n) : ");
                doAgain = (Console.ReadLine()).ToLower();

            }
            while (doAgain == "y");
        }

        static int GetCost(int age)
        {
            int tCost;
            if (age < 18)
                tCost = 10;
            else if (age < 21)
                tCost = 15;
            else
                tCost = 20;

            return tCost;
        }
    }
}

