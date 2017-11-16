using System;
using System.Collections.Generic;
using System.Linq;

namespace PhamChess
{
    public class ChessMovements
    {
        #region Properties

        private readonly List<string> _letters = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H" };
        private readonly List<string> _numbers = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8" };
        private readonly List<int> _upperBound = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        private readonly List<int> _leftBound = new List<int> { 9, 17, 25, 33, 41, 49 };
        private readonly List<int> _rightBound = new List<int> { 16, 24, 32, 40, 48, 56 };
        private readonly List<int> _lowerBound = new List<int> { 57, 58, 59, 60, 61, 62, 63, 64 };
        private readonly GameCoordinate _initCoordinate;
        private readonly int _initValue;
        private readonly string _initLetter;
        private readonly string _initNumber;

        public ChessMovements(GameCoordinate initCoordinate)
        {
            _initCoordinate = initCoordinate;
            var coordinate = initCoordinate.ToString();
            _initLetter = coordinate[0].ToString();
            _initNumber = coordinate[1].ToString();
            _initValue = (int)initCoordinate;
        }
        #endregion

        #region Public Methods

        public List<GameCoordinate> GetRowCoordinates()
        {
            return _letters
                .Select(letter => letter + _initNumber)
                .Select(ConvertStringToGameCoordinate)
                .Where(newCoordinate => newCoordinate != _initCoordinate)
                .ToList();
        }

        public List<GameCoordinate> GetColumnCoordinates()
        {
            return _numbers
                .Select(number => _initLetter + number)
                .Select(ConvertStringToGameCoordinate)
                .Where(newCoordinate => newCoordinate != _initCoordinate)
                .ToList();
        }

        public List<GameCoordinate> GetDiagonalCoordinates()
        {
            var diagIntValues = GetDiagIntValues();
            return diagIntValues
                .Select(intValue => (GameCoordinate)intValue)
                .ToList();
        }

        public List<GameCoordinate> GetKingCoordinates()
        {
            return new List<GameCoordinate>();
        }

        public List<GameCoordinate> GetKnightCoordinates()
        {
            return new List<GameCoordinate>();
        }
        #endregion

        #region Private Helper Methods

        private static GameCoordinate ConvertStringToGameCoordinate(string coordinate)
        {
            return (GameCoordinate)Enum.Parse(typeof(GameCoordinate), coordinate, false);
        }

        private bool UpperLeftBoundCheck(int newValue)
        {
            return _upperBound.All(bound => bound != newValue) &&
                   _leftBound.All(bound => bound != newValue);
        }

        private bool UpperRightBoundCheck(int newValue)
        {
            return _upperBound.All(bound => bound != newValue) &&
                   _rightBound.All(bound => bound != newValue);
        }

        private bool LowerLeftBoundCheck(int newValue)
        {
            return _lowerBound.All(bound => bound != newValue) &&
                   _leftBound.All(bound => bound != newValue);
        }

        private bool LowerRightBoundCheck(int newValue)
        {
            return _lowerBound.All(bound => bound != newValue) &&
                   _rightBound.All(bound => bound != newValue);
        }
        #endregion

        #region Diagonal Methods

        // Orientation is based on GameCoordinate Enums
        private IEnumerable<int> GetDiagIntValues()
        {
            var rangeOfBoard = GetUpperLeftValues()
                               .Concat(GetUpperRightValues())
                               .Concat(GetLowerLeftValues())
                               .Concat(GetLowerRightValues());

            return rangeOfBoard;

        }

        private IEnumerable<int> GetUpperLeftValues()
        {
            var newListValue = new List<int>();
            var newValue = _initValue;

            while (newValue > 0 && UpperLeftBoundCheck(newValue))
            {
                newValue = newValue - 9;
                if (newValue <= 0) continue;
                newListValue.Add(newValue);
            }

            return newListValue;
        }

        private IEnumerable<int> GetUpperRightValues()
        {
            var newListValue = new List<int>();
            var newValue = _initValue;

            while (newValue > 0 && UpperRightBoundCheck(newValue))
            {
                newValue = newValue - 7;
                if (newValue <= 0) continue;
                newListValue.Add(newValue);
            }

            return newListValue;
        }

        private IEnumerable<int> GetLowerLeftValues()
        {
            var newListValue = new List<int>();
            var newValue = _initValue;

            while (newValue < 65 && LowerLeftBoundCheck(newValue))
            {
                newValue = newValue + 7;
                if (newValue > 64) continue;
                newListValue.Add(newValue);
            }

            return newListValue;
        }

        private IEnumerable<int> GetLowerRightValues()
        {
            var newListValue = new List<int>();
            var newValue = _initValue;

            while (newValue < 65 && LowerRightBoundCheck(newValue))
            {
                newValue = newValue + 9;
                if (newValue > 64) continue;
                newListValue.Add(newValue);
            }

            return newListValue;
        }
        #endregion

        #region King Methods



        #endregion

        #region KnightMethods



        #endregion
    }
}
