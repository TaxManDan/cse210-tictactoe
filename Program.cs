﻿class TicTacToe
{
    static void Main(string[] args)
    {

        List<string> board = GetNewBoard();
        string currentPlayer = "x";

        while (!IsGameOver(board))
        {
            DisplayBoard(board);

            int choice = GetMoveChoice(currentPlayer);
            MakeMove(board, choice, currentPlayer);

            currentPlayer = GetNextPlayer(currentPlayer);
        }

        DisplayBoard(board);
        Console.WriteLine("Good game. Thanks for playing!");
    }

    /// <summary>Gets a new instance of the board with the numbers 1-9 in place. </summary>
    /// <returns>A list of 9 strings representing each square.</returns>
    static List<string> GetNewBoard()
    {
        string[] numbers ={"1","2","3","4","5","6","7","8","9"};
        List<string> board = new List<string>(numbers);
        return board;
    }

    /// <summary>Displays the board in a 3x3 grid.</summary>
    /// <param name="board">The board</param>
    static void DisplayBoard(List<string> board)
    {
        Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");


    }

    /// <summary>
    /// Determines if the game is over because of a win or a tie.
    /// </summary>
    /// <param name="board">The current board.</param>
    /// <returns>True if the game is over</returns>
    static bool IsGameOver(List<string> board)
    {
        
        if(IsWinner(board,"x")||IsWinner(board,"o") || IsTie(board))
            {
                return true;
            }
        return false;
                
    }

    /// <summary>Determines if the provided player has a tic tac toe.</summary>
    /// <param name="board">The current board</param>
    /// <param name="player">The player to check for a win</param>
    /// <returns></returns>
    static bool IsWinner(List<string> board, string player)
    {
        int h = 0;
        int x = 0;
        int y = 1;
        int z = 2;
        while (h <3){
            if(player == board[x] & player == board[y] && player == board[z])
        {
                return true;
        }
        x += 3; y += 3; z += 3; h ++;
        }

        int v = 0;
        x = 0; y = 3; z = 6;
        while (v <3){
            if(player == board[x] & player == board[y] & player == board[z])
        {
                return true;
        }
        x ++; y ++; z ++; v ++;
        }

        if(player == board[2] & player == board[4] & player == board[6])
        {
            return true;
        }
        if(player == board[0] & player == board[4] & player == board[8])
        {
            return true;
        }
        
        return false;
    }

    /// <summary>Determines if the board is full with no more moves possible.</summary>
    /// <param name="board">The current board.</param>
    /// <returns>True if the board is full.</returns>
    static bool IsTie(List<string> board)
    {
        if(board[0] == "1" || board[1] == "2" || board[2] == "3" || board[3] == "4" || board[4] == "5" || board[5] == "6" || board[6] == "7" ||board[7] == "8" ||board[8] == "9"){
            return false;
        }
        return true;
    }

    /// <summary>Cycles through the players (from x to o and o to x)</summary>
    /// <param name="currentPlayer">The current players sign (x or o)</param>
    /// <returns>The next players sign (x or o)</returns>
    static string GetNextPlayer(string currentPlayer)
    {
        if( currentPlayer == "o"){
            return "x";
        }
        return "o";
    }

    /// <summary>Gets the 1-based spot number associated with the user's choice.</summary>
    /// <param name="currentPlayer">The sign (x or o) of the current player.</param>
    /// <returns>A 1-based spot number (not a 0-based index)</returns>
    static int GetMoveChoice(string currentPlayer)
    {
        Console.WriteLine($"{currentPlayer}'s turn: ");
        while (true)
        {
            string choice ="";
        choice = Console.ReadLine();
        if (choice == "1")
        {
            return 1;
        }
        if (choice == "2")
        {
            return 2;
        }
        if (choice == "3")
        {
            return 3;
        }
        if (choice == "4")
        {
            return 4;
        }
        if (choice == "5")
        {
            return 5;
        }
        if (choice == "6")
        {
            return 6;
        }
        if (choice == "7")
        {
            return 7;
        }
        if (choice == "8")
        {
            return 8;
        }
        if (choice == "9")
        {
            return 9;
        }
        }
        
    }

    /// <summary>
    /// Places the current players mark on the board at the desired spot.
    /// This method does NOT check to ensure the spot is available.
    /// </summary>
    /// <param name="board">The current board</param>
    /// <param name="choice">The 1-based spot number (not a 0-based index).</param>
    /// <param name="currentPlayer">The current player's sign (x or o)</param>
    static void MakeMove(List<string> board, int choice, string currentPlayer)
    {
        choice= choice-1;
        board[choice] = currentPlayer;
    }
}

