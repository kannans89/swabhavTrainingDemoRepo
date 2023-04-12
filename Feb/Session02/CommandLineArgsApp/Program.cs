
using System;

namespace CommandLineArgsApp
{
    internal class Program
    {
        static void Main(string[] argsOfNames)
        {
            Console.WriteLine("Inside main");
            Console.WriteLine(argsOfNames.Length);
            for (int i = 0; i < argsOfNames.Length; i++) {
                Console.WriteLine("Hello " + argsOfNames[i]);
            }
            Console.WriteLine("end of main");
        }
    }
}
