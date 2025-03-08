using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Atestat_Projekt
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\btn3 (2).jfif");
            button3.Text = "Rainbow";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\btn3.jfif");
            button3.Text = "";
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\btn2 (2).jfif");
            button2.Text = "Dictionary";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\btn2.jfif");
            button2.Text = "";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\btn1 (2).jfif");
            button1.Text = "Brute Force";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\btn1.jfif");
            button1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 F = new Form4();
            F.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 F = new Form5();
            F.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 F = new Form6();
            F.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Daten.bonus[0] > 0 && Daten.bonus[1] > 0 && Daten.bonus[2] > 0)
            {
                button4.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 F = new Form7();
            F.Show();
            this.Hide();
        }
    }
}
