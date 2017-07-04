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
    public partial class Form2 : Form
    {
        int test = 0;
        public Form2()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("Test " + test);
            test++;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString().Split(' ')[0];
            textBox2.Text = listBox1.SelectedItem.ToString().Split(' ')[1];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                
                listBox1.Items[listBox1.SelectedIndex] = textBox1.Text + " " + textBox2.Text;
            }

        }
    }
}
