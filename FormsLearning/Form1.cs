using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLearning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Login Page";
            label3.Text = "User Name";
            label2.Text = "Password";
            button1.Text = "Log In";
            label4.Hide();
            label4.Text = "Please enter Valid Name";
            label5.Hide();
            label5.Text = "Please enter Valid Password";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Username = this.textBox1.Text;
            var Password = this.textBox2.Text;
            string Username1 = "Dmytro";
            string Password1 = "Password";
            if (Username != Username1)
            {
                label4.Show();
            }
            if(Password != Password1)
            {
                label5.Show();
            }
            if(Username == Username1 && Password == Password1)
            {
                label4.Hide();
                label5.Hide();
               bool isLoginResult = fncLogin(Username, Password);
                if (isLoginResult == true)
                {  

                }
                else
                {
      
                }
            }
        }
        public bool fncLogin(string Username , string Password)
        {
            bool isLogin = false;
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
