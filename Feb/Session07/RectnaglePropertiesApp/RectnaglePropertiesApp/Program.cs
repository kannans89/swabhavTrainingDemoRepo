using RectnaglePropertiesApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectnaglePropertiesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);

            Rectangle rectangleA = new Rectangle(100, 50, "green");
            PrintDetails(rectangleA, "Rectangle A");
            rectangleA.Color = "red";
            rectangleA.Height = 30;

            PrintDetails(rectangleA, "Rectangle A after color change");
        }

        static void PrintDetails(Rectangle rectnagle, string description)
        {

            Console.WriteLine(description.ToUpper());
            Console.WriteLine("Width is :" + rectnagle.Width);
            Console.WriteLine("Height is :" + rectnagle.Height);
            Console.WriteLine("Color is :" + rectnagle.Color);
            Console.WriteLine();
        }
    }
}
