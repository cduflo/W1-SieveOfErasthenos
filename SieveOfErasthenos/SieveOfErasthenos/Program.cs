using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{
    class Program
    {
        //Create Input Capture and Validation Method
        // must be number > 1
        // "Error: Please enter a valid number"
        static int GetInteger(string prompt)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    int x = int.Parse(input);
                    if (x > 1)
                    {
                        return x;
                    }
                    else
                    {
                        Console.WriteLine("Error: Please enter a valid number.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: Please enter a valid number.");
                }
            }
        }
        

        //Define Method which returns True or False for an entered number being Prime
        static bool IsPrime(int x)
        {
            int testint = x;
            double n = 2;

            while (n <= testint)
            {
                if ((testint / n) % 1 == 0 && testint == n)
                {
                    return true;
                }
                else if ((testint / n) % 1 == 0)
                {
                    return false;
                }
                else
                {
                    n++;
                }
            }
            return false;
        }


        static void Main(string[] args)
        {
            //Set Variables, fetch user input
            int input = GetInteger("Please enter an integer, greater than 1.");
            int topNum = input;
            int i;
            List<int> PrimeNumbers = new List<int>();

            //Cycle through numbers between 2 and user's number to fetch prime numbers in range, add fetched to list
            for (i = 2; i <= topNum; i++)
            {
                if (IsPrime(i) == true)
                {
                    PrimeNumbers.Add(i);
                }
            }

            // Print out list of prime numbers in range
            foreach (int x in PrimeNumbers)
            {
                Console.WriteLine(x);
            }

            //Hold window open for review
            Console.ReadLine();
        }
    }
}
