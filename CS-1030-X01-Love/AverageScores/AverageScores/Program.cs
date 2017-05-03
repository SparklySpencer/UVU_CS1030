/* Project Prolog
 * Name: Spencer Carter
 * CS 1030 X01
 * Lesson 3.1 - Average Scores
 * Date: 03/18/15
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageScores
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
