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
    public partial class currency : Form
    {
        currencySum cs = new currencySum();

        List<string> cache = new List<string>();

        public currency()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton12.Enabled = false;
            radioButton11.Enabled = true;
            radioButton10.Enabled = true;
            radioButton9.Enabled = true;
            radioButton8.Enabled = true;
            radioButton7.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton12.Enabled = true;
            radioButton11.Enabled = false;
            radioButton10.Enabled = true;
            radioButton9.Enabled = true;
            radioButton8.Enabled = true;
            radioButton7.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton12.Enabled = true;
            radioButton11.Enabled = true;
            radioButton10.Enabled = false;
            radioButton9.Enabled = true;
            radioButton8.Enabled = true;
            radioButton7.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton12.Enabled = true;
            radioButton11.Enabled = true;
            radioButton10.Enabled = true;
            radioButton9.Enabled = false;
            radioButton8.Enabled = true;
            radioButton7.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton12.Enabled = true;
            radioButton11.Enabled = true;
            radioButton10.Enabled = true;
            radioButton9.Enabled = true;
            radioButton8.Enabled = false;
            radioButton7.Enabled = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton12.Enabled = true;
            radioButton11.Enabled = true;
            radioButton10.Enabled = true;
            radioButton9.Enabled = true;
            radioButton8.Enabled = true;
            radioButton7.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double rate = 0;
                string unit="";
                string from = "";
                if (radioButton1.Checked == true && radioButton11.Checked == true)
                {
                    rate = 0.068;
                    from = "₺";
                    unit = "$";
                }
                else if (radioButton1.Checked == true && radioButton10.Checked == true)
                {
                    rate = 0.062;
                    from = "₺";
                    unit = "€";

                }
                else if (radioButton1.Checked == true && radioButton9.Checked == true)
                {
                    rate = 0.052;
                    from = "₺";
                    unit = "£";
                }
                else if (radioButton1.Checked == true && radioButton8.Checked == true)
                {
                    rate = 7.94;
                    from = "₺";
                    unit = "¥";
                }
                else if (radioButton1.Checked == true && radioButton7.Checked == true)
                {
                    rate = 0.086;
                    from = "₺";
                    unit = "CAD$";
                }
                else if (radioButton2.Checked == true && radioButton12.Checked == true)
                {
                    rate = 14.77;
                    from = "$";
                    unit = "₺";
                }
                else if (radioButton2.Checked == true && radioButton10.Checked == true)
                {
                    rate = 0.92;
                    from = "$";
                    unit = "€";
                }
                else if (radioButton2.Checked == true && radioButton9.Checked == true)
                {
                    rate = 0.77;
                    from = "$";
                    unit = "£";
                }
                else if (radioButton2.Checked == true && radioButton8.Checked == true)
                {
                    rate = 117.32;
                    from = "$";
                    unit = "¥";
                }
                else if (radioButton2.Checked == true && radioButton7.Checked == true)
                {
                    rate = 1.28;
                    from = "$";
                    unit = "CAD$";
                }
                else if (radioButton3.Checked == true && radioButton12.Checked == true)
                {
                    rate = 16.12;
                    from = "€";
                    unit = "₺";
                }
                else if (radioButton3.Checked == true && radioButton11.Checked == true)
                {
                    rate = 1.09;
                    from = "€";
                    unit = "$";
                }
                else if (radioButton3.Checked == true && radioButton9.Checked == true)
                {
                    rate = 0.84;
                    from = "€";
                    unit = "£";
                }
                else if (radioButton3.Checked == true && radioButton8.Checked == true)
                {
                    rate = 127.98;
                    from = "€";
                    unit = "¥";
                }
                else if (radioButton3.Checked == true && radioButton7.Checked == true)
                {
                    rate = 1.39;
                    from = "€";
                    unit = "CAD$";
                }
                else if (radioButton4.Checked == true && radioButton12.Checked == true)
                {
                    rate = 19.26;
                    from = "£";
                    unit = "₺";
                }
                else if (radioButton4.Checked == true && radioButton11.Checked == true)
                {
                    rate = 1.30;
                    from = "£";
                    unit = "$";
                }
                else if (radioButton4.Checked == true && radioButton10.Checked == true)
                {
                    rate = 1.19;
                    from = "£";
                    unit = "€";
                }
                else if (radioButton4.Checked == true && radioButton8.Checked == true)
                {
                    rate = 152.97;
                    from = "£";
                    unit = "¥";
                }
                else if (radioButton4.Checked == true && radioButton7.Checked == true)
                {
                    rate = 1.66;
                    from = "£";
                    unit = "CAD$";
                }
                else if (radioButton5.Checked == true && radioButton12.Checked == true)
                {
                    rate = 0.13;
                    from = "¥";
                    unit = "₺";
                }
                else if (radioButton5.Checked == true && radioButton11.Checked == true)
                {
                    rate = 0.0085;
                    from = "¥";
                    unit = "$";
                }
                else if (radioButton5.Checked == true && radioButton10.Checked == true)
                {
                    rate = 0.0078;
                    from = "¥";
                    unit = "€";
                }
                else if (radioButton5.Checked == true && radioButton9.Checked == true)
                {
                    rate = 0.0065;
                    from = "¥";
                    unit = "£";
                }
                else if (radioButton5.Checked == true && radioButton7.Checked == true)
                {
                    rate = 0.011;
                    from = "¥";
                    unit = "CAD$";
                }
                else if (radioButton6.Checked == true && radioButton12.Checked == true)
                {
                    rate = 11.63;
                    from = "CAD$";
                    unit = "₺";
                }
                else if (radioButton6.Checked == true && radioButton11.Checked == true)
                {
                    rate = 0.79;
                    from = "CAD$";
                    unit = "$";
                }
                else if (radioButton6.Checked == true && radioButton10.Checked == true)
                {
                    rate = 0.72;
                    from = "CAD$";
                    unit = "€";
                }
                else if (radioButton6.Checked == true && radioButton8.Checked == true)
                {
                    rate = 92.12;
                    from = "CAD$";
                    unit = "¥";
                }
                else if (radioButton6.Checked == true && radioButton9.Checked == true)
                {
                    rate = 0.60;
                    from = "CAD$";
                    unit = "£";
                }
                
                double balance = Convert.ToDouble(textBox1.Text);
                label2.Text = (balance * rate).ToString() + unit;
                cache.Add(balance+from+" = "+ (balance * rate).ToString() + unit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz.");
            }

            
        }


        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {          
            foreach (string elements in cache)
            {
                cs.listBox1.Items.Add(elements);
            }
            cs.Show();
        }
    }
}
