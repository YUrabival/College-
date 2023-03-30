using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Лаба_3
{
    public partial class Form1 : Form
    {
        public object TimeLbl { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value != progressBar1.Maximum)
            {
                progressBar1.Value += 10;
                timer1.Enabled = true;
                timer1.Start();
            }
            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                timer1.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value != progressBar1.Minimum)
            {
                progressBar1.Value = progressBar1.Value - 10;
            }

        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        
    }
}
