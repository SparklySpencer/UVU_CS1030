/* Project Prolog
 * Name: Spencer Carter
 * CS 1030 X01
 * Lesson 2.5 - Method Calls: Temperature Conversion Assignment
 * Date: 03/19/15
 * 
 * I declare that the following code was written by me, assisted with
 * by the lovely people in the drop in lab provided by the instructior
 * for this project. I understand that copying source code from any other
 * source constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 */
/* <--- Documentation Stuffs --->
 * 1) Assignment Description:
 * 2) Conversion formula should be placed in a function.
 * 3) Have a menu system to choose which conversion they want to use.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConversionWithClass
{
    class Program
    {   /// <summary>
        /// A class level reference to the TempConversion (which will do all the business logic).
        /// </summary>
        static TempConversion_DoAll tc;
        #region Class Level Var
        static string KEY_BLANK = "";
        static string KEY_EXIT = "Press any key to exit... ";
        static string KEY_GOODBYE = "\nGoodbye\n";
        static string KEY_RESTART = "Press any key to Restart ... ";
        static string C_IN = "\nPlease enter your temperature in Celsius: ";
        static string C2F = "\t3) Celsius into Fahrenheit\n";
        static string C2K = "\t4) Celsius into Kelvin\n";
        static string TEMP_C = "The temperature is {0:f2} degrees Celsius";
        static string F_IN = "\nPlease enter your temperature in Farenheit: ";
        static string F2C = "\t1) Farenheit into Celsius\n";
        static string F2K = "\t2) Farenheit into Kelvin\n";
        static string TEMP_F = "The temperature is {0:f2} degrees Fahrenheit";
        static string K_IN = "\nPlease enter your temperature in Kelvin: ";
        static string K2F = "\t5) Kelvin into Fahrenheit\n";
        static string K2C = "\t6) Kelvin into Celsius\n";
        static string TEMP_K = "The temperature is {0:f2} degrees Kelvin";
        #endregion Class Level VAr
        /// <summary>
        /// Purpose: Entry point to this C# program
        /// </summary>
        static void Main()
        {
            /// <summary>
            /// The code below will create a new class object called tc which will do all the business logic.
            /// </summary>
            //One Method Call
            tc = new TempConversion_DoAll();
            MenuSystem();
        }//End Main()
        #region Methods
        /// <summary>
        /// The method that is called to change a F to a C
        /// </summary>
        private static void F2Celsius()
        {
            while (true)
            {
                string _temp;
                Console.Clear();
                Console.WriteLine(F2C);
                Console.Write(F_IN);
                _temp = Console.ReadLine();
                if (_temp == KEY_BLANK)
                {
                    Console.WriteLine(KEY_GOODBYE);
                    break;
                }
                else
                {
                    tc.PassedValue = _temp;
                    Console.WriteLine(TEMP_C, tc.Fahrenheit2Celsius);
                    Console.Write(KEY_RESTART);
                    Console.ReadKey(true);
                }
            }
            Console.Write(KEY_EXIT);
            Console.ReadKey(true);
        }//End F2Celsius()
        /// <summary>
        /// The method that is called to change F to K
        /// </summary>
        private static void F2Kelvin()
        {
            while (true)
            {
                string _temp;
                Console.Clear();
                Console.WriteLine(F2K);
                Console.Write(F_IN);
                _temp = Console.ReadLine();
                if (_temp == KEY_BLANK)
                {
                    Console.WriteLine(KEY_GOODBYE);
                    break;
                }
                else
                {
                    tc.PassedValue = _temp;
                    Console.WriteLine(TEMP_K, tc.Fahrenheit2Kelvin);
                    Console.Write(KEY_RESTART);
                    Console.ReadKey(true);
                }
            }
            Console.Write(KEY_EXIT);
            Console.ReadKey(true);
        }//End F2Kelvin()
        /// <summary>
        /// The method that is called to change C to F
        /// </summary>
        private static void C2Fahrenheit()
        {
            while (true)
            {
                string _temp;
                Console.Clear();
                Console.WriteLine(C2F);
                Console.Write(C_IN);
                _temp = Console.ReadLine();
                if (_temp == KEY_BLANK)
                {
                    Console.WriteLine(KEY_GOODBYE);
                    break;
                }
                else
                {
                    tc.PassedValue = _temp;
                    Console.WriteLine(TEMP_F, tc.Celsius2Fahrenheit);
                    Console.Write(KEY_RESTART);
                    Console.ReadKey(true);
                }
            }
            Console.Write(KEY_EXIT);
            Console.ReadKey(true);
        }//End C2Fahrenheit
        /// <summary>
        /// The method that is called to change C to K
        /// </summary>
        private static void C2Kelvin()
        {
            while (true)
            {
                string _temp;
                Console.Clear();
                Console.WriteLine(C2K);
                Console.Write(C_IN);
                _temp = Console.ReadLine();
                if (_temp == KEY_BLANK)
                {
                    Console.WriteLine(KEY_GOODBYE);
                    break;
                }
                else
                {
                    tc.PassedValue = _temp;
                    Console.WriteLine(TEMP_K, tc.Celsius2Kelvin);
                    Console.Write(KEY_RESTART);
                    Console.ReadKey(true);
                }
            }
            Console.Write(KEY_EXIT);
            Console.ReadKey(true);
        }//End C2Kelvin
        /// <summary>
        /// The method that is called to change K to F
        /// </summary>
        private static void K2Fahrenheit()
        {
            while (true)
            {
                string _temp;
                Console.Clear();
                Console.WriteLine(K2F);
                Console.Write(K_IN);
                _temp = Console.ReadLine();
                if (_temp == KEY_BLANK)
                {
                    Console.WriteLine(KEY_GOODBYE);
                    break;
                }
                else
                {
                    tc.PassedValue = _temp;
                    Console.WriteLine(TEMP_F, tc.Kelvin2Fahrenheit);
                    Console.Write(KEY_RESTART);
                    Console.ReadKey(true);
                }
            }
            Console.Write(KEY_EXIT);
            Console.ReadKey(true);
        }//End K2Fahrenheit
        /// <summary>
        /// The method that is called to change K to C
        /// </summary>
        private static void K2Celsius()
        {
            while (true)
            {
                string _temp;
                Console.Clear();
                Console.WriteLine(K2C);
                Console.Write(K_IN);
                _temp = Console.ReadLine();
                if (_temp == KEY_BLANK)
                {
                    Console.WriteLine(KEY_GOODBYE);
                    break;
                }
                else
                {
                    tc.PassedValue = _temp;
                    Console.WriteLine(TEMP_C, tc.Kelvin2Celsius);
                    Console.Write(KEY_RESTART);
                    Console.ReadKey(true);
                }
            }
            Console.Write(KEY_EXIT);
            Console.ReadKey(true);
        }//End K2Celsius
        /// <summary>
        /// A method that displays a menu system for the user to choose which conversion they would like.
        /// </summary>
        private static void MenuSystem()
        {
            string input = KEY_BLANK;
            do
            {
                Console.Clear();
                Console.Write("Select which Temperature Conversion you would like:\n" +
                                  F2C +
                                  F2K +
                                  C2F +
                                  C2K +
                                  K2F +
                                  K2C +
                                  "\tQ)uit\n" +
                                  "\t\tEnter selection:  "
                              );
                switch (((input = Console.ReadLine()) == KEY_BLANK) ? 'Q' : char.ToUpper(input[0]))
                {
                    case '1':
                        F2Celsius();
                        break;
                    case '2':
                        F2Kelvin();
                        break;
                    case '3':
                        C2Fahrenheit();
                        break;
                    case '4':
                        C2Kelvin();
                        break;
                    case '5':
                        K2Fahrenheit();
                        break;
                    case '6':
                        K2Celsius();
                        break;
                    case 'Q':
                        Console.Write(KEY_GOODBYE);
                        Console.ReadKey(true);
                        return;
                    default:
                        Console.WriteLine("Invalid menu selection!");
                        Console.ReadKey(true);
                        break;
                }
            } while (true);
        }
        #endregion Methods
    }
}
