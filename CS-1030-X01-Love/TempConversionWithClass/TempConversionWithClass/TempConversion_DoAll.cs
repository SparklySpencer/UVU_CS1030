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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TempConversionWithClass
{
    /// <summary>
    /// Purpose: this is a class that will be called on to do different conversions for the user.
    /// </summary>
    class TempConversion_DoAll
    {
        #region Vars
        private double _passedValue;
        public const int C_VALUE = 32;
        public const double K_VALUE = 273.15;
        public const double FIVE_NINE = 0.5555555556;
        public const double NINE_FIVE = 1.8;
        #endregion Vars

        #region Properties
        /// <summary>
        /// Purpose: this property will be used in the get properties for the conversions.
        /// </summary>
        public string PassedValue
        {
            set
            {
                double.TryParse(value, out _passedValue);
            }
            get
            {
                return string.Format("{0}", _passedValue);
            }
        }
        /// <summary>
        /// To convert F to C
        /// </summary>
        public double Fahrenheit2Celsius
        {
            get
            {
                return ((_passedValue - C_VALUE) * FIVE_NINE);
            }
        }
        /// <summary>
        /// To convert F to K
        /// </summary>
        public double Fahrenheit2Kelvin
        {
            get
            {
                return ((_passedValue - C_VALUE) * FIVE_NINE + K_VALUE);
            }
        }
        /// <summary>
        /// To convert C to F
        /// </summary>
        public double Celsius2Fahrenheit
        {
            get
            {
                return ((_passedValue * NINE_FIVE) + C_VALUE);
            }
        }
        /// <summary>
        /// To convert C to K
        /// </summary>
        public double Celsius2Kelvin
        {
            get
            {
                return (_passedValue + K_VALUE);
            }
        }
        /// <summary>
        /// To convert K to F
        /// </summary>
        public double Kelvin2Fahrenheit
        {
            get
            {
                return ((_passedValue - K_VALUE) * NINE_FIVE + C_VALUE);
            }
        }
        /// <summary>
        /// To convert K to C
        /// </summary>
        public double Kelvin2Celsius
        {
            get
            {
                return (_passedValue - K_VALUE);
            }
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// The default constructor for the class
        /// </summary>
        public TempConversion_DoAll()
        {
            ClassReset();
        }
        /// <summary>
        /// To reset the variables to the initial value.
        /// </summary>
        public void ClassReset()
        {
            _passedValue = 0.0;
        }
        #endregion Methods
    }
}
