using PhamChess.Pieces;

namespace PhamChess
{
    public class GameSpace
    {
        // TODO: This class needs work. Figure out Pieces first.
        public bool IsSpaceOccupied { get; set; }
        public GameCoordinate Coordinate { get; set; }

        public GameSpace()
        {
            IsSpaceOccupied = false;
        }

        public GameSpace(IGamePiece piece)
        {
            IsSpaceOccupied = true;

        }
    }
}
