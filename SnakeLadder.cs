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
       
        public void StartGame()
        {
            Random random = new Random();
            int Position = 0;
            int dice;
            int option;
            Console.WriteLine("Player starts at position {0}",Position);
           
   

            while(Position < 100)
            {
                dice = random.Next(1, 7);

                Console.WriteLine("Number appeared in dice is:" +dice);

                //player option generation
                option = random.Next(0, 3);
                Console.WriteLine("Player option is: " +option);

                if(option == Ladder)
                {
                    if((Position + dice) > 100)
                    {
                        Position = 100;
                    }
                    else
                    {
                        Position += dice;
                    }
                }

                else if(option == Snake)
                {
                    if(Position < dice)
                    {
                        Position=0;
                    }
                    else
                    {
                        Position -= dice;
                    }
                }
                else
                {
                    Position = Position;
                }
                Console.WriteLine("Player reaches at: " +Position);
            }

           /* switch (option)
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
            Console.WriteLine(Position);*/
            
        }
    }
}
