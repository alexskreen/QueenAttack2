using System;
// using System.Collections.Generic;

public class QueenAttack
{
    public static void Main()
    {

Question();

    void Question()
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