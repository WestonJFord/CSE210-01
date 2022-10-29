using System;

namespace TicTacToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Dictionary<int, string> board = new Dictionary<int, string>();
            Console.WriteLine("1,1 | 2,1 | 3,1\n1,2 | 2,2 | 3,2\n1,3 | 2,3 | 3,3");
            Console.WriteLine("Your move: ");
            string player_move = Console.ReadLine();
            Console.WriteLine(player_move);
        }

        public static void DrawTable()
        {
            Console.WriteLine("")
        }
    }
}