using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.IO;

namespace Atestat_Projekt
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        string wrt, pw, hashwrt, hashpw;
        StreamReader sr = new StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\dictionary.txt");

        string hash(string s)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));
            string hexString = BitConverter.ToString(hashValue).Replace("-", "");
            return hexString;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Daten.bonus[2]++;
            wrt = Daten.Password;
            hashwrt = hash(wrt);
        }

        void Afis()
        {
            label2.Text = "Your password is:";
            label1.Text = pw;
            label3.Text = hashpw;
            label2.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
        }

        void Rainb()
        {
            while(!sr.EndOfStream)
            {
                pw = sr.ReadLine();
                hashpw = hash(pw);
                if (hashpw == hashwrt)
                { 
                    Afis();
                    Daten.r = 1;
                    break;
                }   
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rainb();
            if (label2.Visible == false)
            {
                label2.Text = "Couldn't guess your password:((";
                label2.Left -= 80;
                label2.Visible = true;
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

        
    }
}
