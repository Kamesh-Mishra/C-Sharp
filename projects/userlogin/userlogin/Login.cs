using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace userlogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection();
        private void signin_btn_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=DESKTOP-D1T721P\SQLEXPRESS;Initial Catalog=userlogin;Integrated Security=True";

            string querry =  "SELECT * FROM Login_Table WHERE username = '" + txt_username.Text + "' AND password = '" + txt_password.Text + "'";

            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if(dtable.Rows.Count > 0)
            {
                //username = txt_username.Text;
                //password = txt_password.Text;

                User_Details user_details = new User_Details();
                user_details.Show();
                this.Hide();
                
                
                

            }
            else
            {
                MessageBox.Show("Invalid username or password");
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }



        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }
    }
}
