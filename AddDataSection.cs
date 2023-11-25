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
    public partial class AddDataSection : UserControl
    {
        public static AddDataSection instance;
        public TextBox textBoxSatu;
        public TextBox textBoxDua;
        public TextBox textBoxTiga;
        public DateTimePicker dateTimePicker;
        public AddDataSection()
        {
            InitializeComponent();
            instance = this;
            
            textBoxSatu = textBox1;
            textBoxDua = textBox2;
            textBoxTiga = textBox3;
            dateTimePicker = dateTimePicker1;
        }

        public string TextBoxSatuValue
        {
            get { return textBoxSatu.Text; }
        }

        public string TextBoxDuaValue
        {
            get { return textBoxDua.Text; }
        }

        public string TextBoxTigaValue
        {
            get { return textBoxTiga.Text; }
        }

        public string DateTimePickerValue
        {
            get { return dateTimePicker1.Value.Date.ToShortDateString() ; }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (!DashboardForm.Instance.pnlController.Controls.ContainsKey("ProfileSection"))
            {
                ProfileSection profileSection = new ProfileSection { Dock = DockStyle.Fill };
                DashboardForm.Instance.pnlController.Controls.Add(profileSection);
            }
            if (DashboardForm.Instance.pnlController.Controls["ProfileSection"] is ProfileSection profileSectionInstance)
            {
                profileSectionInstance.NoHp = textBoxSatu.Text;
                profileSectionInstance.Kota = textBoxDua.Text;
                profileSectionInstance.Lahir = textBoxTiga.Text;
                profileSectionInstance.LahirDua = dateTimePicker.Value.Date.ToShortDateString();
                profileSectionInstance.UpdateMcdonaldsList();
            }
            DashboardForm.Instance.pnlController.Controls["ProfileSection"].BringToFront();
        }

    }
}
