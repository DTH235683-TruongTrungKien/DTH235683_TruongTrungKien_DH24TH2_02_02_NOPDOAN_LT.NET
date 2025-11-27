using Music_Management.Models;

namespace Music_Management.UI.SubUI
{
    public partial class ArtistCard : UserControl
    {
        private readonly string _permission;
        public Artist Artist { get; private set; }

        public ArtistCard(Artist artist, string permission)
        {
            _permission = permission;
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
            using var detail = new ArtistDetail(Artist, _permission);
            if(detail.ShowDialog(this) == DialogResult.OK)
            {
                LoadArtist();
            }
        }
    }
}
