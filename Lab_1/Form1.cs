using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float s,t,v;
            if (!String.IsNullOrEmpty(this.textBox1.Text)&&
                !String.IsNullOrEmpty(this.textBox2.Text))
            {
                try
                {

                   s = float.Parse(textBox1.Text);
                   t = float.Parse(textBox2.Text);

                    calculate(s, t);
                   
                }
                catch
                {
                    MessageBox.Show("Введіть чифрові значення");
                }
            }
        }
        private void calculate(float S, float T)
        {
            textBox1.Clear();
            textBox2.Clear();
            float V = S / T;
            lbRes.Text = $"Швидкість: {V} м/с";
        }
    }
}
