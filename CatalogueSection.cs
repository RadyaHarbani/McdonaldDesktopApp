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

namespace McdonaldDesktopApp
{
    public partial class CatalogueSection : UserControl
    {
        Wishlist wishlist;
        private DataCatalogue dataProvider;
        public CatalogueSection()
        {
            InitializeComponent();
            dataProvider = new DataCatalogue();
            InitializeMcdonaldsData();
        }

        private void InitializeMcdonaldsData()
        {
            var mcdonaldsData = dataProvider.GetMcdonaldsData();

            var sortedMcdonaldsData = mcdonaldsData.OrderBy(mcdonalds => mcdonalds.Title).ToList();

            foreach (var mcdonalds in sortedMcdonaldsData)
            {
                AddAnimeToFlowLayout(mcdonalds, flowLayoutPanel1);
            }
        }

        private void AddAnimeToFlowLayout(DataCatalogue.McdonaldsData mcdonaldsData, FlowLayoutPanel flowLayoutPanel)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(mcdonaldsData.Image);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Width = 298;
            pictureBox.Height = 188;
            pictureBox.Location = new Point(-13, 3);
            pictureBox.Cursor = Cursors.Hand;
            pictureBox.Click += (sender, e) =>
            {
                Wishlist.Instance.AddSelectedData(mcdonaldsData);
                MessageBox.Show($"'{mcdonaldsData.Title}' telah dipilih!");
            };

            Label genreLabel = new Label();
            genreLabel.Text = mcdonaldsData.Title;
            genreLabel.Font = new Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            genreLabel.Location = new Point(10, 215);
            genreLabel.Width = 223;
            genreLabel.Cursor = Cursors.Hand;
            genreLabel.Click += (sender, e) =>
            {
                Wishlist.Instance.AddSelectedData(mcdonaldsData);
                MessageBox.Show($"'{mcdonaldsData.Title}' telah dipilih!");
            };

            Label titleTextBox = new Label();
            titleTextBox.Text = mcdonaldsData.Subtitle;
            titleTextBox.Font = new Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            titleTextBox.Location = new Point(10, 240);
            titleTextBox.Width = 223;
            titleTextBox.Cursor = Cursors.Hand;
            titleTextBox.Click += (sender, e) =>
            {
                string selectedMcdonaldsTitles = string.Join(", ", wishlist.SelectedMcdonaldsData.Select(mcdonalds => mcdonaldsData.Subtitle));
                Wishlist.Instance.AddSelectedData(mcdonaldsData);
                MessageBox.Show($"'{selectedMcdonaldsTitles}' telah dipilih!");
            };

            BunifuCards groupBox = new BunifuCards();
            groupBox.Width = 233;
            groupBox.Height = 287;
            groupBox.IndicatorColor = Color.Transparent;
            groupBox.BorderRadius = 30;
            groupBox.Controls.Add(pictureBox);
            groupBox.Controls.Add(genreLabel);
            groupBox.Controls.Add(titleTextBox);

            groupBox.Click += (sender, e) =>
            {
                Wishlist.Instance.AddSelectedData(mcdonaldsData);
                MessageBox.Show($"'{mcdonaldsData.Title}' telah dipilih!");
            };

            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.Controls.Add(groupBox);
        }

        private void CatalogueSection_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
