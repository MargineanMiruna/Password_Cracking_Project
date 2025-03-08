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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        int ok = 0, ok1 = 0, ok2 = 0;
        StreamReader sy = new StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\symbols.txt");
        StreamReader nr = new StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\numbers.txt");
        StreamReader up = new StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\capital.txt");

        private void Analysis()
        {
            label2.Text = Daten.Password;
            label2.Visible = true;
            if (Daten.s != 0 && Daten.t != 0 && Daten.r != 0)
            {
                label3.Text = "Weak password!\nAll algorithms guessed your password.\nBrute Force: " + Daten.s + " tries\nDictionary: " + Daten.t + " tries";
                label3.ForeColor = Color.Red;
                label4.Text = "You should:\n- add numbers\n- add at least 8 characters\n- add symbols\n- not use ordinary words";
                if (ok2 == 0) label4.Text += "\n- add capital letters";
                if (Daten.Password.Contains(Daten.Name)) label4.Text += "\n- not include personal data";
            }     
            else if (Daten.s != 0 && Daten.t != 0 && Daten.r == 0)
            {
                
                label3.Text = "Short password!\n2 algorithms guessed your password.\nBrute Force: " + Daten.s + " tries\nDictionary: " + Daten.t + " tries";
                label4.Text = "You should:\n- add at least 8 characters";
                if (ok1 == 0) label4.Text += "\n- add numbers";
                if (ok == 0) label4.Text += "\n- add symbols";
                if (Daten.Password.Contains(Daten.Name)) label4.Text += "\n- not include personal data";
                if (ok2 == 0) label4.Text += "\n- add capital letters";

            }   
            else if (Daten.s == 0 && Daten.t != 0 && Daten.r != 0)
            {
                label3.Text = "Simple password!\n2 algorithms guessed your password.\nDictionary: " + Daten.t + " tries";
                label4.Text = "You should:\n- add numbers\n- add symbols\n- not use ordinary words";
                if (Daten.Password.Length < 8) label4.Text += "\n- add at least 8 characters";
                if (ok2 == 0) label4.Text += "\n- add capital letters";
                if (Daten.Password.Contains(Daten.Name)) label4.Text += "\n- not include personal data";
            }
            else if (Daten.s == 0 && Daten.t != 0 && Daten.r == 0)
            {
                int obj = 0;
                label3.ForeColor = Color.ForestGreen;
                if (Daten.t > 150000)
                    label3.Text = "Strong password!\nOnly one algorithm guessed your password.\nDictionary: " + Daten.t + " tries";
                else
                    label3.Text = "Good password!\nOnly one algorithm guessed your password.\nDictionary: " + Daten.t + " tries";
                label4.Text = "You should:";
                if (ok1 == 0) { label4.Text += "\n- add numbers"; obj++; }
                if (ok == 0) { label4.Text += "\n- add symbols"; obj++; }
                if (Daten.Password.Length < 8) { label4.Text += "\n- add at least 8 characters"; obj++; }
                if (Daten.Password.Contains(Daten.Name)) { label4.Text += "\n- not include personal data"; obj++; }
                if (ok2 == 0) { label4.Text += "\n- add capital letters"; obj++; }

                if (obj == 0) label4.Text = "Your password includes all aspects\nneeded to build a strong password!"; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Let's analyse your password, " + Daten.Name + ":";
            button1.Visible = false;
            button2.Text = "Finish";
            Analysis();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            while (!sy.EndOfStream)
            {
                string s = sy.ReadLine();
                if (Daten.Password.Contains(s))
                    ok = 1;
            }
            
            while (!nr.EndOfStream)
            {
                string s = nr.ReadLine();
                if(Daten.Password.Contains(s))
                    ok1 = 1;
            }

            while (!up.EndOfStream)
            {
                string s = up.ReadLine();
                if (Daten.Password.Contains(s))
                    ok2 = 1;
            }
        }
    }
}
