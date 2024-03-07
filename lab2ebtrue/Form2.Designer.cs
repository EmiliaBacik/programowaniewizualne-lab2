namespace lab2ebtrue
{
    partial class Form2
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label6 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Intel core i5", "Intel core i7", "Intel core i9" });
            comboBox1.Location = new Point(42, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(89, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 20);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Komputer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 57);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Procesor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 57);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 4;
            label3.Text = "zł";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 125);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 5;
            label4.Text = "Dysk";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(89, 23);
            textBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(175, 125);
            label5.Name = "label5";
            label5.Size = new Size(15, 15);
            label5.TabIndex = 7;
            label5.Text = "zł";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(42, 158);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(84, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "240 GB SSD";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(42, 183);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(90, 19);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "500 GB SATA";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(42, 208);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(96, 19);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "1000 GB SATA";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 250);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 12;
            label6.Text = "Reszta: 1000zł";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 299);
            Controls.Add(label6);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label6;
    }
}