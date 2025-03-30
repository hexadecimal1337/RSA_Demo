namespace RSA {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            button4 = new Button();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            button5 = new Button();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            button6 = new Button();
            label7 = new Label();
            label8 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label9 = new Label();
            button7 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(515, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(381, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(88, 398);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(837, 23);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(217, 84);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 3;
            button1.Text = "Сгенерировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(662, 84);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 4;
            button2.Text = "Сгенерировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(338, 439);
            button3.Name = "button3";
            button3.Size = new Size(103, 23);
            button3.TabIndex = 5;
            button3.Text = "Зашифровать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(88, 477);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(837, 23);
            textBox4.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(235, 31);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 7;
            label1.Text = "число P";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(677, 31);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 8;
            label2.Text = "число Q";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(31, 22);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(787, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(31, 66);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(787, 23);
            textBox6.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Location = new Point(69, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(846, 129);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Открытый ключ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(9, 64);
            label4.Name = "label4";
            label4.Size = new Size(18, 21);
            label4.TabIndex = 13;
            label4.Text = "e";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 25);
            label3.Name = "label3";
            label3.Size = new Size(16, 15);
            label3.TabIndex = 12;
            label3.Text = "N";
            // 
            // button4
            // 
            button4.Location = new Point(278, 95);
            button4.Name = "button4";
            button4.Size = new Size(133, 23);
            button4.TabIndex = 11;
            button4.Text = "Сгенерировать";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Location = new Point(69, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(846, 129);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Закрытый ключ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(9, 64);
            label5.Name = "label5";
            label5.Size = new Size(19, 21);
            label5.TabIndex = 13;
            label5.Text = "d";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 25);
            label6.Name = "label6";
            label6.Size = new Size(16, 15);
            label6.TabIndex = 12;
            label6.Text = "N";
            // 
            // button5
            // 
            button5.Location = new Point(352, 95);
            button5.Name = "button5";
            button5.Size = new Size(133, 23);
            button5.TabIndex = 11;
            button5.Text = "Сгенерировать";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(31, 22);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(787, 23);
            textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(31, 66);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(787, 23);
            textBox8.TabIndex = 10;
            // 
            // button6
            // 
            button6.Location = new Point(576, 439);
            button6.Name = "button6";
            button6.Size = new Size(100, 23);
            button6.TabIndex = 13;
            button6.Text = "Расшифровать";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 401);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 14;
            label7.Text = "Сообщение";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 480);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 15;
            label8.Text = "Результат";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(100, 427);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(55, 19);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "Текст";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(100, 452);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 19);
            radioButton2.TabIndex = 17;
            radioButton2.Text = "Число";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 439);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 18;
            label9.Text = "Тип";
            // 
            // button7
            // 
            button7.Location = new Point(457, 95);
            button7.Name = "button7";
            button7.Size = new Size(94, 23);
            button7.TabIndex = 19;
            button7.Text = "Взломать";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 534);
            Controls.Add(label9);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "RSA";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox6;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Button button4;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private Button button5;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button6;
        private Label label7;
        private Label label8;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label9;
        private Button button7;
    }
}
