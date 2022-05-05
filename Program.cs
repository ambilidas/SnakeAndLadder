using System;

namespace SnakeAndLadder
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake&ladder game");
            SnakeLadder myobj=new SnakeLadder();
            myobj.StartGame();
            
        }
    }
}
