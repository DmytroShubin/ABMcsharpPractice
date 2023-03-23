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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Registration
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DIMAS_COMPUTER;Initial Catalog=Demodb;User ID=sa;Password=dmytro83");
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Delete User Form";
            label2.Text = "Username";
            button1.Text = "OK";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim().ToString();

            if (username != "")
            {
                DeleteUser(username);
            }
        }
        public void DeleteUser(string username)
        {
            if (username != "")
            {
                cmd = new SqlCommand("DELETE FROM [dbo].[Table_Users] WHERE username = @username", con);
                con.Open();
                cmd.Parameters.AddWithValue("@username", username);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Successfully Deleted");
                }
                else
                {
                    MessageBox.Show("Not Deleted");
                }
            }
        }
    }
}
