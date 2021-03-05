using System;

namespace Snake_Ladder_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
                int Player1 = 0;
                Console.WriteLine("WELL COME TO SNAKE LADDER GAME.Player1 Start Game With: "+Player1);
                Random random = new Random();
                int Die = random.Next(0, 7);
                {
                    Console.WriteLine("Player1 Get A Number:" + Die);
                }
        }
    }
}
