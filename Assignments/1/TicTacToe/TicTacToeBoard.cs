namespace TicTacToe
{
    using System;

    /// <summary>
    /// Enum for representing the kinds of moves players can make.
    /// </summary>
    public enum Move
    {
        /// <summary>
        /// The X
        /// </summary>
        X,
        /// <summary>
        /// The O
        /// </summary>
        O,
        /// <summary>
        /// Represents a space where a move hasn't been made yet.
        /// </summary>
        Undefined
    }

    /// <summary>
    /// Represents a Tic-Tac-Toe board. A board is a simple 3x3 grid.
    /// </summary>
    public sealed class TicTacToeBoard
    {
        #region Fields & Constants

        private static readonly int[,] PossibleWins = new int[,] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, {0, 3, 6}, {1, 4, 7}, {2, 5, 8}, { 0, 4, 8 }, { 2, 4, 6 } };
        private Move[] moves = new Move[9];
        private Move? winner = null;

        #endregion

        #region Constructor & Destructors

        public TicTacToeBoard()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the current winner, if available.
        /// </summary>
        public Move? Winner
        {
            get
            {
                return this.winner;
            }
        }

        /// <summary>
        /// Gets a value indicating whether we have moves left.
        /// </summary>
        public bool HasMoves
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Sets the target row and column in the board to the passed in move.
        /// </summary>
        /// <param name="slot">
        /// The slot to place the move in.
        /// </param>
        /// <param name="move">
        /// The move to make. X or O.
        /// </param>
        public void MakeMove(int slot, Move move)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prints a string representation of this board.
        /// </summary>
        /// <returns>
        /// A string representation of this board.
        /// </returns>
        public override string ToString()
        {
            string board = "";
            for (int i = 1; i <= moves.Length; i++)
            {
                board += " | ";
                switch (moves[i - 1])
                {
                    case Move.X:
                        board += "X";
                        break;
                    case Move.O:
                        board += "O";
                        break;
                    case Move.Undefined:
                        board += i;
                        break;
                }

                if (i % 3 == 0)
                {
                    board += " | " + System.Environment.NewLine;
                }
            }
            return board;
        }
        #endregion

        #region Private Methods

        /// <summary>
        /// Checks to see if someone has won the game.
        /// </summary>
        /// <returns>
        /// The move that won the game, null if no one has won yet, or Move.Undefined if the 
        /// game is a tie.
        /// </returns>
        private Move? CheckForWinner()
        {
            Move? winner = null;
            for (int i = 0; i < PossibleWins.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < PossibleWins.GetLength(1); j++)
                {
                    var currentMove = this.moves[PossibleWins[i,j]];
                    sum += GetWeightForMove(currentMove);
                }

                if (sum == 3)
                {
                    winner = Move.X;
                }
                else if (sum == -3)
                {
                    winner = Move.O;
                }
                else if (!this.HasMoves)
                {
                    winner = Move.Undefined;
                }

                // Bounce if the winner has been set.
                if (winner != null)
                {
                    break;
                }
            }

            return winner;
        }

        /// <summary>
        /// Assigns arbitrary weights to a move. Used for computing a winner.
        /// </summary>
        /// <param name="move">
        /// The move whose weight to get.
        /// </param>
        /// <returns>
        /// An integer value weight for the move.
        /// </returns>
        private int GetWeightForMove(Move move) 
        {
            int value = 0;
            switch(move) 
            {
                case Move.X:
                    value = 1;
                    break;
                case Move.O:
                    value = -1;
                    break;
                case Move.Undefined:
                    value = 0;
                    break;
            }
            return value;
        }

        #endregion
    }
}
