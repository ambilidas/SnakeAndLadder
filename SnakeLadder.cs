using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeLadder
    {
        
        
        public const int Noplay = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        Random random = new Random();
        public void StartGame()
        {
            int Position = 0;
            Console.WriteLine("Player starts at position {0}",Position);
            int die = random.Next(1, 7);
            int option=random.Next(0,3);

            switch (option)
            {
                case Ladder:
                    
                   Position += die;
                    break;
                   
                case Snake:

                    Position -= die;
                    break ;
                default:
                    Position = Position;
                    break;
            }
            Console.WriteLine(Position);
            
        }
    }
}
