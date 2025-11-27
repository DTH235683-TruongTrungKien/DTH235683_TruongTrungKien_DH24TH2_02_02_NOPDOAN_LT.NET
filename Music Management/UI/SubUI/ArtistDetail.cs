using Music_Management.Helpers;
using Music_Management.Models;
using Music_Management.Repositories;
using Music_Management.UI.Views;
using Music_Management.UI.Popup;
using Music_Management.Services;
using Music_Management.Globals;

namespace Music_Management.UI.SubUI
{
    public partial class ArtistDetail : Form
    {
        private readonly string _permission;
        private Artist artist;
        private List<Song> songs;

        public ArtistDetail(Artist artist, string permission)
        {
            _permission = permission;
            InitializeComponent();
            ValidatePermission();
            this.artist = artist;
            this.songs = SongRepository.GetSongByArtistId(artist.Id);
            LoadArtistDetail();
            LoadSongs();
            DialogResult = DialogResult.OK;
        }
        private void ValidatePermission()
        {
            if (_permission == "admin")
            {
                this.btnEdit.Visible = true;
                this.btnDelete.Visible = true;
            }
        }

        private void LoadArtistDetail()
        {
            lblName.Text = $"Tên nghệ sĩ: {artist.Name}";
            lblBirth.Text = $"Ngày sinh: {artist.BirthDay}";
            lblCountry.Text = $"Quốc gia: {artist.Country}";

            if (File.Exists(artist.ImagePath))
            {
                picArtist.Image = Image.FromFile(artist.ImagePath);
            }
        }

        private void LoadSongs()
        {
            listDetail.Items.Clear();
            
            foreach (Song song in songs)
            {
                Utils.ConvertValues(song);
                var item = new ListViewItem();
                item.SubItems.Add(song.Title);
                item.SubItems.Add(song.Album);
                item.SubItems.Add(song.ReleaseDate);
                item.SubItems.Add(song.Duration);
                
                item.Tag = song;

                listDetail.Items.Add(item);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using var popup = new ArtistPopup("edit", artist);
            if (popup.ShowDialog(this) == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa nghệ sĩ này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                ArtistService.Delete(artist.Id);
                Close();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (listDetail.SelectedItems.Count > 0)
            {
                var index = listDetail.SelectedIndices[0];
                using var popup = new MusicPlayer(songs, index);
                popup.ShowDialog(this);
            }
            else
            {
                Utils.ShowWarning("Hãy chọn 1 bài hát để phát!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
