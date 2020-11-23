using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool visible = true;
            Console.WriteLine(comboBox1.Text);

            if (comboBox1.Text == "CK_CNT")
            {

                Parameter1.Text = "TIM_CLK";
                Parameter2.Text = "PSC";
                Parameter3.Text = "ARR";
            }else if (comboBox1.Text == "TIM_CLK")
            {
                visible = !visible;
                Parameter1.Text = "CK_CNT";
                Parameter2.Text = "PSC";
                Parameter3.Text = "ARR";
            }
            else if (comboBox1.Text == "PSC")
            {
                
                Parameter1.Text = "TIM_CLK";
                Parameter2.Text = "CK_CNT";
                Parameter3.Text = "ARR";
            }
            else if (comboBox1.Text == "ARR")
            {
                
                Parameter1.Text = "TIM_CLK";
                Parameter2.Text = "CK_CNT";
                Parameter3.Text = "PSC";
            }

            comboBox2.Visible = visible;




        }

        private void button_cal_Click(object sender, EventArgs e)
        {
            double result;
            int factor=1;
            if (comboBox2.Text == "Mhz")
            {
                factor = 1_000_000;
            }
            result = Double.Parse(textBox1.Text)*factor / ((Double.Parse(textBox2.Text) + 1) * (Double.Parse(textBox3.Text) + 1));

            textBox4.Text = result.ToString();
            textBox_delay.Text = (1 / result).ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
