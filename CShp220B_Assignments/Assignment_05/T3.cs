using System;
using System.Windows.Controls;

namespace Assignment_05
{
    enum GameStatus { GameStatus_Draw, GameStatus_XWin, GameStatus_OWin, GameStatus_X_Trun, GameStatus_O_Trun };
    class T3
    {
        const char OPEN_TILE = ' ';
        const char X = 'X';
        const char O = 'O';
        int MAX_MOVES;
        char[,] data;
        int moveCount = 0;
        int rowSize = 0;
        int colSize = 0;
        bool playerXTurn = true;
        bool gameOver = false;
        GameStatus currentStatus = GameStatus.GameStatus_X_Trun;

        public T3(int row = 3, int col = 3)
        {
            rowSize = row;
            colSize = col;
            MAX_MOVES = row * col;
            moveCount = 0;
            playerXTurn = true;
            gameOver = false;

            data = new char[row, col];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    data[i, j] = OPEN_TILE;
        }

        private void SplitIndex(string index, out int row, out int col)
        {
            var parts = index.Split(',');
            if (parts.Length != 2)
                throw new ArgumentException("The provided index is not valid");

            row = int.Parse(parts[0]);
            col = int.Parse(parts[1]);
        }

        public char this[string index]
        {
            get
            {
                int row, col;
                SplitIndex(index, out row, out col);
                return data[row, col];
            }
            set
            {
                int row, col;
                SplitIndex(index, out row, out col);
                if (data[row, col] == OPEN_TILE)
                {
                    data[row, col] = value ;
                }
            }
        }

        public char this[int row, int col]
        {
            get { return data[row, col]; }
            set
            {
                if (data[row, col] == OPEN_TILE)
                {
                    data[row, col] = value;
                }
            }
        }

        bool IsWinner (string index, char playerMark)
        {
            int row, col;
            SplitIndex(index, out row, out col);
            for (int c = 0; c < colSize; c++)
            {
                if (this[row, c] != playerMark)
                    return false;
            }
            return true;
        }

        public GameStatus MakeA_Move(string index, Button tile)
        {
            char playerMark = playerXTurn ? X : O;

            if (moveCount++ < MAX_MOVES)
            {
                tile.Content = playerMark;
                this[index] = playerMark;
                if (IsWinner(index, playerMark))
                {
                    gameOver = true;
                    return playerXTurn ? GameStatus.GameStatus_XWin : GameStatus.GameStatus_OWin;
                }
            }

            if (moveCount >= MAX_MOVES)
            {
                gameOver = true;
                return GameStatus.GameStatus_Draw;
            }

            playerXTurn = !playerXTurn;
            return playerXTurn ? GameStatus.GameStatus_X_Trun : GameStatus.GameStatus_O_Trun;
        }

        public bool IsGameOver()
        {
            return gameOver;
        }

        public GameStatus GetGameStatus()
        {
            return currentStatus;
        }
    }
}
