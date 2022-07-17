using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderPbr
{
    public class SnakeLadder
    {
        public SnakeLadder()
        {
            Console.WriteLine("Welcome To snake and Ladder Game :");
        }
        public void Game()
        {
            int Position = 0;
            Console.WriteLine($"Initial Position Of the Player Is \"{Position}\"");

            Random random = new Random();
            int Die = random.Next(1, 7);
            Console.WriteLine($"The number got by dice roll is {Die}");

        }
    }
}
