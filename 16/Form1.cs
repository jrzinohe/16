using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = int .Parse(textBox1.Text);
            if (num % 2 == 0) MessageBox.Show("el numero es par");
            else
                if (num % 3 == 0) MessageBox.Show("el numero es impar y es divisible por 3");
            else MessageBox.Show("el numero es impar es no divisible por 3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           
        }
    }
}
