using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementChallenge
{
    class Program
    {
        static int highScore = 300;
        static string highScorePlayer = "Dustin";

        static void Main(string[] args)
        {
            CheckHighScore(250, "Colton");
            CheckHighScore(315, "Allie");
            CheckHighScore(350, "Dustin");

            Console.Read();
        }
        public static void CheckHighScore(int score, string playerName)
        {
            if (score > highScore)
            {
                highScore = score;
                highScorePlayer = playerName;

                Console.WriteLine("New highscore is "+ score);
                Console.WriteLine("It is now held by " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore could not be broken. It is still " +
                    highScore +" and held by " + highScorePlayer);
            }
        }
    }
}
