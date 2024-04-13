using System;

namespace practica2._1._2
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

            int n = int.Parse(textBox1.Text);


            double result = CalculateSeriesProduct(n);


            textBox2.Text = "Произведение первых " + n + " членов ряда: " + result.ToString();
        }


        private double CalculateSeriesProduct(int n)
        {
            double product = 1.0;
            for (int k = 1; k <= n; k++)
            {

                double term = (Math.Pow(k, k) + 1) / Math.Pow(k, k);
                product *= term;
            }
            return product;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


