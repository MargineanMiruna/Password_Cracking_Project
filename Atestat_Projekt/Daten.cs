using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Atestat_Projekt
{
    class Daten
    {
        public static string Name = "";
        public static string Password;
        public static StreamReader Str = new StreamReader("messages.txt");
        public static int lv = 0;
        public static int[] bonus = new int[4];
        public static int s, t, r;
    }
}
