namespace MegaDesk_Project
{
    partial class AddQuote
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
            label1 = new Label();
            label2 = new Label();
            Depth = new NumericUpDown();
            Width = new NumericUpDown();
            Drawers = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            Material = new ComboBox();
            label5 = new Label();
            Rush = new ComboBox();
            label6 = new Label();
            CustomerName = new TextBox();
            GetQuote = new Button();
            Cancel = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)Depth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Width).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Drawers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(86, 124);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Depth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(87, 188);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Width";
            // 
            // Depth
            // 
            Depth.Location = new Point(86, 142);
            Depth.Maximum = new decimal(new int[] { 48, 0, 0, 0 });
            Depth.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
            Depth.Name = "Depth";
            Depth.Size = new Size(150, 23);
            Depth.TabIndex = 0;
            Depth.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // Width
            // 
            Width.Location = new Point(86, 206);
            Width.Maximum = new decimal(new int[] { 96, 0, 0, 0 });
            Width.Minimum = new decimal(new int[] { 24, 0, 0, 0 });
            Width.Name = "Width";
            Width.Size = new Size(150, 23);
            Width.TabIndex = 1;
            Width.Value = new decimal(new int[] { 24, 0, 0, 0 });
            // 
            // Drawers
            // 
            Drawers.Location = new Point(389, 142);
            Drawers.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            Drawers.Name = "Drawers";
            Drawers.Size = new Size(150, 23);
            Drawers.TabIndex = 4;
            Drawers.Value = new decimal(new int[] { 7, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(265, 150);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 5;
            label3.Text = "Number of Drawers";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(287, 191);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 6;
            label4.Text = "Surfice Material";
            // 
            // Material
            // 
            Material.FormattingEnabled = true;
            Material.Items.AddRange(new object[] { "Laminate", "Oak", "Rosewood", "Veneer", "Pine" });
            Material.Location = new Point(389, 188);
            Material.Name = "Material";
            Material.Size = new Size(150, 23);
            Material.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(313, 238);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 8;
            label5.Text = "Rush Order";
            // 
            // Rush
            // 
            Rush.FormattingEnabled = true;
            Rush.Items.AddRange(new object[] { "0", "3 Days", "5 Days", "7 Days" });
            Rush.Location = new Point(389, 235);
            Rush.Name = "Rush";
            Rush.Size = new Size(150, 23);
            Rush.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(118, 64);
            label6.Name = "label6";
            label6.Size = new Size(133, 21);
            label6.TabIndex = 10;
            label6.Text = "Customer Name";
            // 
            // CustomerName
            // 
            CustomerName.Location = new Point(257, 66);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(150, 23);
            CustomerName.TabIndex = 11;
            // 
            // GetQuote
            // 
            GetQuote.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GetQuote.Location = new Point(136, 288);
            GetQuote.Name = "GetQuote";
            GetQuote.Size = new Size(127, 37);
            GetQuote.TabIndex = 12;
            GetQuote.Text = "Get Quote";
            GetQuote.UseVisualStyleBackColor = true;
            GetQuote.Click += GetQuote_Click;
            // 
            // Cancel
            // 
            Cancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Cancel.Location = new Point(313, 288);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(127, 37);
            Cancel.TabIndex = 13;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(265, 9);
            label7.Name = "label7";
            label7.Size = new Size(114, 28);
            label7.TabIndex = 14;
            label7.Text = "Add Quote";
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 360);
            Controls.Add(label7);
            Controls.Add(Cancel);
            Controls.Add(GetQuote);
            Controls.Add(CustomerName);
            Controls.Add(label6);
            Controls.Add(Rush);
            Controls.Add(label5);
            Controls.Add(Material);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Drawers);
            Controls.Add(Width);
            Controls.Add(Depth);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddQuote";
            Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)Depth).EndInit();
            ((System.ComponentModel.ISupportInitialize)Width).EndInit();
            ((System.ComponentModel.ISupportInitialize)Drawers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown Depth;
        private NumericUpDown Width;
        private NumericUpDown Drawers;
        private Label label3;
        private Label label4;
        private ComboBox Material;
        private Label label5;
        private ComboBox Rush;
        private Label label6;
        private TextBox CustomerName;
        private Button GetQuote;
        private Button Cancel;
        private Label label7;
    }
}