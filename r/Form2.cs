﻿using System;
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
        //int test = 0;
        //int testo = 1;
        //int testd = 2;
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
            DataTable dt = new DataTable();
            dt.TableName = "Employee";

            DataColumn text1 = new DataColumn("Name");
            DataColumn text2 = new DataColumn("LastName");
            DataColumn text3 = new DataColumn("Phone");
            DataColumn text4 = new DataColumn("Salary");

            dt.Columns.Add(text1);
            dt.Columns.Add(text2);
            dt.Columns.Add(text3);
            dt.Columns.Add(text4);

            DataSet ds = new DataSet();
            ds.DataSetName = "Pokemon";

            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text);

            foreach (Object obiect in listBox1.Items)
            {
                dt.Rows.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text);
            };

            ds.Tables.Add(dt);
            ds.WriteXml("Employeers.xml");

            //test++;
            //testo++;
            //testd++;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {

                listBox1.Items[listBox1.SelectedIndex] = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text;
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                textBox1.Text = listBox1.SelectedItem.ToString().Split(' ')[0];
                textBox2.Text = listBox1.SelectedItem.ToString().Split(' ')[1];
                textBox3.Text = listBox1.SelectedItem.ToString().Split(' ')[2];
                textBox4.Text = listBox1.SelectedItem.ToString().Split(' ')[3];
            }
            catch (Exception)
            {

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int val = trackBar1.Value;


            if (val <= 255)
                this.BackColor = Color.FromArgb(0, trackBar1.Value, 0);
            else if (val <= 510)
                this.BackColor = Color.FromArgb(0, 0, trackBar1.Value - 255);
            else if (val <= 765)
                this.BackColor = Color.FromArgb(0, trackBar1.Value - 510, trackBar1.Value - 510);
            else if (val <= 1020)
                this.BackColor = Color.FromArgb(trackBar1.Value - 765, 0, 0);
            else if (val <= 1275)
                this.BackColor = Color.FromArgb(trackBar1.Value - 1020, trackBar1.Value - 1020, 0);
            else if (val <= 1530)
                this.BackColor = Color.FromArgb(trackBar1.Value - 1275, 0, trackBar1.Value - 1275);
            else if (val <= 1785)
                this.BackColor = Color.FromArgb(trackBar1.Value - 1530, trackBar1.Value - 1530, trackBar1.Value - 1530);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                while (listBox1.SelectedIndex != -1)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
