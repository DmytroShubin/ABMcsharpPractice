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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Registration
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DIMAS_COMPUTER;Initial Catalog=Demodb;User ID=sa;Password=dmytro83");
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "Name";
            label2.Text = "Age";
            label3.Text = "Gender";
            label4.Text = "Salary";
            label5.Text = "Department";
            label6.Text = "Is Active";
            label7.Text = "Team Leader";
            label8.Text = "Is Maried";
            label9.Text = "Employee Insert Form";
            button1.Text = "Submit";
            fncFillgrid();

        }
        public void fncFillgrid()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Table_Employee", con);
                adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Table_Employee");
                dataGridView1.DataMember = "Table_Employee";
                dataGridView1.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text.Trim().ToString();
            string Age = textBox2.Text.Trim().ToString();
            string Gender = textBox3.Text.Trim().ToString();
            string Salary = textBox4.Text.Trim().ToString();
            string Department = textBox5.Text.Trim().ToString();
            string TeamLead = textBox7.Text.Trim().ToString();
            

            if (Name != "")
            {
                bool isLogin = fncLogin(Name, Age, Gender,Salary,Department,TeamLead);
                if (isLogin == true)
                {
                    MessageBox.Show("Insert Complete");
                }
                else
                {
                    MessageBox.Show("Insert Not Complete");

                }
            }
        }
        public bool fncLogin(string Name, string Age,string Gender, string Salary,string Department,string TeamLead)
        {
            bool isLogin = false;
            try
            {
                cmd = new SqlCommand("insert into Table_Employee(Name,Age,Gender,Salary,Department,IsActiv,TeamLead,IsMaried) values(@name,@age,@Gender,@Salary,@Department,@IsActive,@TeamLead,@IsMaried)", con);
                con.Open();
                if(!string.IsNullOrEmpty(Name))
                {
                    cmd.Parameters.AddWithValue("@name", Name);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@name", DBNull.Value);
                }
                if (!string.IsNullOrEmpty(Age))
                {
                    cmd.Parameters.AddWithValue("@age", Age);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@age", DBNull.Value);
                }
                if (!string.IsNullOrEmpty(Gender))
                {
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Gender", DBNull.Value);
                }
                if (!string.IsNullOrEmpty(Salary))
                {
                    cmd.Parameters.AddWithValue("@Salary", Salary);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Salary", DBNull.Value);
                }
                if (!string.IsNullOrEmpty(Department))
                {
                    cmd.Parameters.AddWithValue("@Department", Department);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Department", DBNull.Value);
                }

                    cmd.Parameters.AddWithValue("@IsActive", true);

                if (!string.IsNullOrEmpty(TeamLead))
                {
                    cmd.Parameters.AddWithValue("@TeamLead", TeamLead);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TeamLead", DBNull.Value);
                }
                cmd.Parameters.AddWithValue("@IsMaried", DBNull.Value);

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
