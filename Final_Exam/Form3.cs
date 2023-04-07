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

namespace Final_Exam
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DIMAS_COMPUTER;Initial Catalog=Demodb;User ID=sa;Password=dmytro83");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "First_Name";
            label2.Text = "Last_Name";
            label3.Text = "Address";
            label4.Text = "Phone_Number";
            label5.Text = "Email";
            label6.Text = "DOB";
            label7.Text = "Position";
            label8.Text = "Salary";
            label9.Text = "Employee  Form";
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
                cmd = new SqlCommand("SELECT * FROM tblEmpl", con);
                adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblEmpl");
                dataGridView1.DataMember = "tblEmpl";
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
            string First_Name = textBox1.Text.Trim().ToString();
            string Last_Name = textBox2.Text.Trim().ToString();
            string Address = textBox3.Text.Trim().ToString();
            string Phone_Number = textBox4.Text.Trim().ToString();
            string Email = textBox5.Text.Trim().ToString();
            string DOB = textBox6.Text.Trim().ToString();
            string Position = textBox7.Text.Trim().ToString();
            string Salary = textBox8.Text.Trim().ToString();


            if (Name != "")
            {
                bool isLogin = fncLogin(First_Name, Last_Name, Address, Phone_Number, Email, DOB, Position, Salary);
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
        public bool fncLogin(string First_Name, string Last_Name, string Address, string Phone_Number, string Email, string DOB, string Position, string Salary)
        {
            bool isLogin = false;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM tblEmpl WHERE First_Name = @First_Name AND Last_Name = @Last_Name", con);
                cmd.Parameters.AddWithValue("@First_Name", First_Name);
                cmd.Parameters.AddWithValue("@Last_Name", Last_Name);
                con.Open();
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Employee with the same First Name and Last Name already exists in the database.");
                    return false;
                }
                else
                {
                    cmd = new SqlCommand("insert into tblEmpl(First_Name, Last_Name, Address, Phone_Number, Email, DOB, Position, Salary) values(@First_Name, @Last_Name, @Address, @Phone_Number, @Email, @DOB, @Position, @Salary)", con);
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
                    if (!string.IsNullOrEmpty(Position))
                    {
                        cmd.Parameters.AddWithValue("@Position", Position);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Position", DBNull.Value);
                    }
                    if (!string.IsNullOrEmpty(DOB))
                    {
                        cmd.Parameters.AddWithValue("@Salary", Salary);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Salary", DBNull.Value);
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
            string ID = textBox9.Text.Trim().ToString(); // Get the ID from a TextBox, assuming the TextBox name is textBoxID
            string First_Name = textBox1.Text.Trim().ToString();
            string Last_Name = textBox2.Text.Trim().ToString();
            string Address = textBox3.Text.Trim().ToString();
            string Phone_Number = textBox4.Text.Trim().ToString();
            string Email = textBox5.Text.Trim().ToString();
            string DOB = textBox6.Text.Trim().ToString();
            string Position = textBox7.Text.Trim().ToString();
            string Salary = textBox8.Text.Trim().ToString();

            if (!string.IsNullOrEmpty(ID) && !string.IsNullOrEmpty(First_Name) && !string.IsNullOrEmpty(Last_Name) && !string.IsNullOrEmpty(Address) &&
                !string.IsNullOrEmpty(Phone_Number) && !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(DOB) &&
                !string.IsNullOrEmpty(Position) && !string.IsNullOrEmpty(Salary))
            {
                bool isUpdated = UpdateString(ID, First_Name, Last_Name, Address, Phone_Number, Email, DOB, Position, Salary);
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

        public bool UpdateString(string ID, string First_Name, string Last_Name, string Address, string Phone_Number, string Email, string DOB, string Position, string Salary)
        {
            bool isUpdated = false;
            try
            {
                cmd = new SqlCommand("UPDATE tblEmpl SET First_Name = @First_Name, Last_Name = @Last_Name, Address = @Address, Phone_Number = @Phone_Number, Email = @Email, DOB = @DOB, Position = @Position, Salary = @Salary WHERE ID = @ID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ID", ID); // Declare and set the value for the @ID parameter
                cmd.Parameters.AddWithValue("@First_Name", First_Name);
                cmd.Parameters.AddWithValue("@Last_Name", Last_Name);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Phone_Number", Phone_Number);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Position", Position);
                cmd.Parameters.AddWithValue("@Salary", Salary);

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
            cmd = new SqlCommand("SELECT * FROM tblEmpl WHERE ID = @id", con); 
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
                textBox7.Text = reader["Position"].ToString();
                textBox8.Text = reader["Salary"].ToString();
            }
            else
            {
                MessageBox.Show("No data found for the given ID.");
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
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
                    cmd = new SqlCommand("DELETE FROM tblEmpl WHERE ID = @ID", con);
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
                    cmd = new SqlCommand("SELECT * FROM tblEmpl WHERE First_Name = @name OR Last_Name = @name", con);
                    cmd.Parameters.AddWithValue("@name", name);
                    adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "tblEmpl");
                    dataGridView1.DataMember = "tblEmpl";
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
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblEmpl order by First_Name ASC ", con);
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tblEmpl");
            dataGridView1.DataMember = "tblEmpl";
            dataGridView1.DataSource = ds;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblEmpl order by First_Name DESC ", con);
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tblEmpl");
            dataGridView1.DataMember = "tblEmpl";
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
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;
        }
    }
}
