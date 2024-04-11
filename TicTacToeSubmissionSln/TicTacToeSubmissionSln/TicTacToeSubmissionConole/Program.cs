using System;

namespace TicTacToeSubmissionConole
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;

            Console.SetCursorPosition(10, 2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Lets play Tic Tac Toe");

            var ticTacToe = new TicTacToe();

            ticTacToe.Run();
            while (true)
            {
                ticTacToe.playerX();
                ticTacToe.playerO();
                ticTacToe.playerX();
                ticTacToe.playerO();
                ticTacToe.playerX();
                ticTacToe.playerO();

                ticTacToe.coordinateWin();
                ticTacToe.coordinateWin();

                Console.ForegroundColor = oldColor;


                Console.SetCursorPosition(20, 25);
                Console.WriteLine("Hope you enjoyed playing tic tac toe");
                Console.ReadLine();
            }
        }
    }
}
