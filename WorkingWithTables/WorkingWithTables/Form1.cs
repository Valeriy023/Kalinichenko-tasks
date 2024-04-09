using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingWithTables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtp.MaxDate = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            if (tbLastName.Text == "" && tbName.Text == "" && tbPatronymic.Text == "") 
            {
                tbLastName.Text = "Примеров";
                tbName.Text = "Пример";
                tbPatronymic.Text = "Примерович";
            }
            char lastsymbol = tbLastName.Text.Last();
            if (tbLastName.Text != "" && tbName.Text != "" && lastsymbol != 45) //отчества может не быть
            {
                int number = dataGridView1.Rows.Count;
                string lastName = tbLastName.Text;
                string name = tbName.Text;
                string patronymic = tbPatronymic.Text;
                string birthdate = dtp.Text;
                dataGridView1.Rows.Add(number, lastName, name, patronymic, birthdate);
            }
            else 
            { 
                this.labelError.Visible = true;
            }
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbLastName.Text == "")
            {
                char letter = e.KeyChar;
                if (!Char.IsUpper(letter) && letter != 8)
                {
                    e.Handled = true;
                }
            }
            else
            {
                char letter = e.KeyChar;
                char lastsymbol = tbLastName.Text.Last();
                if (lastsymbol == 45 && letter == 45)
                {
                    e.Handled = true;
                }
                if (lastsymbol == 45 & !Char.IsUpper(letter) && letter != 8)
                {
                    e.Handled = true;
                }
                if (!Char.IsLetter(letter) && letter != 8 && letter != 45)
                {
                    e.Handled = true;
                }
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbName.Text == "")
            {
                char letter = e.KeyChar;
                if (!Char.IsUpper(letter) && letter != 8)
                {
                    e.Handled = true;
                }
            }
            else
            {
                char letter = e.KeyChar;
                char lastsymbol = tbName.Text.Last();
                if (lastsymbol == 45 && letter == 45)
                {
                    e.Handled = true;
                }
                if (lastsymbol == 45 & !Char.IsUpper(letter) && letter != 8)
                {
                    e.Handled = true;
                }
                if (!Char.IsLetter(letter) && letter != 8 && letter != 45)
                {
                    e.Handled = true;
                }
            }
        }

        private void tbPatronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbPatronymic.Text == "")
            {
                char letter = e.KeyChar;
                if (!Char.IsUpper(letter) && letter != 8)
                {
                    e.Handled = true;
                }
            }
            else
            {
                char letter = e.KeyChar;
                if (!Char.IsLetter(letter) && letter != 8)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
