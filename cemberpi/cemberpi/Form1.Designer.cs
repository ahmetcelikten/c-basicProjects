namespace cemberpi
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
            textBoxr = new TextBox();
            label1 = new Label();
            labelalan = new Label();
            labelcevre = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxr
            // 
            textBoxr.Location = new Point(141, 47);
            textBoxr.Name = "textBoxr";
            textBoxr.Size = new Size(100, 23);
            textBoxr.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(86, 47);
            label1.Name = "label1";
            label1.Size = new Size(39, 23);
            label1.TabIndex = 1;
            label1.Text = "r :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelalan
            // 
            labelalan.BackColor = SystemColors.ActiveBorder;
            labelalan.Location = new Point(392, 47);
            labelalan.Name = "labelalan";
            labelalan.Size = new Size(111, 32);
            labelalan.TabIndex = 2;
            labelalan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelcevre
            // 
            labelcevre.BackColor = SystemColors.ActiveBorder;
            labelcevre.Location = new Point(392, 127);
            labelcevre.Name = "labelcevre";
            labelcevre.Size = new Size(111, 32);
            labelcevre.TabIndex = 3;
            labelcevre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(141, 132);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 4;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 56);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Alan : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 136);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Çevre :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 229);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(labelcevre);
            Controls.Add(labelalan);
            Controls.Add(label1);
            Controls.Add(textBoxr);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxr;
        private Label label1;
        private Label labelalan;
        private Label labelcevre;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}
