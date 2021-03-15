using System;
using System.Collections;
using Battleship.Enums;

namespace Battleship.Model
{
    public  class BoardFactory
    {

        
        public static void RandomPlacement(int size, int numbCarrier, int numbCruiser, int numbBattleship, int numbSubmarine, int numbDestroyer)
        {
            ArrayList blocketPositions = new ArrayList();
            int numbOfShips = numbCarrier + numbCruiser + numbBattleship + numbSubmarine + numbDestroyer;
            ArrayList listOfShips = new ArrayList(numbOfShips);
            
            foreach (var position in listOfShips)
            {
                Random horizontalRandom = new Random();
                int chosenHorizontal = horizontalRandom.Next(0, 2);
                Random positionX = new Random();
                int startPositionX = positionX.Next(1, size++);
                Random positionY = new Random();
                int startPositionY = positionY.Next(1, size++);
                int shipLeight = 0;
                int[,] newShip = new int [1, 1];
                int[,] newBlockedPlace = new int[1, 1];

                if (numbCarrier>0)
                {
                    shipLeight = 1;
                    if (startPositionX + shipLeight > size)
                    {
                        break;
                    }
                    numbCarrier--;
                }
                else if (numbCruiser>0)
                {
                    shipLeight = 2;
                    if (startPositionX + shipLeight > size)
                    {
                        break;
                    }
                    numbCruiser--;
                }
                else if (numbBattleship>0)
                {
                    shipLeight = 3;                       
                    if (startPositionX + shipLeight > size)
                    {
                        break;
                    }
                    numbBattleship--;
                }
                else if (numbSubmarine>0)
                {
                    shipLeight = 4;
                    if (startPositionX + shipLeight > size)
                    {
                        break;
                    }
                    numbSubmarine--;
                }
                else if (numbDestroyer>0)
                {
                     shipLeight = 5;
                    if (startPositionX + shipLeight > size)
                    {
                        break;
                    }
                    numbDestroyer--;
                }

                if (chosenHorizontal == 1)
                {
                    int positionI = startPositionX;
                    int positionJ = startPositionY;
                    newShip = new int [shipLeight-1, 1];
                    newBlockedPlace = new int [shipLeight+shipLeight-1, 1]
                    int n = shipLeight;
                    int m = 0;
                    while (n>0)
                    {
                        n--;
                        newShip[m, 0] = positionI;
                        newShip[m, 1] = positionJ;
                        newBlockedPlace[m, 0] = positionI;
                        newBlockedPlace[m, 1] = positionJ + 1;
                        newBlockedPlace[m + m, 0] = positionI;
                        newBlockedPlace[m + m, 1] = positionJ - 1;
                        m++;

                    }
                }
                else
                {
                    int positionJ = startPositionX;
                    int positionI = startPositionY;
                    newShip = new int [1, shipLeight-1];
                    int n = shipLeight;
                    int m = 0;
                    while (n>0)
                    {
                        n--;
                        newShip[0, m] = positionI;
                        newShip[1, m] = positionJ;
                        newBlockedPlace[0, m] = positionI;
                        newBlockedPlace[1, m] = positionJ + 1;
                        newBlockedPlace[0, m + m] = positionI;
                        newBlockedPlace[1, m + m] = positionJ - 1;

                        m++;

                    }
                }

                listOfShips.Add(newShip);
                blocketPositions.Add((newBlockedPlace));



            }
            
            //throw new NotImplementedException();
        }

        public static Board ManualPlacement()
        {
            throw new NotImplementedException();
        }
    }
}