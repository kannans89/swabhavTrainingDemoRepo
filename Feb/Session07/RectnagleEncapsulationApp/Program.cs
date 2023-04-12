
using RectnagleEncapsulationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RectnagleEncapsulationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("displaying anonymous object details");
            Console.WriteLine(new Rectangle().CalculateArea());
            PrintDetails(new Rectangle(),"anonymous object 2");
            //PrintDetails(null, null);

            Rectangle rect=null;
            //rect = new Rectangle();
            rect.SetWidth(20);
            rect.SetHeight(30);
            PrintDetails(rect, "Rect object");
        }

        static void PrintDetails(Rectangle rectangle, string descprion) {

            Console.WriteLine(descprion.ToUpper());
            Console.WriteLine($"widht is {rectangle.GetWidth()}");
            Console.WriteLine($"height is {rectangle.GetHeight()}");
            Console.WriteLine($"Colore  is {rectangle.GetColor()}");
            Console.WriteLine($"Area is {rectangle.CalculateArea()}");

            Console.WriteLine();
        
        }
    }
}
