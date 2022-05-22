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
    public partial class standartScientific : Form
    {
        standartScientificSum sssum = new standartScientificSum();
        List<string> liste = new List<string>();
        double value;
        string lastTransac = "";
        currencySum cs = new currencySum();
        public standartScientific()
        {
            InitializeComponent();
        }


        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = (Convert.ToDouble(label1.Text) + Convert.ToDouble(textBox1.Text)).ToString();
                textBox1.Text = null;
                lastTransac = "+";
            }
            catch (Exception ex)
            {
                label1.Text = textBox1.Text;
                textBox1.Text = null;
                lastTransac = "+";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = (Convert.ToDouble(label1.Text) - Convert.ToDouble(textBox1.Text)).ToString();
                textBox1.Text = null;
                lastTransac = "-";
            }
            catch (Exception ex)
            {
                label1.Text = textBox1.Text;
                textBox1.Text = null;
                lastTransac = "-";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = (Convert.ToDouble(label1.Text) * Convert.ToDouble(textBox1.Text)).ToString();
                textBox1.Text = null;
                lastTransac = "*";
            }
            catch (Exception ex)
            {
                label1.Text = textBox1.Text;
                textBox1.Text = null;
                lastTransac = "*";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = String.Format("{0:0.00}", (Convert.ToDouble(label1.Text) / Convert.ToDouble(textBox1.Text)));
                textBox1.Text = null;
                lastTransac = "/";
            }
            catch (Exception ex)
            {
                label1.Text = textBox1.Text;
                textBox1.Text = null;
                lastTransac = "/";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (lastTransac == "+")
                {

                    label2.Text = "Sonuç: " + (Convert.ToDouble(label1.Text) + Convert.ToDouble(textBox1.Text)).ToString();
                    liste.Add(label1.Text + " + " + textBox1.Text + " = " + (Convert.ToDouble(label1.Text) + Convert.ToDouble(textBox1.Text)).ToString());
                    textBox1.Text = null;
                    label1.Text = null;
                    lastTransac = "";
                }
                else if (lastTransac == "-")
                {
                    
                    label2.Text = "Sonuç: " + (Convert.ToDouble(label1.Text) - Convert.ToDouble(textBox1.Text)).ToString();
                    liste.Add(label1.Text + " - " + textBox1.Text + " = " + (Convert.ToDouble(label1.Text) - Convert.ToDouble(textBox1.Text)).ToString());
                    textBox1.Text = null;
                    label1.Text = null;
                    lastTransac = "";
                }
                else if (lastTransac == "*")
                {

                    label2.Text = "Sonuç: " + (Convert.ToDouble(label1.Text) * Convert.ToDouble(textBox1.Text)).ToString();
                    liste.Add(label1.Text + " * " + textBox1.Text + " = " + (Convert.ToDouble(label1.Text) * Convert.ToDouble(textBox1.Text)).ToString());
                    textBox1.Text = null;
                    label1.Text = null;
                    lastTransac = "";
                }
                else if (lastTransac == "/")
                {

                    label2.Text = "Sonuç: " + String.Format("{0:0.00}", (Convert.ToDouble(label1.Text) / Convert.ToDouble(textBox1.Text)));
                    liste.Add(label1.Text + " / " + textBox1.Text + " = " + (Convert.ToDouble(label1.Text) / Convert.ToDouble(textBox1.Text)).ToString());
                    textBox1.Text = null;
                    label1.Text = null;
                    lastTransac = "";
                }
                else if (lastTransac == "%")
                {
                    label2.Text = "Sonuç: " + String.Format("{0:0.00}", (Convert.ToDouble(label1.Text) % Convert.ToDouble(textBox1.Text)));
                    liste.Add(label1.Text + " % " + textBox1.Text + " = " + (Convert.ToDouble(label1.Text) % Convert.ToDouble(textBox1.Text)).ToString());
                    textBox1.Text = null;
                    label1.Text = null;
                    lastTransac = "";
                }
            }
        catch(Exception ex)
            {
                MessageBox.Show("Lütfen Tekrar deneyiniz.");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            label1.Text = null;
            lastTransac = "";
            label2.Text= "Sonuç: ";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDouble(textBox1.Text);
                value = Math.PI * value;
                value = value / 180;
                label2.Text = "Sonuç: " + String.Format("{0:0.00}", Math.Sin(value));
                label1.Text = String.Format("{0:0.00}", Math.Sin(value));
                liste.Add("Sin" + Convert.ToDouble(textBox1.Text) + " = " + label1.Text);
                textBox1.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tekrar deneyin");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDouble(textBox1.Text);
                value = Math.PI * value;
                value = value / 180;
                label2.Text = "Sonuç: " + String.Format("{0:0.00}", Math.Cos(value));
                label1.Text = String.Format("{0:0.00}", Math.Cos(value));
                liste.Add("Cos" + Convert.ToDouble(textBox1.Text) + " = " + label1.Text);
                textBox1.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tekrar deneyin");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDouble(textBox1.Text);
                value = Math.PI * value;
                value = value / 180;
                label2.Text = "Sonuç: " + String.Format("{0:0.00}", Math.Tan(value));
                label1.Text = String.Format("{0:0.00}", Math.Tan(value));
                liste.Add("Tan" + Convert.ToDouble(textBox1.Text) + " = " + label1.Text);
                textBox1.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tekrar deneyin");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDouble(textBox1.Text);
                value = Math.PI * value;
                value = value / 180;
                label2.Text = "Sonuç: " + String.Format("{0:0.00}", (1 / Math.Tan(value)));
                label1.Text = String.Format("{0:0.00}", (1 / Math.Tan(value)));
                liste.Add("Cot" + Convert.ToDouble(textBox1.Text) + " = " + label1.Text);
                textBox1.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tekrar deneyin");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDouble(textBox1.Text);
                value = Math.Log10(value);
                label2.Text = "Sonuç: " + String.Format("{0:0.00}", value);
                label1.Text = String.Format("{0:0.00}", value);
                liste.Add("Log" + value + " = " + label1.Text);
                textBox1.Text = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tekrar deneyin");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDouble(textBox1.Text);
                value = Math.Sqrt(value);
                label2.Text = "Sonuç: " + String.Format("{0:0.00}", value);
                label1.Text = String.Format("{0:0.00}", value);
                liste.Add("√" + value + " = " + label1.Text);
                textBox1.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tekrar deneyin");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = String.Format("{0:0.00}", (Convert.ToDouble(label1.Text) % Convert.ToDouble(textBox1.Text)));
                textBox1.Text = null;
                lastTransac = "%";
            }
            catch (Exception ex)
            {
                label1.Text = textBox1.Text;
                textBox1.Text = null;
                lastTransac = "%";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int cache;
            int num;
            value = Convert.ToInt32(textBox1.Text);
            cache = Convert.ToInt32(value);
            num = cache;
            textBox1.Text = null;

            while (cache > 1)
            {
                value = value *(cache-1) ;
                cache--;
            }
            label2.Text = "Sonuç: " + value.ToString();
            liste.Add(num+"!" + " = " + value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string elements in liste)
            {
                sssum.listBox1.Items.Add(elements);
            }
            sssum.Show();
        }
    }
}
