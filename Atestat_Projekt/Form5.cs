using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Projekt
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int n, s = 0, ok = 0;
        string wrt, pw, pw2;
        StreamReader sr = new StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\dictionary.txt");

        private void Form5_Load(object sender, EventArgs e)
        {
            Daten.bonus[1]++;
            wrt = Daten.Password;
            n = wrt.Length;
            for (int i = 0; i < n; i++)
                pw2 += '_';
        }

        void Afis(string c)
        {
            label2.Text = c;
            label2.Visible = true;
            label3.Text = "It took " + s + " tries to guess the password";
            label3.Visible = true;
            Daten.t = s;
        }

        void Dict()
        {
            while(!sr.EndOfStream) 
            {
                pw = sr.ReadLine();
                s++;
                if (pw == wrt)
                {
                    ok ++;
                    Afis(pw);
                    break;
                }
                else if(wrt.Contains(pw))
                {
                    int st = 0;
                    int pos = wrt.IndexOf(pw, st);
                    while (pos != -1) 
                    {
                        pw2 = pw2.Remove(pos, pw.Length).Insert(pos, pw);
                        st += pw.Length;
                        pos = wrt.IndexOf(pw, st);
                    }
                    if (pw2 == wrt)
                    {
                        Afis(pw2);
                        ok ++;
                    }    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 F = new Form3();
            this.Hide();
            F.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dict();
            if (ok == 0)
            {
                label1.Left -= 70;
                label1.Text = "I couldn't guess your password.";
            }
            else label1.Text = "Your password is:";
        }
       
    }
}
