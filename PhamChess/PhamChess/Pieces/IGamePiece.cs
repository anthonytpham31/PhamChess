using System.Collections.Generic;

namespace PhamChess.Pieces
{
    public interface IGamePiece
    {
        GameCoordinate StartingCoordinate { get; set; }
        GameSpace CurrentSpace { get; set; }
        bool IsPieceStillStanding { get; set; }
        bool IsPieceWhite { get; set; }
        List<GameCoordinate> GetLegalMoves();
    }
}
