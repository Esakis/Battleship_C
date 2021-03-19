using Battleship.Model;
using System;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Menu menu = new Menu();
            menu.Run();
        }
    }
}
