using SimpleRectnagleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleRectnagleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleA;//not an object, this expects an object
            rectangleA = new Rectangle();
            PrintDetails(rectangleA, "details of RectnagleA before initlizing values");

            rectangleA.width = -1000;
            rectangleA.height = 20;
            rectangleA.color = "blue";
            PrintDetails(rectangleA, "details of RectnagleA after initlizing values");

            Rectangle rectangleB;//expects an object
            rectangleB = rectangleA;
            PrintDetails(rectangleB, "details of RectnagleB");

            rectangleB.color = "Yellow";

            Console.WriteLine($"color of rectnagle B is :{rectangleB.color} , hascode is {rectangleB.GetHashCode()}");
            Console.WriteLine($"color of rectnagle A is :{rectangleA.color} hashcode is {rectangleA.GetHashCode()}");


        }


        static void PrintDetails(Rectangle rectangle, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"widht is {rectangle.width}" +
                $"height is {rectangle.height}" +
                $"color is {rectangle.color} " +
                $"Area is {rectangle.CalculateArea()}");
        }
    }
}
