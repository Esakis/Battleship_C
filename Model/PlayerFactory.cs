using System;
using Battleship.Enums;

namespace Battleship.Model
{
    public static class PlayerFactory
    {
        public static Player StandardPlayer(ConsoleColor color, PlayerNumber number, int boardSize)
        {
            return new StdPlayer(color, number, boardSize);
        }
        
        public static Player AI(ConsoleColor color, PlayerNumber number, int boardSize)
        {
            return new AI(color, number, boardSize);
        }
    }
}