namespace cember
{
    partial class Form1
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
            Real1 = new TextBox();
            Real2 = new TextBox();
            Img2 = new TextBox();
            Img1 = new TextBox();
            Button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // Real1
            // 
            Real1.Location = new Point(148, 47);
            Real1.Name = "Real1";
            Real1.Size = new Size(75, 23);
            Real1.TabIndex = 0;
            // 
            // Real2
            // 
            Real2.Location = new Point(148, 95);
            Real2.Name = "Real2";
            Real2.Size = new Size(75, 23);
            Real2.TabIndex = 1;
            // 
            // Img2
            // 
            Img2.Location = new Point(376, 95);
            Img2.Name = "Img2";
            Img2.Size = new Size(78, 23);
            Img2.TabIndex = 2;
            // 
            // Img1
            // 
            Img1.Location = new Point(376, 47);
            Img1.Name = "Img1";
            Img1.Size = new Size(78, 23);
            Img1.TabIndex = 3;
            // 
            // Button1
            // 
            Button1.Location = new Point(96, 175);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 4;
            Button1.Text = "Çarp";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Location = new Point(232, 168);
            label1.Name = "label1";
            label1.Size = new Size(162, 30);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 50);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 6;
            label2.Text = "Real1 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(311, 50);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Img1 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 103);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "Real2 :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 103);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 9;
            label5.Text = "Img2 :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 270);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Button1);
            Controls.Add(Img1);
            Controls.Add(Img2);
            Controls.Add(Real2);
            Controls.Add(Real1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Real1;
        private TextBox Real2;
        private TextBox Img2;
        private TextBox Img1;
        private Button Button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
