using System;
using System.Numerics;

namespace dicegame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gameLength = 0;
            string playerone = "Player 1";
            string enemyAI = "Enemy AI";
            var rand = new Random();
            int enemyroll;
            int playerroll; 
            int playerTotalScore = 0;
            int enemyTotalScore = 0;
            

            Console.WriteLine("Welcome to the dice game!");
            Console.WriteLine("You will battleing the Enemy AI, please put the number of rounds you would like to play(odd number only): ");
            string stringgamelength = Console.ReadLine();
            gameLength = Int32.Parse(stringgamelength);
            while (gameLength% 2 == 0) {

                Console.WriteLine($"{gameLength} is an even number, please enter an even number:");
                stringgamelength = Console.ReadLine();
                gameLength = Int32.Parse(stringgamelength);
            }
            for (int i = 0; i < gameLength; i++) 
            {
                Console.WriteLine("Press any key to roll the dice.");
                Console.ReadLine();
                playerroll = rand.Next(1,6);
                enemyroll = rand.Next(1, 6);
                while (playerroll == enemyroll) {
                    playerroll = rand.Next(1, 6);
                    enemyroll = rand.Next(1, 6);
                }
                Console.WriteLine($"{playerone} rolled a {playerroll}");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"The {enemyAI} rolled a {enemyroll}");
                
                if (playerroll > enemyroll)
                {
                    playerTotalScore++;
                }
                else
                {
                    enemyTotalScore++;
                }
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"The Score is {playerone}: {playerTotalScore}. {enemyAI}: {enemyTotalScore}\n");
            }
            if (playerTotalScore > enemyTotalScore)
            {
                Console.WriteLine($"{playerone} has won with a  score of {playerTotalScore} - {enemyTotalScore}");
            }
            else {
                Console.WriteLine($"{enemyAI} has won with a  score of {enemyTotalScore} - {playerTotalScore}");
            }
           

        }
    }
}
