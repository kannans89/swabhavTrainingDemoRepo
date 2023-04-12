using RectnagleEnumApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectnagleEnumApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            Rectangle rectangleA = new Rectangle(10, 20, ColorOption.BLUE,BorderOption.DOTTED);
            PrintDetails(rectangleA);
        }

        private static void CaseStudy1()
        {
            Rectangle rectangleA = new Rectangle(10, 20, ColorOption.GREEN);
            PrintDetails(rectangleA);
        }

        private static void PrintDetails(Rectangle rectangle)
        {
            Console.WriteLine("width "+rectangle.Width);
            Console.WriteLine("height "+rectangle.Height);
            Console.WriteLine("color "+rectangle.Color);
            Console.WriteLine("border " + rectangle.Border);
        }
    }
}
