﻿namespace CST_150_Activity_3
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            lblSelectedFile = new Label();
            lblResults = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.DarkOliveGreen;
            button1.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(329, 140);
            button1.Name = "button1";
            button1.Size = new Size(137, 48);
            button1.TabIndex = 0;
            button1.Text = "Read File";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblSelectedFile
            // 
            lblSelectedFile.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectedFile.ForeColor = Color.Firebrick;
            lblSelectedFile.Location = new Point(0, 414);
            lblSelectedFile.Name = "lblSelectedFile";
            lblSelectedFile.Size = new Size(799, 23);
            lblSelectedFile.TabIndex = 1;
            lblSelectedFile.Text = "label1";
            lblSelectedFile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(378, 243);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(38, 15);
            lblResults.TabIndex = 2;
            lblResults.Text = "label1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResults);
            Controls.Add(lblSelectedFile);
            Controls.Add(button1);
            Name = "FrmMain";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblSelectedFile;
        private Label lblResults;
    }
}
