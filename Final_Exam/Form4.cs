using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Exam
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DIMAS_COMPUTER;Initial Catalog=Demodb;User ID=sa;Password=dmytro83");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "First_Name";
            label2.Text = "Last_Name";
            label3.Text = "Address";
            label4.Text = "Phone_Number";
            label5.Text = "Email";
            label6.Text = "DOB";
            label9.Text = "Customer  Form";
            button1.Text = "Insert";
            button2.Text = "Update";
            button3.Text = "Delete";
            button4.Text = "Select";
            button5.Text = "ASC";
            button6.Text = "DESC";
            button7.Text = "Get Info";
            button8.Text = "EXIT APPLICATION";
            button9.Text = "Refresh";
            fncFillgrid();
        }
        public void fncFillgrid()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM tblCust", con);
                adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblCust");
                dataGridView1.DataMember = "tblCust";
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
            //Insert Data 
            string First_Name = textBox1.Text.Trim().ToString();
            string Last_Name = textBox2.Text.Trim().ToString();
            string Address = textBox3.Text.Trim().ToString();
            string Phone_Number = textBox4.Text.Trim().ToString();
            string Email = textBox5.Text.Trim().ToString();
            string DOB = textBox6.Text.Trim().ToString();
            if (Name != "")
            {
                bool isLogin = fncLogin(First_Name, Last_Name, Address, Phone_Number, Email, DOB);
                if (isLogin == true)
                {
                    MessageBox.Show("Insert Complete");
                }
                else
                {
                    MessageBox.Show("Insert Not Complete");

                }
            }
            fncFillgrid();
        }
        public bool fncLogin(string First_Name, string Last_Name, string Address, string Phone_Number, string Email, string DOB)
        {
            //Insert Data with record check
            bool isLogin = false;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM tblCust WHERE First_Name = @First_Name AND Last_Name = @Last_Name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@First_Name", First_Name);
                cmd.Parameters.AddWithValue("@Last_Name", Last_Name);
                int existingRecordsCount = (int)cmd.ExecuteScalar();

                if (existingRecordsCount > 0)
                {
                    MessageBox.Show("Record already exists.");
                    return false;
                }
                else
                {
                cmd = new SqlCommand("insert into tblCust(First_Name, Last_Name, Address, Phone_Number, Email, DOB) values(@First_Name, @Last_Name, @Address, @Phone_Number, @Email, @DOB)", con);
                //con.Open();
                if (!string.IsNullOrEmpty(First_Name))
                {
                    cmd.Parameters.AddWithValue("@First_Name", First_Name);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@First_Name", DBNull.Value);
                }
                if (!string.IsNullOrEmpty(Last_Name))
                {
                    cmd.Parameters.AddWithValue("@Last_Name", Last_Name);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Last_Name", DBNull.Value);
                }
                if (!string.IsNullOrEmpty(Address))
                {
                    cmd.Parameters.AddWithValue("@Address", Address);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Address", DBNull.Value);
                }
                if (!string.IsNullOrEmpty(Phone_Number))
                {
                    cmd.Parameters.AddWithValue("@Phone_Number", Phone_Number);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Phone_Number", DBNull.Value);
                }
                if (!string.IsNullOrEmpty(Email))
                {
                    cmd.Parameters.AddWithValue("@Email", Email);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Email", DBNull.Value);
                }

                if (!string.IsNullOrEmpty(DOB))
                {
                    cmd.Parameters.AddWithValue("@DOB", DOB);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DOB", DBNull.Value);
                }

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
            // Get the ID from a TextBox And Update Info
            string ID = textBox9.Text.Trim().ToString(); 
            string First_Name = textBox1.Text.Trim().ToString();
            string Last_Name = textBox2.Text.Trim().ToString();
            string Address = textBox3.Text.Trim().ToString();
            string Phone_Number = textBox4.Text.Trim().ToString();
            string Email = textBox5.Text.Trim().ToString();
            string DOB = textBox6.Text.Trim().ToString();


            if (!string.IsNullOrEmpty(ID) && !string.IsNullOrEmpty(First_Name) && !string.IsNullOrEmpty(Last_Name) && !string.IsNullOrEmpty(Address) &&
                !string.IsNullOrEmpty(Phone_Number) && !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(DOB))
            {
                bool isUpdated = UpdateString(ID, First_Name, Last_Name, Address, Phone_Number, Email, DOB);
                if (isUpdated)
                {
                    MessageBox.Show("Update Complete");
                }
                else
                {
                    MessageBox.Show("Update Not Complete");
                }
            }
            fncFillgrid();
        }

        public bool UpdateString(string ID, string First_Name, string Last_Name, string Address, string Phone_Number, string Email, string DOB)
        {
            bool isUpdated = false;
            try
            {
                cmd = new SqlCommand("UPDATE tblCust SET First_Name = @First_Name, Last_Name = @Last_Name, Address = @Address, Phone_Number = @Phone_Number, Email = @Email, DOB = @DOB WHERE ID = @ID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ID", ID); // Declare and set the value for the @ID parameter
                cmd.Parameters.AddWithValue("@First_Name", First_Name);
                cmd.Parameters.AddWithValue("@Last_Name", Last_Name);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Phone_Number", Phone_Number);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@DOB", DOB);

                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Update Complete");
                    isUpdated = true;
                }
                else
                {
                    MessageBox.Show("Update Not Complete");
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
            return isUpdated;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Fill All Fields Using ID
            int id;
            if (int.TryParse(textBox9.Text.Trim(), out id))
            {
                GetInformationById(id);
            }
            else
            {
                MessageBox.Show("Invalid ID. Please enter a valid numeric ID.");
            }
        }
        public void GetInformationById(int id)
        {
            cmd = new SqlCommand("SELECT * FROM tblCust WHERE ID = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader["First_Name"].ToString();
                textBox2.Text = reader["Last_Name"].ToString();
                textBox3.Text = reader["Address"].ToString();
                textBox4.Text = reader["Phone_Number"].ToString();
                textBox5.Text = reader["Email"].ToString();
                textBox6.Text = reader["DOB"].ToString();
            }
            else
            {
                MessageBox.Show("No data found for the given ID.");
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Delete Record using ID
            int ID = 0;
            if (int.TryParse(textBox9.Text.Trim(), out ID))
            {
                if (ID > 0)
                {
                    DeleteUser(ID);
                }
            }
            fncFillgrid();
        }
        public void DeleteUser(int ID)
        {
            if (ID > 0)
            {
                try
                {
                    cmd = new SqlCommand("DELETE FROM tblCust WHERE ID = @ID", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@ID", ID);
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

        private void button4_Click(object sender, EventArgs e)
        {
            //Select using First Name
            string name = textBox1.Text.Trim().ToString();

            if (!string.IsNullOrEmpty(name))
            {
                SelectUserByName(name);
            }
        }
        public void SelectUserByName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                try
                {
                    cmd = new SqlCommand("SELECT * FROM tblCust WHERE First_Name = @name OR Last_Name = @name", con);
                    cmd.Parameters.AddWithValue("@name", name);
                    adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "tblCust");
                    dataGridView1.DataMember = "tblCust";
                    dataGridView1.DataSource = ds;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Sorting Ascending
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblCust order by First_Name ASC ", con);
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tblCust");
            dataGridView1.DataMember = "tblCust";
            dataGridView1.DataSource = ds;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Sorting Descending
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblCust order by First_Name DESC ", con);
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tblCust");
            dataGridView1.DataMember = "tblCust";
            dataGridView1.DataSource = ds;
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fncFillgrid();
            // Clear textBox
            textBox1.Text = string.Empty; 
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty; 
            textBox6.Text = string.Empty;
            textBox9.Text = string.Empty;
        }
    }
}
