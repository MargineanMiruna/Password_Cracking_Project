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
    public partial class Form1 : Form
    {
        string nm = "";

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (Daten.lv == 0 || Daten.lv == 1)
            {
                if (Daten.Name != "")
                    nm = " " + Daten.Name + "!";
                label1.Text = Daten.Str.ReadLine();
                label2.Text = nm;
                label2.Left -= nm.Length * 10;
                label1.Visible = true;
                label2.Visible = true;
                await Task.Delay(2000);
                label1.Visible = false;
                label2.Visible = false;
                label1.Text = Daten.Str.ReadLine();
                await Task.Delay(1000);
                label1.Visible = true;
                await Task.Delay(2000);
                label1.Visible = false;
                label1.Text = Daten.Str.ReadLine();
                label2.Text = Daten.Str.ReadLine();
                label2.Left = 130;
                await Task.Delay(1000);
                label1.Visible = true;
                label2.Visible = true;
                await Task.Delay(2000);
                label1.Visible = false;
                Form2 F = new Form2();
                F.Show();
                this.Hide();
            }
            else
            {
                label1.Text = Daten.Str.ReadLine();
                label1.Visible = true;
                await Task.Delay(2000);
                label1.Visible = false;
                label1.Text = Daten.Str.ReadLine();
                await Task.Delay(1000);
                label1.Visible = true;
                button1.Visible = true;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
                timer1.Stop();
            Opacity += .2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 F = new Form3();
            F.Show();
            this.Hide();
        }
    }
}
