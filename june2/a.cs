/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : Final Exam Semester Two Year One
 * 
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Sem2_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike[] bikes = new Bike[4];
            bikes[0] = new Bike("Raleigh", 500);
            bikes[1] = new Bike();
            bikes[1].Brand = "raleigh";
            bikes[1].Price = 500;
            bikes[2] = new ElectricBike("Raleigh", 1700, 30);
            bikes[3] = new ElectricBike("Boardman", 850.0, 20);

            for (int i = 0; i < bikes.Length; i++)
            {
                Console.WriteLine(bikes[i].ToString());

            }
        }
    }
}
