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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DIMAS_COMPUTER;Initial Catalog=Demodb;User ID=sa;Password=dmytro83");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Registration Form";
            label2.Text = "UserName";
            label3.Text = "Password";
            button1.Text = "Login";
            button2.Text = "Forgot Password";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim().ToString();
            string password = textBox2.Text.Trim().ToString();

            if (username != "" && password != "")
            {
                bool isLogin = fncLogin(username, password);
                if (isLogin == true)
                {
                    MessageBox.Show("Logged IN");
                }
                else
                {
                    MessageBox.Show("Forgot UserName or Password?");

                }
            }
            else
            {
                MessageBox.Show("Please Provide Your Username and Password");
            }
        }
        public bool fncLogin(string username, string password)
        {
            bool isLogin = false;
            try
            {
                cmd = new SqlCommand("insert into [dbo].[Table_Users](Username,Password,IsActive) values(@username,@password,@IsActive)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@IsActive", true);
                int i = cmd.ExecuteNonQuery();
                if (i ==1)
                {
                    MessageBox.Show("Insert Complete");
                    isLogin= true;
                }
                else
                {
                    MessageBox.Show("Insert Not Complete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            finally 
            {
                con.Close();
            }    
            return isLogin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ForgotPass = new Form2();
            this.Hide();
            ForgotPass.Show();
        }
    }
}
