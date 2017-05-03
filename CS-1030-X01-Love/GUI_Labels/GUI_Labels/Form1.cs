/* Project Prolog
 * Name: Spencer Carter
 * CS 1030 X01
 * Lesson 2.6.2 - GUI Labels
 * Date: 03/09/15
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

namespace GUI_Labels
{
    public partial class Frm_GuiLabels : Form
    {
        /// <summary>
        /// Purpose: Entry point into the form.
        /// </summary>
        public Frm_GuiLabels()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Purpose: To left align the text in the label
        /// </summary>
        /// <param name="sender">Btn_Left_Click</param>
        /// <param name="e">Not used</param>
        private void Btn_Left_Click(object sender, EventArgs e)
        {
            Lbl_Data.TextAlign = ContentAlignment.MiddleLeft;
            Lbl_Data.Text = "Moved to left justification";
        }
        /// <summary>
        /// Purpose: To center align the text in the label
        /// </summary>
        /// <param name="sender">Btn_Center_Click</param>
        /// <param name="e">Not used</param>
        private void Btn_Center_Click(object sender, EventArgs e)
        {
            Lbl_Data.TextAlign = ContentAlignment.MiddleCenter;
            Lbl_Data.Text = "Moved to center justification";
        }
        /// <summary>
        /// Purpose: To right align the text in the label.
        /// </summary>
        /// <param name="sender">Btn_Right_Click</param>
        /// <param name="e">Not used</param>
        private void Btn_Right_Click(object sender, EventArgs e)
        {
            Lbl_Data.TextAlign = ContentAlignment.MiddleRight;
            Lbl_Data.Text = "Moved to right justification";
        }
    }//End class Frm_GuiLabels : Form
}//End namespace GUI_Labels
