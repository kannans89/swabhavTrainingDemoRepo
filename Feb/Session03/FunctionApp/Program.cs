using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FunctionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintName("Vikrant", 10);
            bool result1 = CheckIsEven1(3);
            Console.WriteLine("CheckIsEven1:" + result1);
            Console.WriteLine("CheckIsEven2:" + CheckIsEven2(6));
            Console.WriteLine("CheckIsEven3:" + CheckIsEven3(7));
            Console.WriteLine("CheckIsEven4:" + CheckISEven4(8));

            PrintTodaysDate();
            Console.WriteLine(GetDeveloperNames());

            string[] developerNames = GetDeveloperNames();
            foreach (string name in developerNames) {
                Console.WriteLine(name.ToUpper());
            }

            /*
            Console.Write("Enter your name :");
            string userName =Console.ReadLine();
            Console.WriteLine("Welcome back:"+userName.ToUpper());*/

            RollDice(10);
        }

        static string[] GetDeveloperNames()
        {

            String[] names = { "Aishwarya","Ekta","Vikrant",
                "Guarav" ,"Ravi","Manjunath"};

            return names;
        }
        static void PrintTodaysDate()
        {
            Console.WriteLine(DateTime.Now.ToString("M"));
        }

        static bool CheckIsEven1(int input)
        {

            if (input % 2 == 0)
                return true;
            else
                return false;

        }
        static bool CheckIsEven2(int input)
        {
            if (input % 2 == 0)
                return true;

            return false;
        }

        static bool CheckIsEven3(int input)
        {
            return (input % 2 == 0);
        }

        static string CheckISEven4(int input)
        {

            return (input % 2 == 0) ? "Input is Even" :
                 "Input is Odd";
        }

        static void PrintName(string userName, int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                Console.WriteLine(userName.ToUpper());
            }
        }
    }
}
