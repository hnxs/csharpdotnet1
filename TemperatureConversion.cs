/* This program will convert 
 * celsius to Fahrenheit. I will
 * Change the value of the initialization to 
 * test the program to make sure it works.
 * Developer: Heather N. Smith
 * Date: April 11, 2016
 * Problem: Chapter 2 Ex 3
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration of values
            double celsius = 52.0;
            double fahrenheit;

            // Convert Celsius to Fahrenheit
            fahrenheit = (9.0 / 5.0 * celsius) + 32;
           
            // Output of Values
            Console.WriteLine("Temperature Conversion Tool");
            Console.WriteLine("\nDegrees in Celsius; {0}", celsius);
            Console.WriteLine("Degrees in Fahrenheit; {0:f1}", fahrenheit);
            Console.ReadKey();
        }
    }
}
