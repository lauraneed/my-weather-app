using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        public int choice;
        static int playerX = 1;
       // public int choice;
        static int playerO = 1;
        public static object arr;
        public string[] row = new string[9] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10,6);
            _boardRenderer.Render();
           
        }


        public void Run()
        {

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

            Console.SetCursorPosition(2, 19);

            Console.Write("Player X");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(2, 20);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);


            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();

            Console.Write("Please Enter Row: ");
           // var row = Console.ReadLine();





            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);

        }


            public bool coordinateWin()
            {
                for (int x = 1; x < playerX; ++x)
                {

                }

                Console.WriteLine("\n");

                if (playerO % 1 == 0)

                {

                    Console.WriteLine("player1 Chance");

                }

                else

                {

                    Console.WriteLine("player2 Chance");

                }
                Console.WriteLine("\n");
                if (row[0] == "O" && row[1] == "O" && row[2] == "O")
                {
                    return true;
                }
                else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
                {
                    return true;
                }
                else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
                {
                    return true;
                }
                else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
                {
                    return true;
                }
                else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
                {
                    return true;
                }
                else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
                {
                    return true;
                }
                else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
                {
                    return true;
                }
                else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
                {
                    return true;
                }

                if (row[0] == "X" && row[1] == "X" && row[2] == "X")
                {
                    return true;
                }
                else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
                {
                    return true;
                }
                else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
                {
                    return true;
                }
                else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
                {
                    return true;
                }
                else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
                {
                    return true;
                }
                else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
                {
                    return true;
                }
                else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
                {
                    return true;
                }
                else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
                {

                }
                return true;
            }


    }
}
