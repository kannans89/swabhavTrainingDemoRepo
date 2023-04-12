using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassingValuesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            // CaseStudy4();
            CaseStudy5();

        }

        private static void CaseStudy5()
        {

            DisplayMultiplcation(first: 10);
            DisplayMultiplcation(first:10, 20);
            DisplayMultiplcation(first:10, 20, 30, 40, 50);
        }

        private static void DisplayMultiplcation(int first,
            params int[] numbers)
        {
            int product = first;

            foreach (int number in numbers) {
                product *= number;
            }


            Console.WriteLine(format: "product is {0}", product);
        }
        private static void CaseStudy4()
        {
            int sum, avg, product;

            Calculate(first: 10, second: 20, third: 30, out sum, out avg, out product);

            Console.WriteLine("sum is {0} avg is {1} product {2}",
                sum, avg, product);

            Console.WriteLine("Enter a number only");
            string input = Console.ReadLine();
            int no = 0;
            if (int.TryParse(input, out no))
            {
                Console.WriteLine(no * no);
            }
            else
            {
                Console.WriteLine("numbers only allowed :" + input);
            }

            /*
            int no= int.Parse(input);
            Console.WriteLine(no*no);
            */


        }

        private static void Calculate(int first, int second, int third, out int sum, out int avg, out int product)
        {


            sum = first + second + third;
            avg = sum / 3;
            product = first * second * third;



        }

        private static void CaseStudy3()
        {
            int[] scores = { 10, 20, 30, 40 };
            // Console.WriteLine(scores.GetType());
            // Console.WriteLine(scores);

            UpdateScoresToZero(scores);
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine("Hashcode of scores is {0}",
                scores.GetHashCode());
        }
        private static void UpdateScoresToZero(int[] pscores)
        {
            for (int i = 0; i < pscores.Length; i++)
            {
                pscores[i] = 0;
            }

            Console.WriteLine("HashCode of pscores is {0} ",
                pscores.GetHashCode());
        }
        private static void CaseStudy2()
        {
            int salary = 1000;
            UpdateSalaryToZero(ref salary);
            Console.WriteLine("CaseStudy2,salary value is : {0}", salary);

        }

        private static void UpdateSalaryToZero(ref int psalary)
        {
            psalary = 0;
        }
        private static void CaseStudy1()
        {
            int mark = 100;
            UpdateMarkToZero(mark);
            Console.WriteLine("CaseStudy1, mark value is {0}", mark);
        }

        private static void UpdateMarkToZero(int mark)
        {
            mark = 0;
        }
    }
}
