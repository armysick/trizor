using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
<<<<<<< HEAD
            if (textBox1.Text.ToUpper() == "" && textBox2.Text == "")
=======
            if (textBox1.Text.ToUpper() == "TRIZOR3" && textBox2.Text == "cartof")
>>>>>>> 14dad27f467347afa0e4781920c5a15822296b3c
            {
                f2.Show();
                this.Hide();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
