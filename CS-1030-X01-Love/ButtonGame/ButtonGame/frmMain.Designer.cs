namespace ButtonGame
{
    partial class frmMain
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTopLeft = new System.Windows.Forms.Button();
            this.btnTopMiddle = new System.Windows.Forms.Button();
            this.btnTopRight = new System.Windows.Forms.Button();
            this.btnBottomLeft = new System.Windows.Forms.Button();
            this.btnBottomMiddle = new System.Windows.Forms.Button();
            this.btnBottomRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 54);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(81, 38);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(296, 54);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 38);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTopLeft
            // 
            this.btnTopLeft.BackColor = System.Drawing.Color.White;
            this.btnTopLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopLeft.Location = new System.Drawing.Point(12, 108);
            this.btnTopLeft.Name = "btnTopLeft";
            this.btnTopLeft.Size = new System.Drawing.Size(117, 89);
            this.btnTopLeft.TabIndex = 2;
            this.btnTopLeft.Text = "?";
            this.btnTopLeft.UseVisualStyleBackColor = false;
            this.btnTopLeft.Click += new System.EventHandler(this.btnTopLeft_Click);
            // 
            // btnTopMiddle
            // 
            this.btnTopMiddle.BackColor = System.Drawing.Color.White;
            this.btnTopMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopMiddle.Location = new System.Drawing.Point(135, 108);
            this.btnTopMiddle.Name = "btnTopMiddle";
            this.btnTopMiddle.Size = new System.Drawing.Size(117, 89);
            this.btnTopMiddle.TabIndex = 3;
            this.btnTopMiddle.Text = "?";
            this.btnTopMiddle.UseVisualStyleBackColor = false;
            this.btnTopMiddle.Click += new System.EventHandler(this.btnTopLeft_Click);
            // 
            // btnTopRight
            // 
            this.btnTopRight.BackColor = System.Drawing.Color.White;
            this.btnTopRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopRight.Location = new System.Drawing.Point(258, 108);
            this.btnTopRight.Name = "btnTopRight";
            this.btnTopRight.Size = new System.Drawing.Size(117, 89);
            this.btnTopRight.TabIndex = 4;
            this.btnTopRight.Text = "?";
            this.btnTopRight.UseVisualStyleBackColor = false;
            this.btnTopRight.Click += new System.EventHandler(this.btnTopLeft_Click);
            // 
            // btnBottomLeft
            // 
            this.btnBottomLeft.BackColor = System.Drawing.Color.White;
            this.btnBottomLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBottomLeft.Location = new System.Drawing.Point(12, 203);
            this.btnBottomLeft.Name = "btnBottomLeft";
            this.btnBottomLeft.Size = new System.Drawing.Size(117, 89);
            this.btnBottomLeft.TabIndex = 5;
            this.btnBottomLeft.Text = "?";
            this.btnBottomLeft.UseVisualStyleBackColor = false;
            this.btnBottomLeft.Click += new System.EventHandler(this.btnTopLeft_Click);
            // 
            // btnBottomMiddle
            // 
            this.btnBottomMiddle.BackColor = System.Drawing.Color.White;
            this.btnBottomMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBottomMiddle.Location = new System.Drawing.Point(135, 203);
            this.btnBottomMiddle.Name = "btnBottomMiddle";
            this.btnBottomMiddle.Size = new System.Drawing.Size(117, 89);
            this.btnBottomMiddle.TabIndex = 6;
            this.btnBottomMiddle.Text = "?";
            this.btnBottomMiddle.UseVisualStyleBackColor = false;
            this.btnBottomMiddle.Click += new System.EventHandler(this.btnTopLeft_Click);
            // 
            // btnBottomRight
            // 
            this.btnBottomRight.BackColor = System.Drawing.Color.White;
            this.btnBottomRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBottomRight.Location = new System.Drawing.Point(260, 203);
            this.btnBottomRight.Name = "btnBottomRight";
            this.btnBottomRight.Size = new System.Drawing.Size(117, 89);
            this.btnBottomRight.TabIndex = 7;
            this.btnBottomRight.Text = "?";
            this.btnBottomRight.UseVisualStyleBackColor = false;
            this.btnBottomRight.Click += new System.EventHandler(this.btnTopLeft_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(99, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Click boxes below to find button.";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(9, 295);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(145, 16);
            this.lblCurrent.TabIndex = 9;
            this.lblCurrent.Text = "Points Remaining: 0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 319);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(210, 16);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total Score: 0 out of 0 games";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 344);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBottomRight);
            this.Controls.Add(this.btnBottomMiddle);
            this.Controls.Add(this.btnBottomLeft);
            this.Controls.Add(this.btnTopRight);
            this.Controls.Add(this.btnTopMiddle);
            this.Controls.Add(this.btnTopLeft);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Button Game";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTopLeft;
        private System.Windows.Forms.Button btnTopMiddle;
        private System.Windows.Forms.Button btnTopRight;
        private System.Windows.Forms.Button btnBottomLeft;
        private System.Windows.Forms.Button btnBottomMiddle;
        private System.Windows.Forms.Button btnBottomRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblTotal;
    }
}

