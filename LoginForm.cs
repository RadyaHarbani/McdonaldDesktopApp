using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace McdonaldDesktopApp
{
    public partial class LoginForm : Form
    {

        string usernameReg;
        string passwordReg;
        string emailReg;

        public LoginForm(string username, string password, string email)
        {
            InitializeComponent();
            configComponent();

            label9.MouseEnter += label9_MouseEnter;
            label9.Click += label9_Click;

            usernameReg = username;
            passwordReg = password;
            emailReg = email;
        }

        private void configComponent()
        {
            pictureBox1.ImageLocation = "../../../Assets/Banner/login_register_banner.jpg";
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.Cursor = Cursors.Hand;
        }
        private void label9_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == usernameReg && textBox3.Text == passwordReg)
            {
                DashboardForm dashboardForm = new DashboardForm( usernameReg, passwordReg, emailReg);
                dashboardForm.Show();
                this.Hide();
            }
            else if (textBox1.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Masukkan akun anda", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Question);
                textBox1.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Akun anda salah", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Question);
                textBox1.Clear();
                textBox3.Clear();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin Ingin Keluar?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                DialogResult dialogResult2 = MessageBox.Show("Apakah kamu ingin membersihkan kolom text?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {
                    textBox1.Clear();
                    textBox3.Clear();
                }
            }
        }
    }
}
