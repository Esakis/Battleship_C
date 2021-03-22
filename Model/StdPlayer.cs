using System;
using Battleship.Model.Enums;

namespace Battleship.Model
{
    public class StdPlayer : Player
    {
        public StdPlayer(ConsoleColor color, PlayerNumber number, int boardSize) : base(color, number, boardSize)
        {
        }

        public override void Move(Board opponentBoard, Player player1, Player player2, Player currentPlayer)
        {
            bool accepted = false;
            while(!accepted)
            {
                Move move = Input.GetMove();
                switch (move)
                {
                    case Enums.Move.Up:
                        if (opponentBoard.SelectedField.Y > 0)
                        {
                            MoveUp(opponentBoard);
                        }

                        break;
                    case Enums.Move.Right:
                        if (opponentBoard.SelectedField.X < opponentBoard.Size - 1)
                        {
                            MoveRight(opponentBoard);
                        }

                        break;
                    case Enums.Move.Down:
                        if (opponentBoard.SelectedField.Y < opponentBoard.Size - 1)
                        {
                            MoveDown(opponentBoard);
                        }

                        break;
                    case Enums.Move.Left:
                        if (opponentBoard.SelectedField.X > 0)
                        {
                            MoveLeft(opponentBoard);
                        }

                        break;
                    case Enums.Move.Accept:
                        accepted = true;
                        break;
                }
                Display.TwoBoardHorizontally(player1, player2, currentPlayer);
            }
            opponentBoard.CheckField();
            Display.TwoBoardHorizontally(player1, player2, currentPlayer);
        }

        private void MoveLeft(Board opponentBoard)
        {
            Point2D selectedField = opponentBoard.SelectedField;
            selectedField.X--;
            opponentBoard.SelectedField = selectedField;
        }

        private void MoveDown(Board opponentBoard)
        {
            Point2D selectedField = opponentBoard.SelectedField;
            selectedField.Y++;
            opponentBoard.SelectedField = selectedField;
        }

        private void MoveRight(Board opponentBoard)
        {
            Point2D selectedField = opponentBoard.SelectedField;
            selectedField.X++;
            opponentBoard.SelectedField = selectedField;
        }

        private void MoveUp(Board opponentBoard)
        {
            Point2D selectedField = opponentBoard.SelectedField;
            selectedField.Y--;
            opponentBoard.SelectedField = selectedField;
        }
    }
}