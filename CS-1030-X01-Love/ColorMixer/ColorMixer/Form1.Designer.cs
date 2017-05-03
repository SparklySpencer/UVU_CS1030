namespace ColorMixer
{
    partial class FrmColorMix
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
            this.Pnl_DisplayColor = new System.Windows.Forms.Panel();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.TxtBx_Blue = new System.Windows.Forms.TextBox();
            this.TxtBx_Red = new System.Windows.Forms.TextBox();
            this.TxtBx_Green = new System.Windows.Forms.TextBox();
            this.Lbl_Red = new System.Windows.Forms.Label();
            this.Lbl_Green = new System.Windows.Forms.Label();
            this.Lbl_Blue = new System.Windows.Forms.Label();
            this.HSrl_Blue = new System.Windows.Forms.HScrollBar();
            this.HSrl_Green = new System.Windows.Forms.HScrollBar();
            this.HSrl_Red = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // Pnl_DisplayColor
            // 
            this.Pnl_DisplayColor.Location = new System.Drawing.Point(14, 12);
            this.Pnl_DisplayColor.Name = "Pnl_DisplayColor";
            this.Pnl_DisplayColor.Size = new System.Drawing.Size(552, 100);
            this.Pnl_DisplayColor.TabIndex = 0;
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reset.Location = new System.Drawing.Point(455, 196);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(111, 29);
            this.Btn_Reset.TabIndex = 4;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.Location = new System.Drawing.Point(14, 196);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(111, 29);
            this.Btn_Exit.TabIndex = 5;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // TxtBx_Blue
            // 
            this.TxtBx_Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Blue.Location = new System.Drawing.Point(449, 170);
            this.TxtBx_Blue.Name = "TxtBx_Blue";
            this.TxtBx_Blue.ReadOnly = true;
            this.TxtBx_Blue.Size = new System.Drawing.Size(116, 20);
            this.TxtBx_Blue.TabIndex = 6;
            this.TxtBx_Blue.Text = "128";
            this.TxtBx_Blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBx_Red
            // 
            this.TxtBx_Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Red.Location = new System.Drawing.Point(449, 118);
            this.TxtBx_Red.Name = "TxtBx_Red";
            this.TxtBx_Red.ReadOnly = true;
            this.TxtBx_Red.Size = new System.Drawing.Size(116, 20);
            this.TxtBx_Red.TabIndex = 7;
            this.TxtBx_Red.Text = "128";
            this.TxtBx_Red.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBx_Green
            // 
            this.TxtBx_Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Green.Location = new System.Drawing.Point(449, 144);
            this.TxtBx_Green.Name = "TxtBx_Green";
            this.TxtBx_Green.ReadOnly = true;
            this.TxtBx_Green.Size = new System.Drawing.Size(116, 20);
            this.TxtBx_Green.TabIndex = 8;
            this.TxtBx_Green.Text = "128";
            this.TxtBx_Green.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Red
            // 
            this.Lbl_Red.AutoSize = true;
            this.Lbl_Red.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Red.Location = new System.Drawing.Point(367, 118);
            this.Lbl_Red.Name = "Lbl_Red";
            this.Lbl_Red.Size = new System.Drawing.Size(47, 20);
            this.Lbl_Red.TabIndex = 9;
            this.Lbl_Red.Text = "Red:";
            // 
            // Lbl_Green
            // 
            this.Lbl_Green.AutoSize = true;
            this.Lbl_Green.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Green.Location = new System.Drawing.Point(367, 144);
            this.Lbl_Green.Name = "Lbl_Green";
            this.Lbl_Green.Size = new System.Drawing.Size(64, 20);
            this.Lbl_Green.TabIndex = 10;
            this.Lbl_Green.Text = "Green:";
            // 
            // Lbl_Blue
            // 
            this.Lbl_Blue.AutoSize = true;
            this.Lbl_Blue.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Blue.Location = new System.Drawing.Point(367, 170);
            this.Lbl_Blue.Name = "Lbl_Blue";
            this.Lbl_Blue.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Blue.TabIndex = 11;
            this.Lbl_Blue.Text = "Blue:";
            // 
            // HSrl_Blue
            // 
            this.HSrl_Blue.LargeChange = 25;
            this.HSrl_Blue.Location = new System.Drawing.Point(14, 173);
            this.HSrl_Blue.Maximum = 279;
            this.HSrl_Blue.Name = "HSrl_Blue";
            this.HSrl_Blue.Size = new System.Drawing.Size(350, 17);
            this.HSrl_Blue.TabIndex = 12;
            this.HSrl_Blue.Value = 128;
            this.HSrl_Blue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HSrl_Blue_Scroll);
            // 
            // HSrl_Green
            // 
            this.HSrl_Green.LargeChange = 25;
            this.HSrl_Green.Location = new System.Drawing.Point(14, 147);
            this.HSrl_Green.Maximum = 279;
            this.HSrl_Green.Name = "HSrl_Green";
            this.HSrl_Green.Size = new System.Drawing.Size(350, 17);
            this.HSrl_Green.TabIndex = 13;
            this.HSrl_Green.Value = 128;
            this.HSrl_Green.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HSrl_Green_Scroll);
            // 
            // HSrl_Red
            // 
            this.HSrl_Red.LargeChange = 25;
            this.HSrl_Red.Location = new System.Drawing.Point(14, 121);
            this.HSrl_Red.Maximum = 279;
            this.HSrl_Red.Name = "HSrl_Red";
            this.HSrl_Red.Size = new System.Drawing.Size(350, 17);
            this.HSrl_Red.TabIndex = 14;
            this.HSrl_Red.Value = 128;
            this.HSrl_Red.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HSrl_Red_Scroll);
            // 
            // FrmColorMix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 241);
            this.Controls.Add(this.HSrl_Red);
            this.Controls.Add(this.HSrl_Green);
            this.Controls.Add(this.HSrl_Blue);
            this.Controls.Add(this.Lbl_Blue);
            this.Controls.Add(this.Lbl_Green);
            this.Controls.Add(this.Lbl_Red);
            this.Controls.Add(this.TxtBx_Green);
            this.Controls.Add(this.TxtBx_Red);
            this.Controls.Add(this.TxtBx_Blue);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Pnl_DisplayColor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmColorMix";
            this.Text = "Color  Mixer C#";
            this.Load += new System.EventHandler(this.FrmColorMix_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_DisplayColor;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.TextBox TxtBx_Blue;
        private System.Windows.Forms.TextBox TxtBx_Red;
        private System.Windows.Forms.TextBox TxtBx_Green;
        private System.Windows.Forms.Label Lbl_Red;
        private System.Windows.Forms.Label Lbl_Green;
        private System.Windows.Forms.Label Lbl_Blue;
        private System.Windows.Forms.HScrollBar HSrl_Blue;
        private System.Windows.Forms.HScrollBar HSrl_Green;
        private System.Windows.Forms.HScrollBar HSrl_Red;
    }
}

