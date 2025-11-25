using Music_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Management.UI.SubUI
{
    public partial class ArtistCard : UserControl
    {
        public Artist Artist { get; private set; }

        public ArtistCard(Artist artist)
        {
            InitializeComponent();
            Artist = artist;
            LoadArtist();
        }

        private void LoadArtist()
        {
            lblName.Text = Artist.Name;
            picArtist.Image = Image.FromFile(Artist.ImagePath);

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            using var detail = new ArtistDetail(Artist);
            if(detail.ShowDialog(this) == DialogResult.OK)
            {
                LoadArtist();
            }
        }
    }
}
