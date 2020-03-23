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
using System.IO;

namespace Q1_Summer_2019
{
    class Program
    {
        static int[] totalCount = new int[4];
        static int[] typeTotal = new int[5];

        static string[] columns = new string[3];

        static int qty;
        static int grandTotalCount = 0;
        static int grandTotalValue = 0;


        static void Main(string[] args)
        {
            try
            {


                string path = @"h:\ticketsales.txt";
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);// ct=reate File Stream
                StreamReader sr = new StreamReader(fs); //create streareader object


                string inputText = sr.ReadLine(); // get first record

                while (inputText != null) // while not EOF
                {
                    // process record

                    columns = inputText.Split(','); // split on ','

                    qty = Convert.ToInt32(columns[2]); // extraxt quantity from array
                    string type = columns[0];

                    GroupByType(type, qty);

                    inputText = sr.ReadLine();
                }

                sr.Close();


                PrintReport();
            }
            catch (IOException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintReport()
        {
            string[] bands = { "Basic", "Super", "Premium", "VIP" };
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}", "Type", "Count", "Value");
            Console.WriteLine();

            int valueTotal = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}", bands[i], totalCount[i], typeTotal[i]);
                valueTotal += typeTotal[i];
                grandTotalCount += totalCount[i];
            }
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", "Totals", grandTotalCount, valueTotal);

        }


        private static void GroupByType(string type, int qty)
        {

            if (type == "Basic")
            {
                Track(0, 40); // sent index of 0 and price of 40 to Track method

            }
            else if (type == "Super")
            {
                Track(1, 45);

            }
            else if (type == "Delux")
            {
                Track(2, 55);
            }

            else // VIP
            {
                Track(3, 60);
            }
        }

        static void Track(int index, int price)
        {
            totalCount[index] += qty; // add quantity to correct array element

            typeTotal[index] += qty * price;

        }
    }
}
