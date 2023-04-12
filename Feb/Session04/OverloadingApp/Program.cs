using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace OverloadingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDetails(50);
            PrintDetails(10.55);
            PrintDetails(10.55f);
            PrintDetails("Monocept");
            PrintDetails('a');
            PrintDetails('A');
            PrintDetails(10 > 5);
           

        }

        private static void PrintDetails(int input) {
            Console.WriteLine("Printing integer input {0},double: {1} ",input,2*input);
        }

        private static void PrintDetails(double input)
        {
            Console.WriteLine("printing a double value ,value is {0}",input);
        }
        private static void PrintDetails(float input) {
            Console.WriteLine("printing a float value ,value is {0}", input);
        }

        private static void PrintDetails(string input) {
            Console.WriteLine("printing a string value {0} ",input);
        }

        private static void PrintDetails(char input)
        {
            Console.WriteLine("printing a character value {0} , ascii value is {1}",input,(int)input);
        }

        private static void PrintDetails(bool input) {

            Console.WriteLine("printign a boolean value {0} ",input);
        }
    }
}
