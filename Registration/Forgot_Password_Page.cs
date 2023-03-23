using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DIMAS_COMPUTER;Initial Catalog=Demodb;User ID=sa;Password=dmytro83");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Reset Password Form";
            label2.Text = "Username";
            label3.Text = "Enter New Password";
            label4.Text = "Confirm New Password";
            button1.Text = "Confirm";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim().ToString();
            string newpassword = textBox2.Text.Trim().ToString();
            string confirmpassword = textBox3.Text.Trim().ToString();

            if (username != "" && newpassword != ""&& confirmpassword != "")
            {
                UpdatePassword(username, newpassword, confirmpassword);
            }
        }
        public void UpdatePassword( string username, string newpassword,string confirmpassword)
        {
            if (username != "" && newpassword != "" && confirmpassword != "")
            {
                cmd = new SqlCommand("update [dbo].[Table_Users] set username=@username, password=@password where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", confirmpassword);
                cmd.Parameters.AddWithValue("@id", 3);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Succsessfully Updated");
                }
                else
                {
                    MessageBox.Show("Not Updated");
                }
            }
        }
    }
}
