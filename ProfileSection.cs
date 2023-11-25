using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static McdonaldDesktopApp.DataCatalogue;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace McdonaldDesktopApp
{
    public partial class ProfileSection : UserControl
    {
        Wishlist wishlist;
        private string usernameProfile;
        private string emailProfile;
        private string noHandphoneProfile;
        private string alamatKota;
        private string tanggalLahir;
        private string lahirDua;


        public ProfileSection()
        {
            wishlist = Wishlist.Instance;
            InitializeComponent();
            InitializeMcdonaldsData();
            
        }

        private void InitializeMcdonaldsData()
        {
            foreach (var mcdonalds in wishlist.SelectedMcdonaldsData)
            {
                AddDataToFlowLayout(mcdonalds, flowLayoutPanel1);
            }
            wishlist.SelectedMcdonaldsData.Clear();
        }

        private void AddDataToFlowLayout(DataCatalogue.McdonaldsData mcdonaldsData, FlowLayoutPanel flowLayoutPanel)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(mcdonaldsData.Image);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Width = 298;
            pictureBox.Height = 188;
            pictureBox.Location = new Point(-13, 3);

            Label genreLabel = new Label();
            genreLabel.Text = mcdonaldsData.Title;
            genreLabel.Font = new Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            genreLabel.Location = new Point(10, 215);
            genreLabel.Width = 223;

            Label titleTextBox = new Label();
            titleTextBox.Text = mcdonaldsData.Subtitle;
            titleTextBox.Font = new Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            titleTextBox.Location = new Point(10, 240);
            titleTextBox.Width = 223;

            BunifuCards groupBox = new BunifuCards();
            groupBox.Width = 233;
            groupBox.Height = 287;
            groupBox.IndicatorColor = Color.Transparent;
            groupBox.BorderRadius = 30;
            groupBox.Controls.Add(pictureBox);
            groupBox.Controls.Add(genreLabel);
            groupBox.Controls.Add(titleTextBox);

            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.Controls.Add(groupBox);
        }

        public void UpdateMcdonaldsList()
        {
            InitializeMcdonaldsData();
            label4.Text = usernameProfile;
            label6.Text = emailProfile;
            label8.Text = noHandphoneProfile;
            label10.Text = alamatKota;
            label12.Text = tanggalLahir;
            label12.Text = lahirDua;
        }

        public string Username
        {
            set
            {
                usernameProfile = value;
            }
        }

        public string Email
        {
            set
            {
                emailProfile = value;
            }
        }

        public string NoHp
        {
            set
            {
                noHandphoneProfile = value;
            }
        }

        public string Kota
        {
            set
            {
                alamatKota = value;
            }
        }

        public string Lahir
        {
            set
            {
                tanggalLahir = value;
            }
        }

        public string LahirDua
        {
            set
            {
                lahirDua = value;
            }
        }

        private void ProfileSection_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (!DashboardForm.Instance.pnlController.Controls.ContainsKey("AddDataSection"))
            {
                AddDataSection addDataSection = new AddDataSection { Dock = DockStyle.Fill };
                DashboardForm.Instance.pnlController.Controls.Add(addDataSection);
            }
            DashboardForm.Instance.pnlController.Controls["AddDataSection"].BringToFront();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
