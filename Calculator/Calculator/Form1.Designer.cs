namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMain = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonDelimiter = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMain.Location = new System.Drawing.Point(16, 12);
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(250, 29);
            this.tbMain.TabIndex = 0;
            this.tbMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMain_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(23, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(86, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(150, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(23, 134);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 25);
            this.button4.TabIndex = 7;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(86, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 25);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(150, 134);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 25);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(23, 96);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 25);
            this.button7.TabIndex = 10;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(86, 96);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 25);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(150, 96);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 25);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(23, 58);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(77, 25);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackspace.Location = new System.Drawing.Point(118, 58);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(77, 25);
            this.buttonBackspace.TabIndex = 12;
            this.buttonBackspace.Text = "←";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonDelimiter
            // 
            this.buttonDelimiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelimiter.Location = new System.Drawing.Point(118, 210);
            this.buttonDelimiter.Name = "buttonDelimiter";
            this.buttonDelimiter.Size = new System.Drawing.Size(77, 25);
            this.buttonDelimiter.TabIndex = 14;
            this.buttonDelimiter.Text = ",";
            this.buttonDelimiter.UseVisualStyleBackColor = true;
            this.buttonDelimiter.Click += new System.EventHandler(this.buttonDelimiter_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(23, 210);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(77, 25);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivision.Location = new System.Drawing.Point(214, 58);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(45, 25);
            this.buttonDivision.TabIndex = 15;
            this.buttonDivision.Text = "÷";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiply.Location = new System.Drawing.Point(214, 96);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(45, 25);
            this.buttonMultiply.TabIndex = 16;
            this.buttonMultiply.Text = "×";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(214, 134);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(45, 25);
            this.buttonMinus.TabIndex = 17;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(214, 172);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(45, 25);
            this.buttonPlus.TabIndex = 18;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEquals.Location = new System.Drawing.Point(214, 210);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(45, 25);
            this.buttonEquals.TabIndex = 19;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(68, 238);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(145, 13);
            this.labelError.TabIndex = 20;
            this.labelError.Text = "Невозможно деление на 0!";
            this.labelError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 254);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonDelimiter);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonDelimiter;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Label labelError;
    }
}

