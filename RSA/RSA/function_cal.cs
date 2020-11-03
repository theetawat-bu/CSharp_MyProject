using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
   public partial class Form1
    {
       static List<int> set_prime = new List<int>();
        public static bool check_validate(Form1 f)
        {

            if (f.First_Text_Prime.Text.Length == 0 || f.Second_Text_Prime.Text.Length == 0 || f.charecter.Text.Length == 0)
            {
                f.richTextBox_showResult.Text = "โปรดกรอกเป็นตัวเลข";
                return false;
            }
            return true;
        }

       
        public static void makePrimeSet()
        {
            

            string now_path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            now_path += "\\primes-to-100k.txt";
            Console.WriteLine(now_path);
            string[] lines = System.IO.File.ReadAllLines(now_path);
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                set_prime.Add(int.Parse(line));

            }

        }
        public static int gcd(int a, int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }
    }
}
