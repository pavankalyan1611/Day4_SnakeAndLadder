using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderPbr
{
    public class SnakeLadder
    {
        public const int LADDER = 1, SNAKE = 2;
        public int Position = 0, Count = 0, option, Die = 0;      
        public void Game()
        {                   
                Count++;
                Random random = new Random();
                Die = random.Next(1, 7);
                Console.WriteLine($"The number got by dice roll is {Die}");
                Random random2 = new Random();
                option = random2.Next(0, 3);
                switch (option)
                {
                    case LADDER:
                        Position += Die;
                        Console.WriteLine("The player climbed the ladder");                     
                        break;
                    case SNAKE:
                        Position -= Die;
                        if (Position < 0)
                        {
                            Console.WriteLine("The player bit by snake");
                            Position = 0;
                        }
                        else
                            Console.WriteLine("The player bit by snake");
                        break;
                    default:
                        Console.WriteLine($"No play");
                        break;
                }
                Console.WriteLine($"The player position is {Position} \n");            
                Console.WriteLine($"The dice has been rolled {Count} time by player till now \n");
        }
    }
}
