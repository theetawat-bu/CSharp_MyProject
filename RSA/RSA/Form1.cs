using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void BT_Calculate_Click(object sender, EventArgs e)
        {
            richTextBox_showResult.Text = "";
            if (check_validate(this))
            {

                int n, totie, E, d;
                int prime_num1 = int.Parse(First_Text_Prime.Text);
                int prime_num2 = int.Parse(Second_Text_Prime.Text);
                int msg = int.Parse(charecter.Text);

                Random random = new Random(10);

                richTextBox_showResult.Text = "";

           


                richTextBox_showResult.AppendText("Select primes: p=" + prime_num1 + "& q=" + prime_num2);
                n = prime_num1 * prime_num2;
                richTextBox_showResult.AppendText("\nCompute N = pq = " + prime_num1 + " x " + prime_num2 + " = " + n);
                totie = (prime_num1 - 1) * (prime_num2 - 1);
                richTextBox_showResult.AppendText("\nCompute N = (p-1)(q-1) = " + (prime_num1 - 1) + " x " + (prime_num2 - 1) + " = " + totie);

                for (E = 2; gcd(E, totie) != 1; E++) ;
                richTextBox_showResult.AppendText("\nSelect e : gcd(e," + totie + ")=1;");
               

                while (true)
                {
                  
                    d = random.Next(totie);
                    E++;
                    for (; gcd(E, totie) != 1; E++) ;
                    E = E % 100;

                    if (d * E == totie + 1)
                    {

                        break;
                    }
                }
                richTextBox_showResult.AppendText("\nChoose e = " + E);
                richTextBox_showResult.AppendText("\nDetermine d: de=1 mod " + totie + " and d<" + totie);
                richTextBox_showResult.AppendText("\nValue is d = " + d + " since " + d + "x" + E + "=" + (d * E) + "=" + 1 + "x" + totie + "+" + 1);
                richTextBox_showResult.AppendText("\nPublish public key KU={" + E + "," + n + "}");
                richTextBox_showResult.AppendText("\nKeep secret private key KR={" + d + "," + prime_num1 + "," + prime_num2 + "}");

                //Encrption

                richTextBox_showResult.AppendText("\nGiven Message M = " + msg);
                richTextBox_showResult.AppendText("\nEncryption:");
                BigInteger result_Encrption = BigInteger.Pow(msg, E);

                richTextBox_showResult.AppendText("\nC = " + msg + "^" + E + " mod " + n + " = " + result_Encrption % n);
                richTextBox_showResult.AppendText("\nDecryption:");
                BigInteger result_Decryption = BigInteger.Pow(result_Encrption % n, d);
                richTextBox_showResult.AppendText("\nM = " + result_Encrption % n + "^" + d + " mod " + n + " = " + result_Decryption % n);


            }
        }

       

        private void Random1_Click(object sender, EventArgs e)
        {
         
            Random random = new Random();
            First_Text_Prime.Text = set_prime[random.Next(set_prime.Count)].ToString();
            
        }

        private void Random2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Second_Text_Prime.Text = set_prime[random.Next(set_prime.Count)].ToString();
        }

   

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            makePrimeSet();
        }
    }
}
