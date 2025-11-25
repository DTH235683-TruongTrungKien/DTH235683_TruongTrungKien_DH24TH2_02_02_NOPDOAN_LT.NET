using System;
using System.Linq;
using System.Windows.Forms;
using Music_Management.Helpers;
using Music_Management.Models;
using Music_Management.Repositories;
using Music_Management.Services;

namespace Music_Management.UI.Popup
{
    public partial class PlaylistSongsPopup : Form
    {
        private readonly Playlist targetPlaylist;
        private readonly List<Song> addedSongs;

        public PlaylistSongsPopup(Playlist playlist, List<Song> songs)
        {
            InitializeComponent();
            targetPlaylist = playlist;
            addedSongs = songs;
            LoadSongsToAdd();
        }

        private void LoadSongsToAdd()
        {
            lvSongs.Items.Clear();

            var allSongs = SongRepository.GetAll();
            List<Song> visibleSongs = new List<Song>();
            foreach(Song song in allSongs)
            {
                if(!addedSongs.Any(s => s.Id == song.Id))
                {
                    visibleSongs.Add(song);
                }
            }

            foreach (var song in visibleSongs)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(song.Title);
                item.SubItems.Add(song.Duration);
                item.Tag = song;
                lvSongs.Items.Add(item);
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lvSongs.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvSongs.SelectedItems)
                {
                    Song song = (Song)item.Tag;
                    int songId = song.Id;
                    PlaylistSong playlistSong = new PlaylistSong
                    {
                        PlaylistId = targetPlaylist.Id,
                        SongId = songId
                    };
                    PlaylistService.AddSongToPlaylist(playlistSong);
                }
            }
            else
            {
                Utils.ShowWarning("Hãy chọn ít nhất một bài hát để thêm!");
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }
    }
}
