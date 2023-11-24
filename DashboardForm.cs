using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McdonaldDesktopApp
{
    public partial class DashboardForm : Form
    {

        private static DashboardForm instance;
        public static DashboardForm Instance
        {
            get { if (instance == null)
                    instance = new DashboardForm("", "", "");
            return instance;
            }
        }

        HomeSection homeSection = new HomeSection { Dock = DockStyle.Fill};
        CatalogueSection catalogueSection = new CatalogueSection { Dock = DockStyle.Fill };
        ProfileSection profileSection = new ProfileSection { Dock = DockStyle.Fill };

        private string usernameD;
        private string passwordD;
        private string emailD;
        private string panelActive;

        public Panel pnlController
        {
            get { return panel2; }
            set { panel2 = value; }
        }

        public DashboardForm(string username, string password, string email)
        {
            configValue();
            InitializeComponent();
            configComponent();
  

            usernameD = username;
            passwordD = password;
            emailD = email;

            instance= this;

        }

        private void configComponent()
        {
            this.panel2.Controls.Add(homeSection);

            pictureBox6.ImageLocation = "../../../Assets/Global_Images/kentang_melayang.png";
        }

        private void configValue()
        {
            panelActive = "homeSection";
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(homeSection);
            panelActive = "homeSection";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(catalogueSection);
            panelActive = "catalogueSection";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(profileSection);
            profileSection.Username = usernameD;
            profileSection.Email = emailD;

            panelActive = "profileSection";

            profileSection.UpdateMcdonaldsList();
        }
    }
}
