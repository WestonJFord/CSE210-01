using System;

namespace TicTacToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Dictionary<int, string> board =
                new Dictionary<int, string>();
            
            
            string player_move = Console.ReadLine();
            Console.WriteLine(player_move);
        }

        public static void DrawTable()
        {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}")
        }
    }
}