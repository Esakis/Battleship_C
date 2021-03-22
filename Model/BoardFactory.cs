using System;
using System.Collections.Generic;
using Battleship.Model.Enums;

namespace Battleship.Model
{
    public static class BoardFactory
    {
        public static Board RandomPlacement(int boardSize, int shipCount, Player owner)
        {
            Board board = new Board(boardSize);
            Random rnd = new Random();

            for (int i = 0; i < shipCount;)
            {
                int rndX = rnd.Next(boardSize);
                int rndY = rnd.Next(boardSize);
                
                // if Square in ocean is empty, fill it by Ship
                if (board.Ocean[rndY, rndX].Ship == null)
                {
                    var ship = new Ship(ShipType.Carrier,
                        new List<Square> {board.Ocean[rndY, rndX]},
                        owner);
                    board.Ocean[rndY, rndX].Ship = ship;
                    owner.Ships.Add(ship);
                    i++;
                }
            }

            return board;
        }

        public static Board ManualPlacement()
        {
            throw new NotImplementedException();
        }
    }
}