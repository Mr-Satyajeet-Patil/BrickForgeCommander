﻿namespace BrickForgeCommanderUI.MasterForms
{
    partial class frmModeDetails
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
            this.bfC_TextBox1 = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.SuspendLayout();
            // 
            // bfC_TextBox1
            // 
            this.bfC_TextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.bfC_TextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.bfC_TextBox1.BorderFocusColor = System.Drawing.Color.MediumVioletRed;
            this.bfC_TextBox1.BorderRadius = 15;
            this.bfC_TextBox1.BorderSize = 2;
            this.bfC_TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.bfC_TextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.bfC_TextBox1.Location = new System.Drawing.Point(321, 120);
            this.bfC_TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.bfC_TextBox1.MultiLine = true;
            this.bfC_TextBox1.Name = "bfC_TextBox1";
            this.bfC_TextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.bfC_TextBox1.PasswordChar = false;
            this.bfC_TextBox1.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.bfC_TextBox1.PlaceHolderText = "UserName";
            this.bfC_TextBox1.Size = new System.Drawing.Size(250, 118);
            this.bfC_TextBox1.TabIndex = 0;
            this.bfC_TextBox1.Texts = "";
            this.bfC_TextBox1.UnderLineStyle = false;
            // 
            // frmModeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bfC_TextBox1);
            this.Name = "frmModeDetails";
            this.Text = "frmModeDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.BFC_TextBox bfC_TextBox1;
    }
}