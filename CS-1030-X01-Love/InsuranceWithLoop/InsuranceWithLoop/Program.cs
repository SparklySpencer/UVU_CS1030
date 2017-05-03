﻿/* Project Prolog
 * Name: Spencer Carter
 * CS 1030 x01
 * Date: 02/20/2015
 * 
 * I declare that the following code was written by me, assisted with
 * by the lovely people in the drop in lab provided by the instructior
 * for this project. I understand that copying source code from any other
 * source constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 */
#region Psudocode
/* Description:
 * Using if-else-if statment, write a console program that, given a person's
 * age, will return their classification and rate multiplier as defined.
 * Outputs:
 * Person's Age (int age)
 * classification (child, teen, adult, senior)
 * 0-12 = child, 13-18 = teen, 19-65 = adult, 65+ = senior
 * rate multiplier (1.0, 1.5, 1.7, 2.0)
 * Inputes:
 * Person's age
 * Process:
 * 1) set up the const rate multipliers as double & set up const strings
 * 2) set up the variable aga as an int, set up class as blank string, and set up rate as a blank double
 * 3) ask for the person's age
 * 4) using if-else-if statments determin which age group the person belongs to
 * 5) within the if statment have it display the corisponding information
 * New Instructions:
 * 1) Add a loop
 * Add a conditional statment to deal wiht empty strings
 * Add a conditional statment to deal with characters (WIP)
 */
#endregion Psudocode
using System;
namespace InsuranceRate
{
    static class Program
    {
        #region Class Level Constants
        private const double CHILD_MULT = 1.0;
        private const string PRINT_CHILD = "Child";
        private const double TEEN_MULT = 1.5;
        private const string PRINT_TEEN = "Teen";
        private const double ADULT_MULT = 1.7;
        private const string PRINT_ADULT = "Adult";
        private const double SENIOR_MULT = 2.0;
        private const string PRINT_SENIOR = "Senior";
        #endregion Class Level Constants
        /// <summary>
        /// Purpose: Entry point to this C# program
        /// </summary>
        static void Main()
        {
            InsuranceLoop();
        }//End Main()
        /// <summary>
        /// Purpose: to do all the stuffs
        /// </summary>
        static void InsuranceLoop()
        {
            #region Method Level Variables
            int _age = -1; // age will be user entered below
            string _classification = ""; // class will be determined by if statments and pulled from the const strings above
            double _rateMulti = 0.0; // the rate will be determined by if statments and pulled from the doubles above
            #endregion Method Level Variables
           do
            {
                Console.Write("Please state your age... "); // asks for user to input age
                string _userSting = Console.ReadLine();
                if (_userSting == "") // will send empty strings straight to the while statment, which will terminate because of the negative age
                {
                    _age = -1;
                }
                else
                {
                    int.TryParse(_userSting, out _age); // uses captured string and tries to turn into int
                    if (_age <= 12) // first conditional statment
                    {
                        _classification = PRINT_CHILD;
                        _rateMulti = CHILD_MULT;
                    } // end first conditional statment
                    if (_age > 12) // second conditional statment
                    {
                        if (_age <= 18) // this will limit the second statment to be less than or equal to 18, if not it will move to the next statment
                        {
                            _classification = PRINT_TEEN;
                            _rateMulti = TEEN_MULT;
                        } // end second limit
                    } // end second conditional statment
                    if (_age > 18) // third conditional statment
                    {
                        if (_age <= 65) // this will limit the third statment to be less than or equal to 65, if not it will move on to the next statment
                        {
                            _classification = PRINT_ADULT;
                            _rateMulti = ADULT_MULT;
                        } // end third limit
                    } // end third conditional statment
                    if (_age > 65) // fourth conditional statment
                    {
                        _classification = PRINT_SENIOR;
                        _rateMulti = SENIOR_MULT;
                    } // end fourth conditional statment
                    Console.WriteLine("You are {0:d2} years old, we classify you as {1}, and your rate multiplier will be {2:f1}", _age, _classification, _rateMulti);
                }
            } while (_age >= 0);
            Console.Write("Press any key to Exit ... ");
            Console.ReadKey(true);
        }// End InsuranceLoop Method
    }//End class Program
}//End namespace InsuranceRate