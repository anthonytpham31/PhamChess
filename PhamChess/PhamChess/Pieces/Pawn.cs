using System;
using System.Collections.Generic;

namespace PhamChess.Pieces
{
    public class Pawn : IGamePiece
    {
        public GameCoordinate StartingCoordinate { get; set; }
        public GameSpace CurrentSpace { get; set; }
        public bool IsPieceStillStanding { get; set; }
        public bool IsPieceWhite { get; set; }

        public Pawn(GameCoordinate startingCoordinate)
        {
            StartingCoordinate = startingCoordinate;
        }

        public Pawn(GameSpace userMove)
        {
            CurrentSpace = userMove;
        }

        public List<GameCoordinate> GetLegalMoves()
        {
            throw new NotImplementedException();
        }

        private void PawnMovement()
        {

        }
    }
}
