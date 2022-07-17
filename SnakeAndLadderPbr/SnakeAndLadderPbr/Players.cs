using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderPbr
{
    public class Players
    {
        public const int WIN = 100;
        public Players()
        {
            Console.WriteLine("Welcome To Snake and Ladder Game Program :");
        }
        public void Ladder()
        {
           
            SnakeLadder player1 = new SnakeLadder();
            SnakeLadder player2 = new SnakeLadder();
            Console.WriteLine("The starting position of player is: "+ player1.Position +"\n");

            while (player1.Position < WIN || player2.Position < WIN)
            {
                Console.WriteLine("Player 1:");
                player1.Game();
                if((player1.option ==1) && (player1.Position < WIN))
                {
                    Console.WriteLine("Player 1:");
                    player1.Game();
                }
                if (player1.Position > WIN)
                    player1.Position -= player1.Die;

                if (player1.Position == WIN)
                {
                    Console.WriteLine("Player 1 won the game");
                    break;
                }


                Console.WriteLine("Player 2:");
                player2.Game();
                if(player2.option==1 && player2.Position < WIN)
                {
                    Console.WriteLine("Player 2:");
                    player2.Game();
                }
                if (player2.Position > WIN)
                    player2.Position -= player2.Die;

                if (player2.Position == WIN)
                {
                    Console.WriteLine("Player 2 won the game");
                    break;
                }
            }

        }
    }
}
