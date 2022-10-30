using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Step
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b1 = Convert.ToDouble(textBox1.Text);
            double b2 = Convert.ToDouble(textBox2.Text);
            double b3 = Convert.ToDouble(textBox3.Text);

            double x1 = (-b2 + Math.Sqrt(b2 * b2 - 4 * b1 * b3)) / (2 * b1);
            double x2 = (b2 + Math.Sqrt(b2 * b2 - 4 * b1 * b3)) / (2 * b1);

            label4.Text = x1.ToString();
            label5.Text = x2.ToString();

            label4.Visible = true;
            label5.Visible = true;

        }
    }
}
