
using RectangleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle small;//expects an object
            small = new Rectangle();
            small.height = 10;
            small.width = 20;
            Console.WriteLine(small.CalculateArea());


        }
    }
}
