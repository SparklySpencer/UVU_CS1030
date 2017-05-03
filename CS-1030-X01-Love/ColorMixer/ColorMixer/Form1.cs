/* Project Prolog
 * Name: Spencer Carter
 * CS 1030 X01
 * Lesson 3.2 - Color Mixer 
 * Date: 03/22/15
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Constraints
 * Int values must be no lower than 0
 * Int balues must be no higher than 255
 * Start values should be 128, 128, 128
 * Start shold display above values
 * Reset should reset to those values
 */

namespace ColorMixer
{
    /// <summary>
    /// The default class for Forms
    /// </summary>
    public partial class FrmColorMix : Form
    {
        #region No Magic Things
        private const int START_COLOR_VALUE = 128;
        #endregion

        /// <summary>
        /// The default constructor for Forms
        /// </summary>
        public FrmColorMix()
        {
            InitializeComponent();
        }
        /// <summary>
        /// An event that acts sort of like a defualt constructor, because it initializes the values.
        /// </summary>
        /// <param name="sender">?</param>
        /// <param name="e">?</param>
        private void FrmColorMix_Load(object sender, EventArgs e)
        {
            //In your frmMain_Load event routine, call your btnReset_Click event to set all your controls to their initial states.
            //In this call you will need to include two arguments as specified in its declaration.
            //Just pass on the same sender and e parameters that were passed into the frmMain_Load routine (e.g., btnReset_Click(sender, e);).
            //ResetQuickWork();
            Btn_Reset_Click(sender, e);
        }
        /// <summary>
        /// Resets the color values to the default and updates the display.
        /// </summary>
        /// <param name="sender">Btn_Reset_Click</param>
        /// <param name="e">Not Used</param>
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            HSrl_Red.Value = START_COLOR_VALUE;
            TxtBx_Red.Text = HSrl_Red.Value.ToString();
            HSrl_Green.Value = START_COLOR_VALUE;
            TxtBx_Green.Text = HSrl_Green.Value.ToString();
            HSrl_Blue.Value = START_COLOR_VALUE;
            TxtBx_Blue.Text = HSrl_Blue.Value.ToString();
            DisplayColor();
        }
        /// <summary>
        /// Ends the Program
        /// </summary>
        /// <param name="sender">Btn_Exit_Click</param>
        /// <param name="e">Not used</param>
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// This is the event for the red scroll bar, ties the scroll bar value to the textbox display.
        /// </summary>
        /// <param name="sender">HSrl_Red_Scroll</param>
        /// <param name="e">Not used</param>
        private void HSrl_Red_Scroll(object sender, ScrollEventArgs e)
        {
            TxtBx_Red.Text = HSrl_Red.Value.ToString();
            DisplayColor();
        }
        /// <summary>
        /// This is the event for the Green scroll bar, it ties the scroll bar value to the textbox display.
        /// </summary>
        /// <param name="sender">HSrl_Green_Scroll</param>
        /// <param name="e">Not used</param>
        private void HSrl_Green_Scroll(object sender, ScrollEventArgs e)
        {
            TxtBx_Green.Text = HSrl_Green.Value.ToString();
            DisplayColor();
        }
        /// <summary>
        /// This is the event for the Blue scroll bar, it ties the scroll bar value to the textbox display.
        /// </summary>
        /// <param name="sender">HSrl_Blue_Scroll</param>
        /// <param name="e">Not used</param>
        private void HSrl_Blue_Scroll(object sender, ScrollEventArgs e)
        {
            TxtBx_Blue.Text = HSrl_Blue.Value.ToString();
            DisplayColor();
        }
        /// <summary>
        /// This will update event handlers to display the correct color via the scroll bar.
        /// </summary>
        private void DisplayColor()
        {
            Pnl_DisplayColor.BackColor = Color.FromArgb(HSrl_Red.Value, HSrl_Green.Value, HSrl_Blue.Value);
        }
    }//End class FormColorMix
}//End namespace ColorMixer
