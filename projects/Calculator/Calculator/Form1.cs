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

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);

                int result = a + b;

                //MessageBox.Show("result is : "+result.ToString());
                label4.Text = "Addition Result is : " + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Fill Both the fields !!");
            }
            
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);

                int result = a - b;

                //MessageBox.Show("result is : "+result.ToString());
                label4.Text = "Subtraction Result is : " + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Fill Both the fields !!");
            }
        }

        private void MulButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);

                int result = a * b;

                //MessageBox.Show("result is : "+result.ToString());
                label4.Text = "Multiplication Result is : " + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Fill Both the fields !!");
            }
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);

                int result = a / b;

                //MessageBox.Show("result is : "+result.ToString());
                label4.Text = "Division Result is : " + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Fill Both the fields !!");
            }
        }
    }
}
