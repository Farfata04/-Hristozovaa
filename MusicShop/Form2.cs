using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicShop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="farfata"&& textBox1.Text=="farfata")
            {
                Admin admin = new  Admin();
                admin.ShowDialog();
            }

            if (textBox1.Text == "farfata1" && textBox1.Text == "farfata1")
            {
                User user = new User();
                user.ShowDialog();
            }

        }
    }
}
