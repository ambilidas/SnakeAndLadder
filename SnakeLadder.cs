using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeLadder
    {
        int Position = 0;
        Random random = new Random();
        

        public void StartGame()
        {
            Console.WriteLine("Player starts at position {0}",Position);
        }
    }
}
