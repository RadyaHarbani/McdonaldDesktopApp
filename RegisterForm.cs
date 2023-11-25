namespace McdonaldDesktopApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            configComponent();

            label9.MouseEnter += label9_MouseEnter;
            label9.Click += label9_Click;
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
            LoginForm loginForm = new LoginForm(textBox1.Text, textBox2.Text, textBox3.Text);
            loginForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm(textBox1.Text, textBox3.Text, textBox2.Text);
            login.Show();
            this.Hide();
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
                    textBox2.Clear();
                }
            }
        }
    }
}