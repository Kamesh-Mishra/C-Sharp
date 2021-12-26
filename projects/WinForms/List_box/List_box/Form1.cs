using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FruitListBox.Items.Add(textBox1.Text);

            textBox1.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = FruitListBox.Items.Count;
            MessageBox.Show("Total number of items in list is : " + count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FruitListBox.Sorted = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //FruitListBox.Items.Remove(FruitListBox.SelectedItem);
            FruitListBox.Items.RemoveAt(FruitListBox.SelectedIndex);    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FruitListBox.Items.Clear();
        }
    }
}
