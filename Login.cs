using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userTextBox.Text == "Talha" && passTextBox.Text == "123")
            {
                this.Hide();
                Form menu = new Menu();
                menu.Show();
            }
            else if (userTextBox.Text == "Uzair" && passTextBox.Text == "0123456789")
            {
                this.Hide();
                Form menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("INCORRECT NAME OR PASSWORD");
                userTextBox.Clear();
                passTextBox.Clear();
                userTextBox.Focus();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
