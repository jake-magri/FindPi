using System;
using static System.Console;

namespace FindPi
{
    class Program
    {
        static void Main(string[] args)

        // Created by Jake Magri
        {

            double Pi = 0; // declare variables to work with
            double numerator = 4;
            double denominator = 1;

            Write("Enter the number of terms: "); // read in terms from console with prompt
            int terms = Convert.ToInt32(ReadLine());

            WriteLine("Term\t\tPi"); // format table header

            for (int i = 1; i <= terms; i++) // set conditions and increasing increment
            {
                if (i % 2 == 1) // condition for odd terms
                {
                    Pi = Pi + numerator / denominator; // formula
                    Write("{0,-16}", i);
                    Write("{0,-18:#,##0.0000000000000000}", Pi); // fancy formatting
                }
                else // condition for even terms
                {
                    Pi = Pi - numerator / denominator; // formula
                    Write("{0,-16}", i);
                    Write("{0,-18:#,##0.0000000000000000}", Pi); // fancy formatting
                }
                denominator += 2; // increases denominator by a factor of 2
                WriteLine();
            }


        }
    }
}
