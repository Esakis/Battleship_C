using System;
using System.Collections;
using Battleship.Model;
using Battleship.Enums;

namespace Battleship.Model
{
    public class BoardFactory
    {


        public static void RandomPlacement(int size, int numbCarrier, int numbCruiser, int numbBattleship,
            int numbSubmarine, int numbDestroyer)
        {
            ArrayList blocketPositions = new ArrayList();
            ArrayList listOfShips = new ArrayList();

            foreach (var position in listOfShips)
            {
                Random horizontalRandom = new Random();
                int chosenHorizontal = horizontalRandom.Next(0, 2);
                Random positionX = new Random();
                int startPositionX = positionX.Next(1, size++);
                Random positionY = new Random();
                int startPositionY = positionY.Next(1, size++);
                int shipLeight = 0;


                if (numbCarrier > 0)
                {
                    shipLeight = 1;
                    if (startPositionX + shipLeight > size)
                    {
                        break;
                    }

                    numbCarrier--;
                }
                else if (numbCruiser > 0)
                {
                    shipLeight = 2;
                    if (startPositionX + shipLeight > size)
                    {
                        break;
                    }

                    numbCruiser--;
                }
                else if (numbBattleship > 0)
                {
                    shipLeight = 3;
                    if (startPositionX + shipLeight > size)
                    {
                        break;
                    }

                    numbBattleship--;
                }
                else if (numbSubmarine > 0)
                {
                    shipLeight = 4;
                    if (startPositionX + shipLeight > size)
                    {
                        break;
                    }

                    numbSubmarine--;
                }
                else if (numbDestroyer > 0)
                {
                    shipLeight = 5;
                    if (startPositionX + shipLeight > size)
                    {
                        break;
                    }

                    numbDestroyer--;
                }

                int positionI = startPositionX;
                int positionJ = startPositionY;

                int[,] newShip = new int [1, 0];
                int[,] newBlockedPlace1 = new int [1, 0];
                int[,] newBlockedPlace2 = new int [1, 0];
                int n = shipLeight;
                ArrayList blocketPositionsSmall = new ArrayList();
                ArrayList listOfShipsSmall = new ArrayList();

                while (n > 0)
                {
                    n--;
                    newShip[0, 0] = positionI;
                    newShip[1, 0] = positionJ;
                    newBlockedPlace1[0, 0] = positionI;
                    newBlockedPlace1[1, 0] = positionJ + 1;
                    newBlockedPlace2[0, 0] = positionI;
                    newBlockedPlace2[1, 0] = positionJ - 1;
                    foreach (var blockedElement in blocketPositions
                    ) //porównuję czy nowy element jest w tablicy zablokowanych
                    {
                        if (newShip == blockedElement)
                        {
                            if (shipLeight == 1)
                            {
                                numbCarrier++;
                            }
                            else if (shipLeight == 2)
                            {
                                numbCruiser++;
                            }
                            else if (shipLeight == 3)
                            {
                                numbBattleship++;
                            }
                            else if (shipLeight == 4)
                            {
                                numbSubmarine++;
                            }
                            else if (shipLeight == 5)
                            {
                                numbDestroyer++;
                            }

                            break;
                        }
                    }

                    listOfShipsSmall.Add(newShip);
                    blocketPositionsSmall.Add(newBlockedPlace1);
                    blocketPositionsSmall.Add(newShip);
                    blocketPositionsSmall.Add(newBlockedPlace2);
                    if (chosenHorizontal == 1)
                    {
                        positionI++;
                    }
                    else
                    {
                        positionJ++;
                    }

                }

                foreach (var pos in listOfShipsSmall)
                {
                    listOfShips.Add(pos);

                }

                foreach (var pos in blocketPositionsSmall)
                {
                    blocketPositions.Add(pos);
                }


            }
            //Tworzenie tablicy:

            var board = new Board(size);
            for (int i = 0; i < board.Ocean.GetLength(0); i++)
            {
                for (int j = 0; j < board.Ocean.GetLength(1); j++)
                {
                    foreach (var position in listOfShips)
                    {
                        if (position[0] == i && position[1] == j)
                        {
                            Point2D[i, j] = Board.darkCage;
                        }
                        else
                        {
                            Point2D = Board.blueCage;
                        }
                    }
                }

            }

        }

/*
        public static Board ManualPlacement()
        {
            throw new NotImplementedException();
        }
        */
    }
}
