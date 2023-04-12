using PlayerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerApp
{
    internal class Program:Object
    {
        static void Main(string[] args)
        {
            //CaseStudy1();

            // CaseStudy2();
            int x = 10;

            Player sachin = new Player(1, "Sachin", 15);
            Player[] manyPlayers = new Player[5];
            manyPlayers[0] = new Player(1, "Player 1", 20);
            manyPlayers[1] = sachin;
            manyPlayers[2] = sachin;
            manyPlayers[3] = sachin;
            manyPlayers[4] = sachin;

            foreach (Player player in manyPlayers) {
                PrintDetails(player,"");
            }

        }

        private static void CaseStudy2()
        {
            Player sachin = new Player(1, "Sachin", 15);
            Player virat = new Player(2, "Virat");
            Player elder = sachin.WhoIsElder(virat);// WhoIsElder(sachin,virat);

            Console.WriteLine(elder.Name);
            Console.WriteLine("sachin hash " + sachin.GetHashCode());
            Console.WriteLine("variat hash " + virat.GetHashCode());
            Console.WriteLine("elder hash " + elder.GetHashCode());
        }

        private static void CaseStudy1()
        {
            Player playerA = new Player(1, "Sachin", 50);
            Player playerB = new Player(2, "Virat");

            PrintDetails(playerA, "Player A details");
            PrintDetails(playerB, "Player B details");
        }

        static void PrintDetails(Player player,string descrption) {
            Console.WriteLine(descrption.ToUpper());
            Console.WriteLine("id is :"+player.Id);
            Console.WriteLine("Name is :" + player.Name);
            Console.WriteLine("Age is :" + player.Age);

        }
    }
}
