using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Atestat_Projekt
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int n , s = 0;
        int[] st = new int[100];
        string wrt, pw;
        string[] b = new string[100];
        StreamReader sr = new StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\buchstb.txt");

        private void Form4_Load(object sender, EventArgs e)
        {
            Daten.bonus[0]++;
            wrt = Daten.Password;
            n = wrt.Length;

            for (int i = 0; i < 74; i++)
                b[i] = sr.ReadLine();
        }

        bool Solutie(int k)
        {
            if (k + 1 != n)
                return false;
            s++;
            return true;
        }

        void Afis()
        {
            pw = string.Empty;
            for (int i = 0; i < n; i++)
            {
                pw += b[st[i]];

                if (wrt.CompareTo(pw) == 0)
                {
                    label1.Text = pw;
                    label1.Visible = true;
                    label3.Text = "It took " + s + " tries to guess the password";
                    Daten.s = s;
                }
            }
        }

        void Backt(int k)
        {
            for (int i = 0; i < 74; i++)
            {
                st[k] = i;
                if (Solutie(k))
                    Afis();
                else
                    Backt(k + 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (wrt.Length < 5)
                Backt(0);
            else
            {
                label2.Text = "Your password will take too long to be guessed.";
                label2.Left -= 150;
            }
           label2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 F = new Form3();
            this.Hide();
            F.Show();
        }
    }
}
