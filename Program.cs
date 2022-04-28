using System;

namespace cse210_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int rannum = randomGenerator.Next(1,1000);
            int start_num = -1;
            Console.WriteLine("Welcome to Tic Tac Toe");
        }
    }
}
    