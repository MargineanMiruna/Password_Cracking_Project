using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Projekt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Daten.lv == 0)
                textBox1.Visible = true;
            else
                textBox2.Visible = true;   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
                timer1.Stop();
            Opacity += .2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Daten.lv == 0 && textBox1.Text != "Enter your name" && textBox1.Text != "") 
            {
                Daten.Name = textBox1.Text;
                Daten.lv++;
                Form1 F = new Form1();
                F.Show();
                this.Hide();
            }
            else if (Daten.lv == 1 && textBox2.Text != "Enter your password" && textBox2.Text != "")
            {
                Daten.Password = textBox2.Text;
                Daten.lv++;
                Form1 F = new Form1();
                F.Show();
                this.Hide();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }
    }
}
