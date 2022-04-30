//This is CSE 210-01 prove assignment by Chris Chau, Tic Tac Toe
using System;
namespace cse210_01
{
    public static class Program
    {
        public static char playerturn =' ';
        static int player = 1;
        static int input;
        static int whowins = 0;
        static char[] ArrBoard =
        {
            '1', '2', '3','4', '5', '6','7', '8', '9'
        }; 
        
        
        static void Main(string[] args)
        {
        Console.WriteLine("Welcome to Tic Tac Toe!");
        Console.WriteLine("Player1:X and Player2:O");
        while(whowins != 1 && whowins != -1)
            {
            Board();
            if (player ==1)
                {
                    Console.WriteLine("Player 1 turn");
                }
                else
                {
                    Console.WriteLine("Player 2 turn");
                }
            Console.Write("Please enter a number:");
            input = Convert.ToInt32(Console.ReadLine());
                Board();
                walk();
            whowins = Check();
            }
            if(whowins ==1)
            {
                Board();
                Console.WriteLine("Congrats Player 1!");
            }
            else if(whowins ==2)
            {
                Board();
                Console.WriteLine("Congrats Player 2!");
            }
            else
            {
                Board();
                Console.WriteLine("No one wins, that's a draw!");
            }
            Console.WriteLine("Great! thanks for playing!");
        }
        public static void Board()
        {   
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", ArrBoard[0], ArrBoard[1], ArrBoard[2]);
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", ArrBoard[3], ArrBoard[4], ArrBoard[5]);
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", ArrBoard[6], ArrBoard[7], ArrBoard[8]);
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
        } 
        public static void walk()
        {
            if (ArrBoard[input-1] != 'X' && ArrBoard[input-1] != 'O')
            {
                if(player == 2)
                {
                    ArrBoard[input-1] = 'O';
                    player--;
                }
                else
                {
                    ArrBoard[input-1] = 'X';
                    player++;
                }
                
            }
            else
            {
                Console.WriteLine("Sorry! Please pick another number.");
            }
        }
        public static int Check()
        {
            //Horizontal
            if (ArrBoard[0] == ArrBoard[1] && ArrBoard[1] == ArrBoard[2])
            {
                return 1;
            }
            else if (ArrBoard[3] == ArrBoard[4] && ArrBoard[4] == ArrBoard[5])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (ArrBoard[6] == ArrBoard[7] && ArrBoard[7] == ArrBoard[8])
            {
                return 1;
            }
            else if (ArrBoard[0] == ArrBoard[3] && ArrBoard[3] == ArrBoard[6])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (ArrBoard[1] == ArrBoard[4] && ArrBoard[4] == ArrBoard[7])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (ArrBoard[2] == ArrBoard[5] && ArrBoard[5] == ArrBoard[8])
            {
                return 1;
            }
            else if (ArrBoard[0] == ArrBoard[4] && ArrBoard[4] == ArrBoard[8])
            {
                return 1;
            }
            else if (ArrBoard[2] == ArrBoard[4] && ArrBoard[4] == ArrBoard[6])
            {
                return 1;
            }
            //Check Draw
            else if (ArrBoard[0] != '1' && ArrBoard[1] != '2' && ArrBoard[2] != '3' && ArrBoard[3] != '4' && ArrBoard[4] != '5' && ArrBoard[5] != '6' && ArrBoard[6] != '7' && ArrBoard[7] != '8' && ArrBoard[8] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    
    }

}

           
 