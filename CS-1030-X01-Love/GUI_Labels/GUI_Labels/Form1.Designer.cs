namespace GUI_Labels
{
    partial class Frm_GuiLabels
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
            this.Btn_Left = new System.Windows.Forms.Button();
            this.Btn_Center = new System.Windows.Forms.Button();
            this.Btn_Right = new System.Windows.Forms.Button();
            this.Lbl_Data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Left
            // 
            this.Btn_Left.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Left.Location = new System.Drawing.Point(12, 30);
            this.Btn_Left.Name = "Btn_Left";
            this.Btn_Left.Size = new System.Drawing.Size(150, 80);
            this.Btn_Left.TabIndex = 0;
            this.Btn_Left.Text = "Left Justify";
            this.Btn_Left.UseVisualStyleBackColor = true;
            this.Btn_Left.Click += new System.EventHandler(this.Btn_Left_Click);
            // 
            // Btn_Center
            // 
            this.Btn_Center.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Center.Location = new System.Drawing.Point(168, 30);
            this.Btn_Center.Name = "Btn_Center";
            this.Btn_Center.Size = new System.Drawing.Size(150, 80);
            this.Btn_Center.TabIndex = 1;
            this.Btn_Center.Text = "Center";
            this.Btn_Center.UseVisualStyleBackColor = true;
            this.Btn_Center.Click += new System.EventHandler(this.Btn_Center_Click);
            // 
            // Btn_Right
            // 
            this.Btn_Right.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Right.Location = new System.Drawing.Point(324, 30);
            this.Btn_Right.Name = "Btn_Right";
            this.Btn_Right.Size = new System.Drawing.Size(150, 80);
            this.Btn_Right.TabIndex = 2;
            this.Btn_Right.Text = "Right Justify";
            this.Btn_Right.UseVisualStyleBackColor = true;
            this.Btn_Right.Click += new System.EventHandler(this.Btn_Right_Click);
            // 
            // Lbl_Data
            // 
            this.Lbl_Data.BackColor = System.Drawing.Color.White;
            this.Lbl_Data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Data.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Data.Location = new System.Drawing.Point(12, 113);
            this.Lbl_Data.Name = "Lbl_Data";
            this.Lbl_Data.Size = new System.Drawing.Size(464, 36);
            this.Lbl_Data.TabIndex = 3;
            this.Lbl_Data.Text = "This is a label.";
            this.Lbl_Data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_GuiLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 204);
            this.Controls.Add(this.Lbl_Data);
            this.Controls.Add(this.Btn_Right);
            this.Controls.Add(this.Btn_Center);
            this.Controls.Add(this.Btn_Left);
            this.Name = "Frm_GuiLabels";
            this.Text = "Label Alignment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Left;
        private System.Windows.Forms.Button Btn_Center;
        private System.Windows.Forms.Button Btn_Right;
        private System.Windows.Forms.Label Lbl_Data;
    }
}

