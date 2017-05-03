#region Prologue
// Project Prolog
// Name: Spencer Carter
// CS 1030 X01
// Project: MilesPerGallon
// Date: 02/04/15
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
#endregion Prologue
using System;
namespace MilesPerGallon
{
    static class Program
    {

        /// <summary>
        /// Purpose: Entry point to this C# program
        /// </summary>
        static void Main()
        {
#region PsudoCode
/*
 * 1.0) Explicitly prompt the user to input value (Miles)
 * 2.0) Read the user input value
 * 2.1) Convert the string into double
 * 3.0) Explicitly prompt the user to input value (Gallons)
 * 4.0) Read the input value
 * 4.1) Convert the string into a double
 * 5.0) Do some math mgp = miles / gallons
 * 6.0) Output the mpg to the user
 * 7.0) Prompt user to press the enter key to close
 * 7.1) Read the key press, and close the program
*/
#endregion PsudoCode
            #region Variables
            double milesTrav = 0.0;
            double gallonsCons = 0.0;
            double mpg = 0.0;
            #endregion Variables
            Console.Write("Please enter the miles travled: "); // 1) prompt for miles
            double.TryParse(Console.ReadLine(), out milesTrav); // 2) convert and store miles
            Console.Write("Please enter the gallons consumed: "); // 3) prompt for gallones
            double.TryParse(Console.ReadLine(), out gallonsCons); // 4) convert and store gallons
            mpg = milesTrav / gallonsCons; // 5) basic math to get mpg
            Console.WriteLine("Thanks, You got {0:f2} MPG this trip", mpg); // 6) output mpg with 2 decimal places
            Console.Write("Press Enter to Close ... "); // 7) waits for user to close the program
            Console.ReadLine(); // 7.1) reads the enter
        }//End Main()
    }//End class Program
}//End namespace MilesPerGallon

