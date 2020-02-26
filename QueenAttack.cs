using System;
// using System.Collections.Generic;

namespace ChessBoard.Pieces
{
  public class Piece
  {
    private int _x;
    private int _y;
    public Piece( int x, int y)
    {
      _x = x;
      _y = y;
    }
    public int GetX()
    {
      return _x;
    }
    public int GetY()
    {
      return _y;
    }
    public void SetXCord(int newXCord)
    {
      _x = newXCord;
    }
    public void SetYCord(int newYCord)
    {
      _y = newYCord;
    }

        public static void Question()
    {
        Console.WriteLine("Please enter the X coordinate of the Queen");
        string stringQueenXCord = Console.ReadLine();
        int queenXCord = int.Parse(stringQueenXCord);
        Console.WriteLine("Please enter the Y coordinate of the Queen");
        string stringQueenYCord = Console.ReadLine();
        int queenYCord = int.Parse(stringQueenYCord);

        Console.WriteLine("Please enter the X coordinate of the Pawn");
        string stringPawnXCord = Console.ReadLine();
        int pawnXCord = int.Parse(stringPawnXCord);

        Console.WriteLine("Please enter the Y coordinate of the Pawn");
        string stringPawnYCord = Console.ReadLine();
        int pawnYCord = int.Parse(stringPawnYCord);

        Piece userQueen = new Piece(0, 0);
        userQueen.SetXCord(queenXCord);
        userQueen.SetYCord(queenYCord);
        Console.WriteLine(userQueen.GetX());
        Console.WriteLine(userQueen.GetY());

        Piece userPawn = new Piece(0, 0);
        userPawn.SetXCord(pawnXCord);
        userPawn.SetYCord(pawnYCord);
        Console.WriteLine(userPawn.GetX());
        Console.WriteLine(userPawn.GetY());

        if (queenXCord == pawnXCord || queenYCord == pawnYCord)
        {
            Console.WriteLine("Hit on vertical or horizontal movement");
        }
        else if ((Math.Abs(queenXCord - pawnXCord)) == (Math.Abs(queenYCord - pawnYCord)))
        {
            Console.WriteLine("Hit on diagonal movement");
        }
    }
    }
  }