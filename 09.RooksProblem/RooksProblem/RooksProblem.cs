using System;

namespace RooksProblem
{
    class RooksProblem
    {
        static char[,] chessBoard;

        static void PositioningTheRook(char[,] startPosition, int row, int col)
        {
            for (int i = row; i < chessBoard.GetLength(0); i++)
            {
                for (int k = col; k < chessBoard.GetLength(1); k++)
                {
                    startPosition[i, k] = 'f';
                    MarkFreeSpaces(i, k);
                    PositioningTheRook(startPosition, row + 1, col + 1);
                }
            }

        }
        static void MarkFreeSpaces(int row, int col)
        {
            if ((row < 0) || (col < 0) || chessBoard.GetLength(0) > 0 || chessBoard.GetLength(1) > 0)
            {
                return;
            }
           
                chessBoard[row, col] = 's';
                MarkFreeSpaces(row, col + 1);
                MarkFreeSpaces(row + 1, col);
                MarkFreeSpaces(row - 1, col);
                MarkFreeSpaces(row, col - 1);

            chessBoard[row, col] = ' ';
            



        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rooks you want to place: ");
            int rooksNumber = int.Parse(Console.ReadLine());
            chessBoard = new char[rooksNumber, rooksNumber];
            PositioningTheRook(chessBoard, 0, 0);

        }
    }
}
