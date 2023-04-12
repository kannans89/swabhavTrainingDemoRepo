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
            CaseStudy3();
        }
        private static void CaseStudy3()
        {
            int[] scores = { 10,20,30,40 };
           // Console.WriteLine(scores.GetType());
           // Console.WriteLine(scores);

            UpdateScoresToZero(scores);
            foreach (int score in scores) {
                Console.WriteLine(score);
            }

            Console.WriteLine("Hashcode of scores is {0}",
                scores.GetHashCode());
        }
        private static void UpdateScoresToZero(int[] pscores) {
            for (int i = 0; i < pscores.Length; i++) { 
               pscores[i] = 0;
            }

            Console.WriteLine("HashCode of pscores is {0} ",
                pscores.GetHashCode()); 
        }
        private static void CaseStudy2() {
            int salary = 1000;
            UpdateSalaryToZero(ref salary);
            Console.WriteLine("CaseStudy2,salary value is : {0}", salary);
        
        }

        private static void UpdateSalaryToZero(ref int psalary) {
            psalary = 0;
        }
        private static void CaseStudy1() {
            int mark = 100;
            UpdateMarkToZero(mark);
            Console.WriteLine("CaseStudy1, mark value is {0}",mark);
        }

        private static void UpdateMarkToZero(int mark) {
            mark = 0;
        }
    }
}
