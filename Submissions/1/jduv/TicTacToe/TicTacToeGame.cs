namespace TicTacToe
{
    using System;

    /// <summary>
    /// Simple class implementing a basic two player command line tic tac toe game.
    /// </summary>
    public class TicTacToeGame : IGame
    {
        #region Fields & Constants

        private static readonly string Newline = System.Environment.NewLine;

        #endregion

        #region Public Methods

        /// <summary>
        /// Plays the game.
        /// </summary>
        public void Play()
        {
            int move;
            bool over = false;
            Move currentPlayer = Move.X;
            var board = new TicTacToeBoard();

            // Print a greeting.
            Console.WriteLine("xox Play Tic-Tac-Toe! xox" + Newline);

            // Keep going until the game is deemed "over"
            while (!over)
            {
                // Print the board.
                Console.WriteLine(board.ToString());
                Console.WriteLine("Player 1 => X, Player 2 => O");

                // Ask the player to enter a square number
                Console.Write("Enter Square [player " + PrintMove(currentPlayer) + "]: ");
                var playersMove = Console.ReadLine();
                Console.Write(Newline);

                // Process player's move
                if (int.TryParse(playersMove, out move))
                {
                    try
                    {
                        // Attempt to make the move, then change players.
                        board.MakeMove(move, currentPlayer);
                        currentPlayer = FlipCurrentPlayer(currentPlayer);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message + Newline);
                    }
                }
                else
                {
                    // Just in case someone doesn't give us an int.
                    Console.WriteLine("Unable to parse your move, please try again." + Newline);
                }

                //  A little magic here. If the board has a winner set then we're done.
                if (board.Winner != null)
                {
                    this.PrintEndGame(board);
                    over = true;
                }
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Prints out a move.
        /// </summary>
        /// <param name="move">
        /// The move to print.
        /// </param>
        /// <returns>
        /// Prints the symbol for the move.
        /// </returns>
        private string PrintMove(Move move)
        {
            return move == Move.X ? "X" : "O";
        }

        /// <summary>
        /// Swaps X's to O's and O's to X's. Allows for alternating moves.
        /// </summary>
        /// <param name="currentPlayer">
        /// The current move to be made by a player. X or O.
        /// </param>
        /// <returns>
        /// If X, then O. If O, then X.
        /// </returns>
        private Move FlipCurrentPlayer(Move currentPlayer)
        {
            return currentPlayer == Move.X ? Move.O : Move.X;
        }

        /// <summary>
        /// Prints the end game.
        /// </summary>
        /// <param name="board">
        /// The board to print.
        /// </param>
        private void PrintEndGame(TicTacToeBoard board) {
            switch(board.Winner.Value) {
                case Move.X:
                case Move.O:
                    Console.WriteLine("Congratulations, we have a winner: " + PrintMove(board.Winner.Value) + "!" + Newline);
                    break;
                case Move.Undefined:
                    Console.WriteLine("And we have a tie!" + Newline);
                    break;
            }

            Console.WriteLine(board.ToString() + Newline);
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        #endregion
    }
}
