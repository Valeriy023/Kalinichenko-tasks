using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_me
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x_val = rnd.Next(0, 800 - this.btnYes.Size.Width);
            int y_val = rnd.Next(0, 600 - this.btnYes.Size.Height * 2);
            this.btnYes.Location = new System.Drawing.Point(x_val, y_val);
        }
    }
}
