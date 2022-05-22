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
    public partial class uzunluk : Form
    {
        uzunlukSum uz = new uzunlukSum();
        List<string> results = new List<string> ();
        double value = 0;
        double result = 0;
        double rate = 0;
        string measureUnit = "";
        string measureUnitNew = "";
        public uzunluk()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton10.Enabled = false;
            radioButton9.Enabled = true;
            radioButton8.Enabled = true;
            radioButton7.Enabled = true;
            radioButton6.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton10.Enabled = true;
            radioButton9.Enabled = false;
            radioButton8.Enabled = true;
            radioButton7.Enabled = true;
            radioButton6.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton10.Enabled = true;
            radioButton9.Enabled = true;
            radioButton8.Enabled = false;
            radioButton7.Enabled = true;
            radioButton6.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton10.Enabled = true;
            radioButton9.Enabled = true;
            radioButton8.Enabled = true;
            radioButton7.Enabled = false;
            radioButton6.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton10.Enabled = true;
            radioButton9.Enabled = true;
            radioButton8.Enabled = true;
            radioButton7.Enabled = true;
            radioButton6.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = Convert.ToDouble(textBox1.Text);

            if (radioButton1.Checked == true && radioButton9.Checked == true)
            {
                measureUnit = "Santimetre";
                measureUnitNew = "Metre";
                rate = 0.01;
            }
            else if (radioButton1.Checked == true && radioButton8.Checked == true)
            {
                measureUnit = "Santimetre";
                measureUnitNew = "Kilometre";
                rate = 0.00001;
            }
            else if (radioButton1.Checked == true && radioButton7.Checked == true)
            {
                measureUnit = "Santimetre";
                measureUnitNew = "İnç";
                rate = 0.393701;
            }
            else if (radioButton1.Checked == true && radioButton8.Checked == true)
            {
                measureUnit = "Santimetre";
                measureUnitNew = "Mil";
                rate = 0.000006;
            }
            else if (radioButton2.Checked == true && radioButton10.Checked == true)
            {
                measureUnit = "Metre";
                measureUnitNew = "Santimetre";
                rate = 100;
            }
            else if (radioButton2.Checked == true && radioButton8.Checked == true)
            {
                measureUnit = "Metre";
                measureUnitNew = "Kilometre";
                rate = 0.001;
            }
            else if (radioButton2.Checked == true && radioButton7.Checked == true)
            {
                measureUnit = "Metre";
                measureUnitNew = "İnç";
                rate = 39.37008;
            }
            else if (radioButton2.Checked == true && radioButton6.Checked == true)
            {
                measureUnit = "Metre";
                measureUnitNew = "Mil";
                rate = 0.000621;
            }
            else if (radioButton3.Checked == true && radioButton10.Checked == true)
            {
                measureUnit = "Kilometre";
                measureUnitNew = "Santimetre";
                rate = 100000;
            }
            else if (radioButton3.Checked == true && radioButton9.Checked == true)
            {
                measureUnit = "Kilometre";
                measureUnitNew = "Metre";
                rate = 1000;
            }
            else if (radioButton3.Checked == true && radioButton7.Checked == true)
            {
                measureUnit = "Kilometre";
                measureUnitNew = "İnç";
                rate = 39370.08;
            }
            else if (radioButton3.Checked == true && radioButton6.Checked == true)
            {
                measureUnit = "Kilometre";
                measureUnitNew = "Mil";
                rate = 0.621371;
            }
            else if (radioButton4.Checked == true && radioButton10.Checked == true)
            {
                measureUnit = "İnç";
                measureUnitNew = "Santimetre";
                rate = 2.54;
            }
            else if (radioButton4.Checked == true && radioButton9.Checked == true)
            {
                measureUnit = "İnç";
                measureUnitNew = "Metre";
                rate = 0.0254;
            }
            else if (radioButton4.Checked == true && radioButton8.Checked == true)
            {
                measureUnit = "İnç";
                measureUnitNew = "Kilometre";
                rate = 0.000025;
            }
            else if (radioButton4.Checked == true && radioButton6.Checked == true)
            {
                measureUnit = "İnç";
                measureUnitNew = "Mil";
                rate = 0.000016;
            }
            else if (radioButton5.Checked == true && radioButton10.Checked == true)
            {
                measureUnit = "Mil";
                measureUnitNew = "Santimetre";
                rate = 160934.4;
            }
            else if (radioButton5.Checked == true && radioButton9.Checked == true)
            {
                measureUnit = "Mil";
                measureUnitNew = "Metre";
                rate = 1609.344;
            }
            else if (radioButton5.Checked == true && radioButton8.Checked == true)
            {
                measureUnit = "Mil";
                measureUnitNew = "Kilometre";
                rate = 1.609344;
            }
            else if (radioButton5.Checked == true && radioButton7.Checked == true)
            {
                measureUnit = "Mil";
                measureUnitNew = "İnç";
                rate = 63360;
            }
            double result = value * rate;
            label2.Text = "Sonuç: " + String.Format("{0:0.0000}", result);
            results.Add(value + measureUnit + " = " + result + measureUnitNew);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(string element in results)
            {
                uz.listBox1.Items.Add(element);
            }
            uz.Show();
        }
    }
}
