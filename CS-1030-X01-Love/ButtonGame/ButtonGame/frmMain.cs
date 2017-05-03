/* Project Prologue
 * Name: Spencer Carter
 * Class: CS 1030 X01
 * Lesson 3.4 - Button Button Game
 * Date: 04/12/15
 * 
 * I declare that the following code was written by me, provided
 * by the instrustor, assisted via the lovely people in the drop
 * in lab, or provided in the textbook for this project. I also
 * understand that copying source code from any other sourece 
 * constitutes cheating, and that I will recieve a zero on this
 * project if I am found in violation of this policy.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonGame
{
    /// <summary>
    /// The default class built for form apps
    /// </summary>
    public partial class frmMain : Form
    {
        public const string BELL_FILE = "Bell.wav";
        public const string BUTTON_IMAGE_FILE = "buttonImage.jpg";
        List<Button> buttonList; // This will hold a list of all the "?" button controls
        int hidingPlace; // Button number where the sewing buttons are hidden
        int currentScore; // Curent score for the surrent round of play
        int totalScore; // This will hold the total score
        int gameCount; // This will hold the number of games that have been played
        System.Media.SoundPlayer bell; // Media player to play sound of a bell
        Bitmap picture; // picture of the sewing buttons.

        /// <summary>
        /// the default constructor for form apps
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This event will be used to initialize the program's data items.
        /// </summary>
        /// <param name="sender">frmMain_Load</param>
        /// <param name="e">Not Used</param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            //Goes through the form's controlls and finds all the "?" button controlls, and places them into the list.
            buttonList = new List<Button>();
            foreach (Control item in this.Controls)
            {
                if ((string)item.Text == "?")
                {
                    buttonList.Add((Button)item);
                }//End if
            }//End foreach
            //Gets the file's path that this executable loaded from
            string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            //Create the file path to the sound and image files
            string bellFilePath = System.IO.Path.Combine(appPath, BELL_FILE);
            string pictureFilePath = System.IO.Path.Combine(appPath, BUTTON_IMAGE_FILE);
            //Load Bell sound file and sewing button picture file
            bell = new System.Media.SoundPlayer(bellFilePath);
            picture = new Bitmap(pictureFilePath);
            //Initialize counts
            currentScore = 0;
            totalScore = 0;
            gameCount = 0;
            hidingPlace = 0;
        }
        /// <summary>
        /// This event will be used to play the game
        /// </summary>
        /// <param name="sender">btnPlay_Click</param>
        /// <param name="e">Not Used</param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Clear out button image from last game
            if (buttonList [hidingPlace] != null)
            {
                buttonList[hidingPlace].Image = null;
                buttonList[hidingPlace].Refresh();
            }//End if
            //Flash the "?" buttons randomly with HotPink.
            //At end of loop, hiding place will always have the index number of last button flashed.
            for (int i = 1; i <= 24; i++) //flash 24 times
            {
                Random dice = new Random(); //creates a new random dice object
                Color previous = buttonList[hidingPlace].BackColor; // To save the original color
                hidingPlace = dice.Next(1, 600) % 6; //index numbers between 0 and 5 are inclusive
                buttonList[hidingPlace].BackColor = Color.HotPink; // paint the hiding place hot pink
                buttonList[hidingPlace].Refresh();
                System.Threading.Thread.Sleep(20); // pause for 20ms
                buttonList[hidingPlace].BackColor = previous; // repaint to original scheme
                buttonList[hidingPlace].Refresh();
            }//End for
            gameCount = gameCount + 1; // increment the game count
            currentScore = 6; // reset guess score
        }
        /// <summary>
        /// This event will be used to close the program.
        /// </summary>
        /// <param name="sender">btnExit_Click</param>
        /// <param name="e">Not Used</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Event for clicking on a ? to see if the hidden item is there.
        /// </summary>
        /// <param name="sender">btnTopLeft_Click</param>
        /// <param name="e">Not Used</param>
        private void btnTopLeft_Click(object sender, EventArgs e)
        {
            int p;
            Button b;
            //Get the button that was clicked and see if it is the hiding place
            b = (Button)sender;
            p = buttonList.FindIndex(b.Equals);
            if (p == hidingPlace)
            {
                totalScore = totalScore + currentScore;
                b.Image = picture;
                bell.Play();
            }//End if
            else
            {
                if (currentScore > 0) currentScore = currentScore - 1;
            }
            //format and display score info
            lblCurrent.Text = String.Format("Points Remaining: {0:N0}", currentScore);
            lblTotal.Text = string.Format("Total Score: {0:N0} out of {1:N0} games.", totalScore, gameCount);
            lblCurrent.Refresh();
            lblTotal.Refresh();
        }
    }//End class Form
}//End namespace ButtonGame
