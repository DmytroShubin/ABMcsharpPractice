using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World";
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            label1.Text = "Move";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Load";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            label4.Text = "Activated";
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            label3.Text = "VisibleChanged";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            label5.Text = "Shown";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            label6.Text = "Paint";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            label7.Text = "FormClosed";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            label8.Text = "FormClosing";
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            label9.Text = "Deactivate";
        }
    }
}
