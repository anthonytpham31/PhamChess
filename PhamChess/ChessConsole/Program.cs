using PhamChess;
using System;

namespace ChessConsole
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var repeat = true;
            while (repeat)
            {
                var coordString = Console.ReadLine()?.ToUpper();
                var coordEnum = (GameCoordinate)Enum.Parse(typeof(GameCoordinate), coordString, false);
                var testValue = coordEnum;
                var test = new ChessMovements(testValue);
                Console.WriteLine("Initial Value: " + (int)testValue);

                var list = test.GetDiagonalCoordinates();
                foreach (var coordinate in list)
                {
                    Console.WriteLine(coordinate);
                }
                repeat = AskToDoAgain();
            }

        }

        private static bool AskToDoAgain()
        {
            Console.WriteLine("Press Enter or Y to Test Again.");
            var repeatInput = Console.ReadLine()?.ToLower();
            Console.Clear();
            return repeatInput == "y" || repeatInput == "";
        }
    }
}
