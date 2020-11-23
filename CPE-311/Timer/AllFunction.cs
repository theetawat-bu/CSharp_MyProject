using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
   public partial class AllFunction : Form
    {
        public static void calit()
        {
            double result;
            int factor = 1;
            if (comboBox2.Text == "Mhz")
            {
                factor = 1_000_000;
            }
            result = Double.Parse(textBox1.Text) * factor / ((Double.Parse(textBox2.Text) + 1) * (Double.Parse(textBox3.Text) + 1));

            textBox4.Text = result.ToString();
            textBox_delay.Text = (1 / result).ToString();
        }
    }
}
