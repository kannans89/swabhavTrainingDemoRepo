using RectangleConstructorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleConstructorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDetails(new Rectangle(width: 10, height: 20, color: "blue"),"Anonymous object");

            Rectangle rectangleA = new Rectangle(100, 50, "green");
            PrintDetails(rectangleA, "Rectangle A");
            rectangleA.SetColor("red");
            PrintDetails(rectangleA, "Rectangle A after color change");

        }

       static void PrintDetails(Rectangle rectnagle,string description) {

            Console.WriteLine(description.ToUpper());
            Console.WriteLine("Width is :"+rectnagle.GetWidth());
            Console.WriteLine("Height is :" + rectnagle.GetHeight());
            Console.WriteLine("Color is :" + rectnagle.GetColor());
            Console.WriteLine();
        }
    }
}
