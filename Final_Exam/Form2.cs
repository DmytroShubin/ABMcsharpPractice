using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam
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
            label1.Text = "UserName";
            label2.Text = "Password";
            button1.Text = "Employee Login";
            button2.Text = "Create Account";
            button3.Text = "Customer Login";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim().ToString();
            string password = textBox2.Text.Trim().ToString();

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                bool isLogin = fncLogin1(username, password);
                if (isLogin)
                {
                    MessageBox.Show("Logged IN");
                    Form3 form3 = new Form3(); // Create an instance of Form3
                    this.Hide();
                    form3.Show(); // Show Form3
                    Form2 form2 = new Form2();
                    form2.Close();
                    form2.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please Provide Your Username and Password");
            }
        }

        public bool fncLogin1(string username, string password)
        {
            bool isLogin = false;
            try
            {
                // Check if the username already exists in the database
                cmd = new SqlCommand("SELECT COUNT(*) FROM [dbo].[Table_Users] WHERE Username = @username", con);
                cmd.Parameters.AddWithValue("@username", username);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int count = reader.GetInt32(0);
                reader.Close();
                con.Close();

                if (count > 0)
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    Form2 form2 = new Form2();
                    form2.Close();
                    this.Hide();

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
            string username = textBox1.Text.Trim().ToString();
            string password = textBox2.Text.Trim().ToString();

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                bool isLogin = fncLogin(username, password);
                if (isLogin)
                {
                    MessageBox.Show("Account Created");
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
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    cmd = new SqlCommand("insert into [dbo].[Table_Users](Username,Password,IsActive) values(@username,@password,@IsActive)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@IsActive", true);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Insert Complete");
                        isLogin = true;
                    }
                    else
                    {
                        MessageBox.Show("Insert Not Complete");
                    }
                }
                else
                {
                    MessageBox.Show("Username and Password cannot be null");
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

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim().ToString();
            string password = textBox2.Text.Trim().ToString();

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                bool isLogin = fncLogin2(username, password);
                if (isLogin)
                {
                    MessageBox.Show("Logged IN");
                    Form4 form4 = new Form4(); // Create an instance of Form4
                    this.Hide();
                    form4.Show(); // Show Form4
                    Form2 form2 = new Form2();
                    form2.Close();
                    form2.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please Provide Your Username and Password");
            }
        }
        public bool fncLogin2(string username, string password)
        {
            bool isLogin = false;
            try
            {
                // Check if the username already exists in the database
                cmd = new SqlCommand("SELECT COUNT(*) FROM [dbo].[Table_Users] WHERE Username = @username", con);
                cmd.Parameters.AddWithValue("@username", username);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int count = reader.GetInt32(0);
                reader.Close();
                con.Close();

                if (count > 0)
                {
                    Form4 form4 = new Form4();
                    form4.Show();
                    Form2 form2 = new Form2();
                    form2.Close();
                    this.Hide();

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

    }
}
