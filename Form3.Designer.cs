﻿namespace WinFormsApp10
{
    partial class Form3
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 24);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Member Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 86);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "User ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 167);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "User Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 239);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 3;
            label4.Text = "User Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 304);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "User Tel No.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 372);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 5;
            label6.Text = "Book Id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(296, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(296, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(296, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(246, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(296, 304);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(246, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(296, 372);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(246, 27);
            textBox5.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(273, 463);
            button2.Name = "button2";
            button2.Size = new Size(132, 115);
            button2.TabIndex = 12;
            button2.Text = "Search book";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 601);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button2;
    }
}