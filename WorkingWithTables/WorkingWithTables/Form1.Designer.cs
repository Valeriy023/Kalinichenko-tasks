namespace WorkingWithTables
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
            this.components = new System.ComponentModel.Container();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(20, 43);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(120, 20);
            this.tbLastName.TabIndex = 0;
            this.tbLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLastName_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberColumn,
            this.lastnameColumn,
            this.nameColumn,
            this.patronymicColumn,
            this.birthdateColumn});
            this.dataGridView1.Location = new System.Drawing.Point(168, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 233);
            this.dataGridView1.TabIndex = 1;
            // 
            // numberColumn
            // 
            this.numberColumn.HeaderText = "№";
            this.numberColumn.Name = "numberColumn";
            this.numberColumn.Width = 30;
            // 
            // lastnameColumn
            // 
            this.lastnameColumn.HeaderText = "Фамилия";
            this.lastnameColumn.Name = "lastnameColumn";
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Имя";
            this.nameColumn.Name = "nameColumn";
            // 
            // patronymicColumn
            // 
            this.patronymicColumn.HeaderText = "Отчество";
            this.patronymicColumn.Name = "patronymicColumn";
            // 
            // birthdateColumn
            // 
            this.birthdateColumn.HeaderText = "Дата рождения";
            this.birthdateColumn.Name = "birthdateColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(20, 91);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(120, 20);
            this.tbName.TabIndex = 3;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отчество";
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Location = new System.Drawing.Point(20, 141);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(120, 20);
            this.tbPatronymic.TabIndex = 5;
            this.tbPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPatronymic_KeyPress);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(20, 192);
            this.dtp.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(120, 20);
            this.dtp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата рождения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(4, 6);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(163, 13);
            this.labelError.TabIndex = 11;
            this.labelError.Text = "Заполните необходимые поля!";
            this.labelError.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Заполните поля ФИО с большой буквы и выберите дату рождения.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(69, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(41, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 272);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbLastName);
            this.Name = "Form1";
            this.Text = "People Recording";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

