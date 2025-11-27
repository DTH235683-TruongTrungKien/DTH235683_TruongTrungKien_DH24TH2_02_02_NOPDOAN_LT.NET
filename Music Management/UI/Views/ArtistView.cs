using Music_Management.Globals;
using Music_Management.Helpers;
using Music_Management.Models;
using Music_Management.Repositories;
using Music_Management.Services;
using Music_Management.UI.Popup;
using Music_Management.UI.SubUI;

namespace Music_Management.UI.Views
{
    public partial class ArtistView : UserControl
    {
        private readonly string _permission;
        private List<Artist> artists = new();

        public ArtistView(string permission)
        {
            _permission = permission;
            InitializeComponent();
            ValidatePermission();
            ArtistCache.Artists = ArtistRepository.GetAll();
            LoadArtists();
        }
        private void ValidatePermission()
        {
            if (_permission == "admin")
            {
                this.btnAdd.Visible = true;
                this.btnSave.Visible = true;
                this.btnCancel.Visible = true;
            }
        }

        public void LoadArtists()
        {
            flowArtists.Controls.Clear();

            foreach (var artist in ArtistCache.Artists)
            {
                var card = new ArtistCard(artist, _permission);
                card.Margin = new Padding(15);
                flowArtists.Controls.Add(card);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var popup = new ArtistPopup("add");
            if(popup.ShowDialog(this) == DialogResult.OK)
            {
                LoadArtists();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ArtistService.SaveChanges();
            Utils.ShowInfo("Đã lưu tất cả mọi thay đổi");
            LoadArtists();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ArtistService.Cancel();
            MessageBox.Show("Đã hủy thay đổi");
            LoadArtists();
        }
    }
}
