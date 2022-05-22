using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class temperature : Form
    {
        temperatureSum tempsum = new temperatureSum();
        double value = 0;
        string sign = "";
        string signNew = "";
        double result = 0;
        List<string> list = new List<string>();
        public temperature()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton6.Enabled = false;
            radioButton5.Enabled = true;
            radioButton4.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton6.Enabled = true;
            radioButton5.Enabled = false;
            radioButton4.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton6.Enabled = true;
            radioButton5.Enabled = true;
            radioButton4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked == true && radioButton5.Checked == true)
            {
                result = (value * (1.8)) + 32;
                sign = "Celcius";
                signNew = "Fahrenheit";
            }
            else if (radioButton1.Checked == true && radioButton4.Checked == true)
            {
                result = value  + 273;
                sign = "Celcius";
                signNew = "Kelvin";
            }
            else if (radioButton2.Checked == true && radioButton6.Checked == true)
            {
                result = (value - 32)/1.8;
                sign = "Fahrenheit";
                signNew = "Celcius";
            }
            else if (radioButton2.Checked == true && radioButton4.Checked == true)
            {
                result = (((value-32)*5)/9) + 273;
                sign = "Fahrenheit";
                signNew = "Kelvin";
            }
            else if (radioButton3.Checked == true && radioButton6.Checked == true)
            {
                result = value - 273;
                sign = "Kelvin";
                signNew = "Celcius";
            }
            else if (radioButton3.Checked == true && radioButton5.Checked == true)
            {
                result = (((value - 273)*9)/5)+32;
                sign = "Kelvin";
                signNew = "Fahrenheit";
            }
            label3.Text = result + " " + signNew;
            list.Add(value + sign + " = " + result + signNew);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(string element in list)
            {
                tempsum.listBox1.Items.Add(element);
            }
            tempsum.Show();
        }
    }
}
