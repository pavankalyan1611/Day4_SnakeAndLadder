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
        public SnakeLadder()
        {
            Console.WriteLine("Welcome To snake and Ladder Game :\n");
        }
        public void Game()
        {
            int Position = 0;
            Console.WriteLine($"Initial Position Of the Player Is \"{Position}\"\n");
            for (; Position < 100;)
            {
                Random random = new Random();
                int Die = random.Next(1, 7);
                Console.WriteLine($"The number got by dice roll is {Die}");
                Random random2 = new Random();
                int option = random2.Next(0, 3);
                switch (option)
                {
                    case LADDER:
                        Position += Die;
                        Console.WriteLine("The player climbed the ladder");
                        if (Position > 100)
                        {
                            Position -= Die;
                        }
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
            }
        }
    }
}
