﻿namespace BrickForgeCommanderUI.Misc.Anya_sReport
{
    partial class AnyaReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnyaReports));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.picboxAnya = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtReport = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.btnOk = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.btnRetry = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.btnCancle = new BrickForgeCommanderUI.Controls.BFC_Button();
            this.btnClose = new BrickForgeCommanderUI.Controls.NavControls.BFC_Close();
            this.txtReports = new BrickForgeCommanderUI.Controls.BFC_TextBox();
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnya)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.lblCaption);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(832, 47);
            this.pnlTop.TabIndex = 0;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(3, 3);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(0, 38);
            this.lblCaption.TabIndex = 1;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.pnlLeft.Controls.Add(this.picboxAnya);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 47);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(365, 417);
            this.pnlLeft.TabIndex = 1;
            // 
            // picboxAnya
            // 
            this.picboxAnya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.picboxAnya.Image = global::BrickForgeCommanderUI.Properties.Resources.Angry_Anya;
            this.picboxAnya.InitialImage = null;
            this.picboxAnya.Location = new System.Drawing.Point(0, 56);
            this.picboxAnya.Name = "picboxAnya";
            this.picboxAnya.Size = new System.Drawing.Size(365, 361);
            this.picboxAnya.TabIndex = 0;
            this.picboxAnya.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.pnlBottom.Controls.Add(this.btnOk);
            this.pnlBottom.Controls.Add(this.btnRetry);
            this.pnlBottom.Controls.Add(this.btnCancle);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(365, 396);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(467, 68);
            this.pnlBottom.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.pnlMain.Controls.Add(this.txtReports);
            this.pnlMain.Controls.Add(this.txtReport);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(365, 47);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(467, 349);
            this.pnlMain.TabIndex = 3;
            // 
            // txtReport
            // 
            this.txtReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtReport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtReport.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtReport.BorderRadius = 0;
            this.txtReport.BorderSize = 0;
            this.txtReport.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtReport.Location = new System.Drawing.Point(0, 56);
            this.txtReport.Margin = new System.Windows.Forms.Padding(4);
            this.txtReport.MultiLine = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtReport.PasswordChar = false;
            this.txtReport.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtReport.PlaceHolderText = "";
            this.txtReport.Size = new System.Drawing.Size(467, 295);
            this.txtReport.TabIndex = 0;
            this.txtReport.TextBoxText = "";
            this.txtReport.Texts = "";
            this.txtReport.UnderLineStyle = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnOk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnOk.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOk.BorderRadius = 0;
            this.btnOk.BorderSize = 3;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(21, 14);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 50);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.TextColor = System.Drawing.Color.White;
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnRetry.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnRetry.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRetry.BorderRadius = 0;
            this.btnRetry.BorderSize = 3;
            this.btnRetry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetry.ForeColor = System.Drawing.Color.White;
            this.btnRetry.Location = new System.Drawing.Point(166, 14);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(140, 50);
            this.btnRetry.TabIndex = 1;
            this.btnRetry.Text = "Retry";
            this.btnRetry.TextColor = System.Drawing.Color.White;
            this.btnRetry.UseVisualStyleBackColor = false;
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnCancle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnCancle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancle.BorderRadius = 0;
            this.btnCancle.BorderSize = 3;
            this.btnCancle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.ForeColor = System.Drawing.Color.White;
            this.btnCancle.Location = new System.Drawing.Point(311, 14);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(140, 50);
            this.btnCancle.TabIndex = 0;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.TextColor = System.Drawing.Color.White;
            this.btnCancle.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 0;
            this.btnClose.BorderSize = 0;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(758, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 47);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = " ";
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // txtReports
            // 
            this.txtReports.BackColor = System.Drawing.SystemColors.Window;
            this.txtReports.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtReports.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtReports.BorderRadius = 0;
            this.txtReports.BorderSize = 2;
            this.txtReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtReports.ForeColor = System.Drawing.Color.DimGray;
            this.txtReports.Location = new System.Drawing.Point(86, 14);
            this.txtReports.Margin = new System.Windows.Forms.Padding(4);
            this.txtReports.MultiLine = false;
            this.txtReports.Name = "txtReports";
            this.txtReports.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtReports.PasswordChar = false;
            this.txtReports.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtReports.PlaceHolderText = "";
            this.txtReports.Size = new System.Drawing.Size(250, 39);
            this.txtReports.TabIndex = 1;
            this.txtReports.TextBoxText = "";
            this.txtReports.Texts = "";
            this.txtReports.UnderLineStyle = false;
            // 
            // AnyaReports
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(832, 464);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnyaReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AnyaReport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnyaReports_FormClosing);
            this.Load += new System.EventHandler(this.AnyaReports_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxAnya)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private Controls.NavControls.BFC_Close btnClose;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox picboxAnya;
        private Controls.BFC_Button btnOk;
        private Controls.BFC_Button btnRetry;
        private Controls.BFC_Button btnCancle;
        private System.Windows.Forms.Label lblCaption;
        private Controls.BFC_TextBox txtReport;
        private Controls.BFC_TextBox txtReports;
    }
}