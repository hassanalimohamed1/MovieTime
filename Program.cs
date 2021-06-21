using System;
using static System.Console;
namespace MoiveTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMoveTime("Matrix", 113);
            DisplayMoveTime("300");


        }

        static void DisplayMoveTime(string mov, int min = 90) {

            WriteLine($"The moive is {mov} is {min} minutes long.");
        }

    }
}
