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

namespace Q3
{
    class Program
    {
        static int[] votes = new int[3];
        static string[] contestant = new string[3];
        static int avgVotes;
        static int total = 0;
        static int max = 0, topContestent = 0;
        static int counter = 0;
        static void Main(string[] args)
        {


            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n{0,-30}{1,-5}{2,2}", "Enter name of contestant", i + 1, ": ");
                contestant[i] = Console.ReadLine();

                Console.Write("{0,-30}{1,-5}{2,2}", "Enter votes for contestant", i + 1, ": ");
                votes[i] = int.Parse(Console.ReadLine());
                if (votes[i] > max)
                {
                    max = votes[i];
                    topContestent = i;
                }


                total = total + votes[i];

            }

            avgVotes = total / 3;

            PrintReport();

        }

        static void PrintReport()
        {
            string star;



            Console.WriteLine("\n\n{0,-15}{1,-15}{2,-1}", "Contestant", "Votes", "");

            for (int i = 0; i < 3; i++)
            {
                star = CheckTop(i);
                Console.WriteLine("{0,-15}{1,-4}{2,1}", contestant[i], votes[i], star);
            }

            Console.WriteLine("\n{0,-35}{1,-15}", "Total votes", total);
            Console.WriteLine("{0,-35}{1,-15}", "Average", avgVotes);
            Console.WriteLine("{0,-35}{1,-15}", "Highest number of votes", max);
            Console.WriteLine("{0,-35}{1,-15}", "Contestants with highest votes", contestant[topContestent]);

        }

        static string CheckTop(int current)
        {
            string star;
            if (current == topContestent)
                star = "*";
            else
                star = "";

            return star;
        }
    }
}
