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

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Area";
            label2.Text = "SubArea";
            label3.Text = "City";
            comboBox1.Text = label1.Text;
            comboBox2.Text = label2.Text;
            comboBox3.Text = label3.Text;
            filldropdown();
        }
       
        private void filldropdown()
        {
            using(SqlConnection con =new SqlConnection(@"Data Source=DIMAS_COMPUTER;Initial Catalog=Demodb;User ID=sa;Password=dmytro83"))
            {
                try
                {
                    string query = "select ID,Description,IsActive from[dbo].[Table_Area]";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "[dbo].[Table_Area]");
                    comboBox1.DisplayMember = "Description";
                    comboBox1.ValueMember = "ID";
                    comboBox1.DataSource = ds.Tables["[dbo].[Table_Area]"] ;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
                finally 
                {
                    con.Close();
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(@"Data Source=DIMAS_COMPUTER;Initial Catalog=Demodb;User ID=sa;Password=dmytro83"))
            {
                try 
                {
                    string query = "select ID,Description,IsActive from [dbo].[Table_SubArea]";
                    SqlDataAdapter da =new SqlDataAdapter(query, con);
                    con.Open(); 
                    DataSet ds = new DataSet();
                    da.Fill(ds, "[dbo].[Table_SubArea]");
                    comboBox3.DisplayMember = "Description";
                    comboBox3.ValueMember = "ID";
                    comboBox3.DataSource = ds.Tables["[dbo].[Table_SubArea]"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DIMAS_COMPUTER;Initial Catalog=Demodb;User ID=sa;Password=dmytro83"))
            {
                try
                {
                    string query = "select ID,Description,IsActive from [dbo].[Table_City]";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "[dbo].[Table_City]");
                    comboBox2.DisplayMember = "Description";
                    comboBox2.ValueMember = "ID";
                    comboBox2.DataSource = ds.Tables["[dbo].[Table_City]"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connectionString;
            //SqlConnection cn;
            //connectionString = @"Data Source=DIMAS_COMPUTER;Initial Catalog=Demodb;User ID=sa;Password=dmytro83";
            //cn = new SqlConnection(connectionString);
            //cn.Open();
            //MessageBox.Show("Connetion Complete");
            //cn.Close();
        }

        
    }
}
