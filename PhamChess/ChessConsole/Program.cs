using PhamChess;
using PhamChess.Helpers;
using System;

namespace ChessConsole
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var test = new ChessHelpers();
            var list = test.GetColumnCoordinates(GameCoordinate.C2);
            foreach (var coordinate in list)
            {
                Console.WriteLine(coordinate);
            }
            Console.ReadLine();
        }
    }
}
