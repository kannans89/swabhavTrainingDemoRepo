using AccountCounterApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountCounterApp
{
    
    internal class Program
    {
       //static string foo = "hello";
        static void Main(string[] args)
        {
            // Console.WriteLine(foo);
            // CaseStudy1();

            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            Account acc1 = new Account(101, "A", 500);
            Console.WriteLine(Account.HeadCount());

            Account acc2 = new Account(102, "B", 500);
            Console.WriteLine(Account.HeadCount());

            Account acc3 = new Account(103, "C", 500);
            Console.WriteLine(Account.HeadCount());

            Console.ResetColor();
        }

        private static void CaseStudy1()
        {
            Account acc1 = new Account(101, "A", 500);
            Console.WriteLine(acc1.InstanceCount);

            Account acc2 = new Account(102, "B", 500);
            Console.WriteLine(acc1.InstanceCount);

            Account acc3 = new Account(103, "C", 500);
            Console.WriteLine(acc1.InstanceCount);
        }
    }
}
