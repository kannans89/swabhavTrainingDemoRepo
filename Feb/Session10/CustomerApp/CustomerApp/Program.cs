﻿using CustomerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("A", 10);
            Customer c2 = new Customer("B", 10);
            Customer c3 = new Customer("C", 10);
            Console.WriteLine(c1.Id);// 1001
            Console.WriteLine(c2.Id);// 1002
            Console.WriteLine(c3.Id);// 1003
            Customer c4 = new Customer("D", 10);
            Console.WriteLine(c1.Id);// 1001
            Console.WriteLine(c2.Id);// 1002
            Console.WriteLine(c3.Id);// 1003
            Console.WriteLine(c4.Id);// 1004
        }
    }
}
