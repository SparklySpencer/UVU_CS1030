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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageScores
{
    /// <summary>
    /// the default class for Forms
    /// </summary>
    public partial class frmMain : Form
    {
        /// <summary>
        /// the default constructor for Forms
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// a click event we created, that will open a txt file and find the average scores
        /// </summary>
        /// <param name="sender">btnOpen_Click</param>
        /// <param name="e">Not used</param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            //1) Show the OpenFileDialog and let the user select a file.
            DialogResult result;
            result = ofd.ShowDialog();
            //2) IF a file was selected
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //3) Open the file
                string fileName = ofd.FileName;
                StreamReader f = new StreamReader(fileName);
                int total = 0;
                int count = 0;
                while (!f.EndOfStream)
                {
                    //4) Read through all the scores -- calculating the total and number of scores. Display each score as it is read.
                    string textScore = f.ReadLine();
                    lstScores.Items.Add(textScore);
                    int score = int.Parse(textScore);
                    total = total + score;
                    count = count + 1;
                }
                //5) Close the file
                f.Close();
                //6) Calculate average score
                double average = (total / count);
                //7) Display average score
                lblAverage.Text = string.Format("{0:f2}", average);
            }

        }
    }
}
