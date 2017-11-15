using System;
using System.Collections.Generic;
using System.Linq;

namespace PhamChess.Helpers
{
    public class ChessHelpers
    {
        private readonly List<string> _letters = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H" };
        private readonly List<string> _numbers = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8" };

        public List<GameCoordinate> GetRowCoordinates(GameCoordinate initCoordinate)
        {
            var coordinate = initCoordinate.ToString();

            return _letters
                .Select(letter => letter + coordinate[1])
                .Select(combineChars => (GameCoordinate)Enum.Parse(typeof(GameCoordinate), combineChars, false))
                .Where(newCoord => newCoord != initCoordinate)
                .ToList();
        }

        public List<GameCoordinate> GetColumnCoordinates(GameCoordinate initCoordinate)
        {
            var coordinate = initCoordinate.ToString();

            return _numbers
                .Select(number => coordinate[0] + number)
                .Select(combineChars => (GameCoordinate)Enum.Parse(typeof(GameCoordinate), combineChars, false))
                .Where(newCoord => newCoord != initCoordinate)
                .ToList();
        }

        public List<GameCoordinate> GetDiagonalCoordinates(GameCoordinate initCoordinate)
        {
            return new List<GameCoordinate>();
        }
    }
}
