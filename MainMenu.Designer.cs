﻿namespace MegaDesk_Project
{
    partial class MainMenu
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(79, 38);
            button1.Name = "button1";
            button1.Size = new Size(275, 89);
            button1.TabIndex = 0;
            button1.Text = "Add New Quote";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(79, 133);
            button2.Name = "button2";
            button2.Size = new Size(275, 89);
            button2.TabIndex = 1;
            button2.Text = "View Quotes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(79, 228);
            button3.Name = "button3";
            button3.Size = new Size(275, 89);
            button3.TabIndex = 2;
            button3.Text = "Search Quotes";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(79, 323);
            button4.Name = "button4";
            button4.Size = new Size(275, 89);
            button4.TabIndex = 3;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.desk;
            pictureBox1.Location = new Point(400, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 312);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainMenu";
            Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
    }
}