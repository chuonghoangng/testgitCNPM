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
            string user = txtusername.Text;
            string pass = txtpassword.Text;
            if(pass == "123" && user =="admin")
            {
                MessageBox.Show("Logged in successfully");
            }
            else{
                MessageBox.Show("Login failed");
            }
        }
    }
}
