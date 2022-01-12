using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        string Text1 = "";
        string Text2 = "";
        string Text3 = "";
        string Text4 = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void SamsungChk_CheckedChanged(object sender, EventArgs e)
        {
            if (SamsungChk.Checked == true)
            {
                Text1 = SamsungChk.Text;
            }
            else
            {
                Text1 = "";
            }
        }

        private void IphoneChk_CheckedChanged(object sender, EventArgs e)
        {
            if (IphoneChk.Checked == true)
            {
                Text2 = IphoneChk.Text;
            }
            else
            {
                Text2 = "";
            }
        }

        private void NokiaChk_CheckedChanged(object sender, EventArgs e)
        {
            if (NokiaChk.Checked == true)
            {
                Text3 = NokiaChk.Text;
            }
            else
            {
                Text3 = "";
            }
        }

        private void OppoChk_CheckedChanged(object sender, EventArgs e)
        {
            if (OppoChk.Checked == true)
            {
                Text4 = OppoChk.Text;
            }
            else
            {
                Text4 = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your selected Companies are " + Text1 + " " + Text2 + " " + Text3 + " " + Text4);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = checkBox1.Checked;
        }
    }
}
