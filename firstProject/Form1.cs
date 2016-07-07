using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            string result;

            if (user.Equals("satinder") && pass.Equals("1234"))
            {
                result = "Granted";
                new Form2().Show();
                this.Hide();
            }
            else
            {
                result = "denied";
            }
            this.label3.Text = result;
        }
    }
}
