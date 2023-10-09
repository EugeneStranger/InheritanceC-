using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
     class Program
    {
        static void Main(string[] args)
        {
            //Console.WindowTop = 10;
            //Console.SetWindowPosition(10, 10);
            Console.Title = "Introduction to.NET";

            Console.Beep(370, 1000);

            Console.Write("Hello .NET");
            Console.WriteLine();

            //Console.SetCursorPosition(20, 10);
            Console.CursorLeft = 50;
            Console.CursorTop = 8;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cursor position check");

            Console.SetCursorPosition(25, 5);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cursor position check2");
            Console.BackgroundColor = ConsoleColor.Black;

        }
    }
}
