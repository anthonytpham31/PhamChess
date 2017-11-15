using System;
using System.Collections.Generic;

namespace PhamChess.Pieces
{
    public class Bishop : IGamePiece
    {
        public GameCoordinate StartingCoordinate { get; set; }
        public GameSpace CurrentSpace { get; set; }
        public bool IsPieceStillStanding { get; set; }
        public bool IsPieceWhite { get; set; }
        public List<GameCoordinate> GetLegalMoves()
        {
            throw new NotImplementedException();
        }
    }
}
