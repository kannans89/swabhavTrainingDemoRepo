using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
           // CaseStudy4();
           

        }

        private static void CaseStudy4()
        {
            Account accountA = new Account(1001, "Vikrant",1500);
            accountA.Withdraw(1000);
            PrintDetails(accountA);
        }

        private static void CaseStudy3()
        {
            Account accountA = new Account(1001, "Vikrant");
            accountA.Deposit(1000);
            PrintDetails(accountA);
        }

        private static void CaseStudy2()
        {
            Console.WriteLine();
            Account accountB = new Account(1002, "Ekta", 1000);
            PrintDetails(accountB);

        }

        private static void CaseStudy1()
        {
            Account accountA = new Account(1001, "Vikrant");
            PrintDetails(accountA);

            Console.WriteLine(accountA.Accouno==1001);
            Console.WriteLine(accountA.Name == "Vikrant");
        }

        static void PrintDetails(Account account) {
            Console.WriteLine("name :" + account.Name);
            Console.WriteLine("balance :" + account.Balance);
            Console.WriteLine("accno :" + account.Accouno);
        }
    }
}
