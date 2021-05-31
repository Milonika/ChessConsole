//Gainutdinova Alina 221-p
//Chess 3
using System;

class Program
{
    static void Main()
    {
        Figure[] Chessboard = new Figure[5];

        Chessboard[0] = new Rook(3, 4);
        Chessboard[1] = new Bishop(2, 1);
        Chessboard[2] = new King(4, 2);
        Chessboard[3] = new Queen(1, 3);
        Chessboard[4] = new Knight(1, 4);

        foreach (var figure in Chessboard)
        {
            if (figure.MakeMove(3, 5))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }

    }
}

class Figure
{
    public int X;
    public int Y;

    public Figure(int x, int y)
    {
        X = x;
        Y = y;
    }

    public virtual bool MakeMove(int newX, int newY)
    {
        return false;
    }
}

class Rook : Figure//Ладья
{
    public Rook(int x, int y) : base(x, y)
    {
    }

    public override bool MakeMove(int newX, int newY)
    {
        if ((X == newX) || (Y == newY))
        {
            X = newX;
            Y = newY;
            return true;
        }
        else
            return false;
    }
}

class Bishop : Figure//Слон
{
    public Bishop(int x, int y) : base(x, y)
    {
    }
    public override bool MakeMove(int newX, int newY)
    {
        if (Math.Abs(X - newX) == Math.Abs(Y - newY))
        {
            X = newX;
            Y = newY;
            return true;
        }
        else
            return false;
    }
}

class King : Figure//Король
{
    public King(int x, int y) : base(x, y)
    {
    }
    public override bool MakeMove(int newX, int newY)
    {
        if (Math.Abs(X - newX) <= 1 && Math.Abs(Y - newY) <= 1)
        {
            X = newX;
            Y = newY;
            return true;
        }
        else
            return false;
    }
}

class Queen : Figure//Ферзь
{
    public Queen(int x, int y) : base(x, y)
    {
    }
    public override bool MakeMove(int newX, int newY)
    {
        if (((X == newX) || (Y == newY)) || (Math.Abs(X - newX) == Math.Abs(Y - newY)))
        {
            X = newX;
            Y = newY;
            return true;
        }
        else
            return false;
    }
}

class Knight : Figure//Конь
{
    public Knight(int x, int y) : base(x, y)
    {
    }
    public override bool MakeMove(int newX, int newY)
    {
        if ((Math.Abs(X - newX) == 2 && Math.Abs(Y - newY) == 1 || Math.Abs(X - newX) == 1 && Math.Abs(Y - newY) == 2))
        {
            X = newX;
            Y = newY;
            return true;
        }
        else
            return false;
    }
}