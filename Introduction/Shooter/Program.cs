using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey play;
            do
            {
                play = Console.ReadKey(true).Key;
                switch (play)
                {
                    case ConsoleKey.Enter: Console.WriteLine("Fire");break;
                    case ConsoleKey.W: Console.WriteLine("Forward"); break;
                    case ConsoleKey.S: Console.WriteLine("Back"); break;
                    case ConsoleKey.A: Console.WriteLine("Left"); break;
                    case ConsoleKey.D: Console.WriteLine("Right"); break;
                    case ConsoleKey.Spacebar: Console.WriteLine("Jump"); break;
                    default:
                        Console.WriteLine("Error!"); break;
                }

            } while (Convert.ToChar(play) != 27);
        }
    }
}
