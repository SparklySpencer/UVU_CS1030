namespace ColorBoxesAssign
{
    partial class FrmColorBx
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pnl_Bottom = new System.Windows.Forms.Panel();
            this.Pnl_Middle = new System.Windows.Forms.Panel();
            this.Pnl_Top = new System.Windows.Forms.Panel();
            this.Pnl_Bottom.SuspendLayout();
            this.Pnl_Middle.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Bottom
            // 
            this.Pnl_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Bottom.BackColor = System.Drawing.Color.Red;
            this.Pnl_Bottom.Controls.Add(this.Pnl_Middle);
            this.Pnl_Bottom.Location = new System.Drawing.Point(12, 12);
            this.Pnl_Bottom.Name = "Pnl_Bottom";
            this.Pnl_Bottom.Size = new System.Drawing.Size(392, 340);
            this.Pnl_Bottom.TabIndex = 0;
            // 
            // Pnl_Middle
            // 
            this.Pnl_Middle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Middle.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_Middle.Controls.Add(this.Pnl_Top);
            this.Pnl_Middle.Location = new System.Drawing.Point(18, 17);
            this.Pnl_Middle.Name = "Pnl_Middle";
            this.Pnl_Middle.Size = new System.Drawing.Size(356, 305);
            this.Pnl_Middle.TabIndex = 0;
            // 
            // Pnl_Top
            // 
            this.Pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Top.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Pnl_Top.Location = new System.Drawing.Point(15, 18);
            this.Pnl_Top.Name = "Pnl_Top";
            this.Pnl_Top.Size = new System.Drawing.Size(326, 268);
            this.Pnl_Top.TabIndex = 0;
            // 
            // FrmColorBx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 364);
            this.Controls.Add(this.Pnl_Bottom);
            this.Name = "FrmColorBx";
            this.Text = "Color Boxes Assignment";
            this.Pnl_Bottom.ResumeLayout(false);
            this.Pnl_Middle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Bottom;
        private System.Windows.Forms.Panel Pnl_Middle;
        private System.Windows.Forms.Panel Pnl_Top;
    }
}

