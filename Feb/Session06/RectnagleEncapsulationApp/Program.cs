
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
            Rectangle rectnagleA = new Rectangle();
            rectnagleA.SetWidth(101);
            rectnagleA.SetHeight(-100);
            rectnagleA.SetColor("abcd");
            PrintDetails(rectnagleA, "Details of rectnagle A");

            Rectangle rectnagleB = new Rectangle();
            rectnagleB.SetWidth(20);
            rectnagleB.SetHeight(30);
            rectnagleB.SetColor("bluE");
            PrintDetails(rectnagleB, "Details of Rectnagel B"); 


        }

        static void PrintDetails(Rectangle rectnagel, string descprion) {

            Console.WriteLine(descprion.ToUpper());
            Console.WriteLine($"widht is {rectnagel.GetWidth()}");
            Console.WriteLine($"height is {rectnagel.GetHeight()}");
            Console.WriteLine($"Colore  is {rectnagel.GetColor()}");
            Console.WriteLine($"Area is {rectnagel.CalculateArea()}");

            Console.WriteLine();
        
        }
    }
}
