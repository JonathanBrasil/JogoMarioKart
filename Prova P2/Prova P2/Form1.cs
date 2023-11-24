using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_P2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r, h, gasolina, pi = 3.14, total;

            r = Convert.ToDouble(textBox1.Text);
            h = Convert.ToDouble(textBox2.Text);
            gasolina = Convert.ToDouble(textBox3.Text);

            total = pi * (r*r) * h * 1000 * gasolina; 

            label4.Text = "Resultado: R$" + Convert.ToString(total);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "Resultado: ";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
