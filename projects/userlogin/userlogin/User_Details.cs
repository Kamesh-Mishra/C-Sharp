using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userlogin
{
    public partial class User_Details : Form
    {
        public User_Details()
        {
            InitializeComponent();
        }

        private void User_Details_Load(object sender, EventArgs e)
        {
            Output_Name.Text = "DEMO_NAME";
            Output_Email.Text = "Demo email";
            Output_Phone.Text = "demo phone";
            Output_City.Text = "demo city";
        }
    }
}
