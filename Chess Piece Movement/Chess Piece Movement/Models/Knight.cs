﻿using Chess_Piece_Movement.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Piece_Movement.Models
{
    public class Knight : ChessPiece
    {

        public Knight(PieceColor color) : base(color, Pieces.Knight)
        {

        }

        public List<int[]> GetMoves(int oCol, int oRow)
        {
            List<int[]> possibleMovements = new List<int[]>()
            {

                new int[] { oCol + 1,  oRow + 2},
                new int[] { oCol - 1,  oRow + 2},
                new int[] { oCol - 2,  oRow - 1},
                new int[] { oCol - 2,  oRow + 1},
                new int[] { oCol + 1,  oRow - 2},
                new int[] { oCol - 1,  oRow - 2},
                new int[] { oCol + 2,  oRow - 1},
                new int[] { oCol + 2,  oRow + 1},

            };

            for (int i = 0; i < possibleMovements.Count; i++)
            {
                if (possibleMovements[i][0] < 0 && possibleMovements[i][0] > 7)
                {
                    possibleMovements.RemoveAt(i);
                }
                else if (possibleMovements[i][1] < 0 && possibleMovements[i][1] > 7)
                {
                    possibleMovements.RemoveAt(i);
                }
            }

            return possibleMovements;


        }

    }
}
