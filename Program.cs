using System;

namespace TicTacToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            
            Dictionary<int,String> board = NewBoard();
            DrawBoard(board);
            
            while win = false
            (
                DrawBoard(board)

                
            )
            
            string player_move = Console.ReadLine();
            Console.WriteLine(player_move);
        }

        static Dictionary<int, string> NewBoard()
        {
            Dictionary<int, string> board = new Dictionary<int, string>();
            
            for (int i = 1; i <= 9; i++)
            {
                board.Add(i,i.ToString());
            }

            return board;
        }

        static void DrawBoard(Dictionary<string,string> board)
        {
            string line = "-+-+-";

            Console.WriteLine($"{board["1,1"]}|{board["2,1"]}|{board["3,1"]}");
            Console.WriteLine(line);
            Console.WriteLine($"{board["1,2"]}|{board["2,2"]}|{board["3,2"]}");
            Console.WriteLine(line);
            Console.WriteLine($"{board["1,3"]}|{board["2,3"]}|{board["3,3"]}");
        }
    }
}