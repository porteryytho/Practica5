using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.num1.Text);
            int num2 = int.Parse(this.num2.Text);
            int suma = num1 + num2;
            this.total.Text = suma.ToString();
        }

        private void res_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.num1.Text);
            int num2 = int.Parse(this.num2.Text);
            int res = num1 - num2;
            this.total.Text = res.ToString();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.num1.Text);
            int num2 = int.Parse(this.num2.Text);
            int mul = num1 * num2;
            this.total.Text = mul.ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.num1.Text);
            int num2 = int.Parse(this.num2.Text);
            int div = num1 / num2;
            this.total.Text = div.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
            total.Clear();
        }
    }
}
