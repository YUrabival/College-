using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаб_2
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                {
                    MessageBox.Show(
                        "В строке нет значения! Введите значениие.",
                         "Сообщение"
                        );
                }
                else
                {
                    double a = Convert.ToDouble(textBox1.Text);
                    double b = Convert.ToDouble(textBox2.Text);
                    double sum = a + b;
                    textBox3.Text = Convert.ToString(sum);
                    if (sum == 0)
                    {
                        textBox3.BackColor = Color.LightSkyBlue;

                    }
                    if (sum > 0)
                    {
                        textBox3.BackColor = Color.LightGreen;

                    }
                    if (sum < 0)
                    {
                        textBox3.BackColor = Color.IndianRed;

                    }
                }


            }
            catch
            {
                MessageBox.Show("Введите верное значение");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
