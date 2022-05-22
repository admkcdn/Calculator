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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currency crn = new currency();
            crn.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            standartScientific standartScientific = new standartScientific();
            standartScientific.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uzunluk uzunluk = new uzunluk();
            uzunluk.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            temperature temp = new temperature();
            temp.Show();
        }
    }
}
