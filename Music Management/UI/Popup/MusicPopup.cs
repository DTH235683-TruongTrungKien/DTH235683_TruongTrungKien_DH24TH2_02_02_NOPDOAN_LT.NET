

using Music_Management.Helpers;
using Music_Management.Models;
using Music_Management.Repositories;
using Music_Management.Services;

namespace Music_Management.UI.Popup
{
    public partial class MusicPopup : Form
    {
        private readonly string option;
        private readonly Song? editingSong;

        public MusicPopup(string option, Song? song = null)
        {
            InitializeComponent();
            lblTitle.Text = option == "add" ? "Thêm bài hát" : "Chỉnh sửa bài hát";
            this.option = option;
            this.editingSong = song;

            LoadArtists();

            if (option == "edit" && song != null)
                FillValues();

            btnChooseFile.Click += BtnChooseFile_Click;
            btnOk.Click += BtnOk_Click;
            btnCancel.Click += (s, e) => Close();
        }

        private void LoadArtists()
        {
            var artists = ArtistRepository.GetAll(); // Lấy toàn bộ Artist từ DB
            cmbArtist.Items.Clear();

            foreach (var a in artists)
                cmbArtist.Items.Add(a.Name);

            cmbArtist.Items.Add("(Không có)");
        }


        private void FillValues()
        {
            txtTitle.Text = editingSong.Title;
            txtAlbum.Text = editingSong.Album;
            txtRelease.Text = editingSong.ReleaseDate;
            txtDuration.Text = editingSong.Duration;
            txtFilePath.Text = editingSong.FilePath;
            cmbArtist.SelectedItem = editingSong.Artist?.Name ?? "(Không có)";
        }

        private void BtnChooseFile_Click(object? sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();
            dialog.Title = "Chọn file nhạc";
            dialog.Filter = "MP3 Files|*.mp3";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = dialog.FileName;
                txtTitle.Text = System.IO.Path.GetFileNameWithoutExtension(dialog.FileName);

                // Đọc duration bằng TagLib
                var tfile = TagLib.File.Create(dialog.FileName);
                txtDuration.Text = TimeSpan.FromSeconds(tfile.Properties.Duration.TotalSeconds)
                                   .ToString(@"mm\:ss");
            }
        }

        private void BtnOk_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                Utils.ShowWarning("Vui lòng nhập tên bài hát!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFilePath.Text))
            {
                Utils.ShowWarning("Vui lòng chọn file!");
                return;
            }

            string artistName = cmbArtist.SelectedItem?.ToString() ?? "(Không có)";
            Artist? artist = null;

            if (artistName != "(Không có)")
            {
                artist = ArtistRepository.GetAll().FirstOrDefault(a => a.Name == artistName);
            }

            if (option == "add")
            {
                Song newSong = new Song
                {
                    Title = txtTitle.Text,
                    Album = txtAlbum.Text,
                    ReleaseDate = txtRelease.Text,
                    Duration = txtDuration.Text,
                    FilePath = txtFilePath.Text,
                    Artist = artist
                };
                SongService.Add(newSong);
            }
            else if (option == "edit")
            {
                editingSong.Title = txtTitle.Text;
                editingSong.Album = txtAlbum.Text;
                editingSong.ReleaseDate = txtRelease.Text;
                editingSong.Duration = txtDuration.Text;
                editingSong.FilePath = txtFilePath.Text;
                editingSong.Artist = artist;

                SongService.Edit(editingSong);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
