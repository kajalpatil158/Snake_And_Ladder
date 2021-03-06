using System;

namespace Snake_Ladder_Problem
{
    class Snake_And_Ladder
    {
        static void Main(string[] args)
        {
            int player1 = 0;
            int No_Play = 0;
            int Ladder = 1;
            int Snake = 2;
            Random random = new Random();
            int die = random.Next(0, 7);
            Random rand = new Random();
            int option = random.Next(0, 3);
            {
               if(option==No_Play)
                {
                    Console.WriteLine("Player at same position " + No_Play);
                }
               else if(option==Ladder)
                {
                    Console.WriteLine("player moves position with number " + die);
                }
               else
                {
                    Console.WriteLine("player moves behind by the number: " + die);  
                }
            }
        }
    }
}