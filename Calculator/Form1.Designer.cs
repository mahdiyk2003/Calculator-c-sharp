namespace Calculator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.NumericUpDown();
            this.Plusbtn = new System.Windows.Forms.Button();
            this.Minusbtn = new System.Windows.Forms.Button();
            this.Multiplebtn = new System.Windows.Forms.Button();
            this.Dividebtn = new System.Windows.Forms.Button();
            this.Powerbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.textShow = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second number :";
            // 
            // txtNumber2
            // 
            this.txtNumber2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNumber2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNumber2.Location = new System.Drawing.Point(136, 118);
            this.txtNumber2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(223, 22);
            this.txtNumber2.TabIndex = 3;
            // 
            // Plusbtn
            // 
            this.Plusbtn.BackColor = System.Drawing.Color.Black;
            this.Plusbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plusbtn.ForeColor = System.Drawing.Color.White;
            this.Plusbtn.Location = new System.Drawing.Point(79, 195);
            this.Plusbtn.Name = "Plusbtn";
            this.Plusbtn.Size = new System.Drawing.Size(92, 65);
            this.Plusbtn.TabIndex = 4;
            this.Plusbtn.Text = "+";
            this.Plusbtn.UseVisualStyleBackColor = false;
            this.Plusbtn.Click += new System.EventHandler(this.Plusbtn_Click);
            // 
            // Minusbtn
            // 
            this.Minusbtn.BackColor = System.Drawing.Color.Black;
            this.Minusbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minusbtn.ForeColor = System.Drawing.Color.White;
            this.Minusbtn.Location = new System.Drawing.Point(227, 195);
            this.Minusbtn.Name = "Minusbtn";
            this.Minusbtn.Size = new System.Drawing.Size(92, 65);
            this.Minusbtn.TabIndex = 5;
            this.Minusbtn.Text = "-";
            this.Minusbtn.UseVisualStyleBackColor = false;
            this.Minusbtn.Click += new System.EventHandler(this.Minusbtn_Click);
            // 
            // Multiplebtn
            // 
            this.Multiplebtn.BackColor = System.Drawing.Color.Black;
            this.Multiplebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplebtn.ForeColor = System.Drawing.Color.White;
            this.Multiplebtn.Location = new System.Drawing.Point(356, 195);
            this.Multiplebtn.Name = "Multiplebtn";
            this.Multiplebtn.Size = new System.Drawing.Size(92, 65);
            this.Multiplebtn.TabIndex = 6;
            this.Multiplebtn.Text = "*";
            this.Multiplebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Multiplebtn.UseVisualStyleBackColor = false;
            this.Multiplebtn.Click += new System.EventHandler(this.Multiplebtn_Click);
            // 
            // Dividebtn
            // 
            this.Dividebtn.BackColor = System.Drawing.Color.Black;
            this.Dividebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dividebtn.ForeColor = System.Drawing.Color.White;
            this.Dividebtn.Location = new System.Drawing.Point(518, 195);
            this.Dividebtn.Name = "Dividebtn";
            this.Dividebtn.Size = new System.Drawing.Size(92, 65);
            this.Dividebtn.TabIndex = 7;
            this.Dividebtn.Text = "÷";
            this.Dividebtn.UseVisualStyleBackColor = false;
            this.Dividebtn.Click += new System.EventHandler(this.Dividebtn_Click);
            // 
            // Powerbtn
            // 
            this.Powerbtn.BackColor = System.Drawing.Color.Black;
            this.Powerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Powerbtn.ForeColor = System.Drawing.Color.White;
            this.Powerbtn.Location = new System.Drawing.Point(665, 195);
            this.Powerbtn.Name = "Powerbtn";
            this.Powerbtn.Size = new System.Drawing.Size(92, 65);
            this.Powerbtn.TabIndex = 8;
            this.Powerbtn.Text = "^";
            this.Powerbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Powerbtn.UseVisualStyleBackColor = false;
            this.Powerbtn.Click += new System.EventHandler(this.Powerbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(79, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(227, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(356, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 47);
            this.button3.TabIndex = 11;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(518, 284);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 47);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(665, 284);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 47);
            this.button5.TabIndex = 13;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(79, 360);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 47);
            this.button6.TabIndex = 14;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(227, 360);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 47);
            this.button7.TabIndex = 15;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(356, 360);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 47);
            this.button8.TabIndex = 16;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(518, 360);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 47);
            this.button9.TabIndex = 17;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(665, 360);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(92, 47);
            this.button10.TabIndex = 18;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Black;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.Location = new System.Drawing.Point(535, 118);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 41);
            this.button11.TabIndex = 20;
            this.button11.Text = "=";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Black;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(365, 114);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(147, 36);
            this.button12.TabIndex = 21;
            this.button12.Text = "Submit Number";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // textShow
            // 
            this.textShow.BackColor = System.Drawing.Color.Black;
            this.textShow.ForeColor = System.Drawing.Color.White;
            this.textShow.Location = new System.Drawing.Point(136, 21);
            this.textShow.Name = "textShow";
            this.textShow.Size = new System.Drawing.Size(223, 22);
            this.textShow.TabIndex = 22;
            this.textShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumber1
            // 
            this.txtNumber1.BackColor = System.Drawing.Color.Black;
            this.txtNumber1.ForeColor = System.Drawing.Color.White;
            this.txtNumber1.Location = new System.Drawing.Point(136, 69);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(223, 22);
            this.txtNumber1.TabIndex = 23;
            this.txtNumber1.Text = "0";
            this.txtNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Black;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(535, 50);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 41);
            this.button13.TabIndex = 24;
            this.button13.Text = "<×";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Black;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(665, 111);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(92, 67);
            this.button14.TabIndex = 25;
            this.button14.Text = ".";
            this.button14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Black;
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(682, 50);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 41);
            this.button15.TabIndex = 26;
            this.button15.Text = "Reset";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Enter your number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Choose the number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.textShow);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Powerbtn);
            this.Controls.Add(this.Dividebtn);
            this.Controls.Add(this.Multiplebtn);
            this.Controls.Add(this.Minusbtn);
            this.Controls.Add(this.Plusbtn);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtNumber2;
        private System.Windows.Forms.Button Plusbtn;
        private System.Windows.Forms.Button Minusbtn;
        private System.Windows.Forms.Button Multiplebtn;
        private System.Windows.Forms.Button Dividebtn;
        private System.Windows.Forms.Button Powerbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textShow;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

