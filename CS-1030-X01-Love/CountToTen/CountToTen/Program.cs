// Project Prolog
// Name: Spencer Carter
// CS 1030 X01
// Project: CountToTen
// Date: 02/18/15
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;

namespace CountToTen
{
    static class Program
    {
        /// <summary>
        /// Purpose: Entry point to this C# program
        /// </summary>
        static void Main()
        {
            #region For Loop
            int _userVar = 0;
            int _userCount = 0;
            Console.WriteLine("Using For Loop");
            Console.Write("How far do you want to count? ");
            int.TryParse(Console.ReadLine(), out _userVar);
            if (_userVar <=0)
            {
                Console.WriteLine("You have entered an invalad number, try again.");
                return;
            }
            Console.Write("By what degree do you want to count by? ");
            int.TryParse(Console.ReadLine(), out _userCount);
            if (_userCount <= 0)
            {
                Console.WriteLine("You have entered an invalad number, try again.");
                return;
            }
            for (int i = 0; i <= _userVar; i = i + _userCount)
            {
                Console.WriteLine(i.ToString());
            }
            #endregion For Loop
            #region While Loop
            int _userVar2 = 0;
            int _userCount2 = 0;
            int j = 0;
            Console.WriteLine("\nUsing While Loop");
            Console.Write("How far do you want to count? ");
            int.TryParse(Console.ReadLine(), out _userVar2);
            if (_userVar2 <= 0)
            {
                Console.WriteLine("You have entered an invalad number, try again.");
                return;
            }
            Console.Write("By what degree do you want to count by? ");
            int.TryParse(Console.ReadLine(), out _userCount2);
            if (_userCount2 <= 0)
            {
                Console.WriteLine("You have entered an invalad number, try again.");
                return;
            }
            while (j<=_userVar2)
            {
                Console.WriteLine(j.ToString());
                j = j + _userCount2;
            }
            #endregion While Loop
            #region Do While
            int _userVar3 = 0;
            int _userCount3 = 0;
            int k = 0;
            Console.WriteLine("Using While Loop");
            Console.Write("How far do you want to count? ");
            int.TryParse(Console.ReadLine(), out _userVar3);
            if (_userVar3 <= 0)
            {
                Console.WriteLine("You have entered an invalad number, try again.");
                return;
            }
            Console.Write("By what degree do you want to count by? ");
            int.TryParse(Console.ReadLine(), out _userCount3);
            if (_userCount3 <= 0)
            {
                Console.WriteLine("You have entered an invalad number, try again.");
                return;
            }
            Console.WriteLine("\nPost Test While Loop (aka Do While)");
            do
            {
                Console.WriteLine(k.ToString());
                k = k + _userCount3;
            } while (k <= _userVar3);
            #endregion Do While
            Console.Write("\nPress any key to Exit ... ");
            Console.ReadKey(true);
        }//End Main()
    }//End class Program
}//End namespace CountToTen

