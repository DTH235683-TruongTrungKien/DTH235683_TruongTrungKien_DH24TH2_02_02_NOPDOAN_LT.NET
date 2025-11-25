using System;
using System.Windows.Forms;
using Music_Management.Globals;
using Music_Management.Helpers;
using Music_Management.Models;
using Music_Management.Repositories;
using Music_Management.Services;
using Music_Management.UI.Popup;

namespace Music_Management.UI.Views
{
    public partial class PlaylistView : UserControl
    {
        public PlaylistView()
        {
            InitializeComponent();
            PlaylistCache.Playlists = PlaylistRepository.GetAll();
            PlaylistCache.PlaylistSongs = PlaylistRepository.GetPlaylistSongs();
            LoadPlaylistData();
        }

        private void LoadPlaylistData()
        {
            playlistListView.Items.Clear();
            int stt = 1;

            foreach (var playlist in PlaylistCache.Playlists)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(playlist.Title ?? "(Không có)");
                item.SubItems.Add(playlist.Description ?? "(Không có)");
                item.SubItems.Add(playlist.Songs?.Count.ToString() ?? "0");
                item.Tag = playlist;
                playlistListView.Items.Add(item);
                stt++;
            }

            songListView.Items.Clear();
            lblSongQuantity.Text = "Số lượng bài hát: 0";
            lblDescription.Text = "Mô tả:";
        }

        private void LoadSongsInPlaylist()
        {
            if (playlistListView.SelectedItems.Count > 0)
            {
                songListView.Items.Clear();

                var selectedPlaylist = (Playlist)playlistListView.SelectedItems[0].Tag;
                int playlistId = selectedPlaylist.Id;
                List<int> addedSongsId = new List<int>();
                List<Song> addedSongs = new List<Song>();
                foreach (PlaylistSong playlistSong in PlaylistCache.PlaylistSongs)
                {
                    if (playlistSong.PlaylistId == playlistId)
                    {
                        addedSongsId.Add(playlistSong.SongId);
                    }
                }
                foreach (Song song in SongCache.Songs)
                {
                    if (addedSongsId.Contains(song.Id))
                    {
                        addedSongs.Add(song);
                    }
                }
                foreach (var song in addedSongs)
                {
                    var item = new ListViewItem();
                    item.SubItems.Add(song.Title ?? "(Không có)");
                    item.SubItems.Add(song.Artist?.Name ?? "(Không có)");
                    item.SubItems.Add(song.Album ?? "(Không có)");
                    item.SubItems.Add(song.Duration ?? "(Không có)");
                    item.Tag = song;
                    songListView.Items.Add(item);
                }

                lblDescription.Text = "Mô tả: " + (selectedPlaylist.Description ?? "(Không có)");
                lblSongQuantity.Text = "Số lượng bài hát: " + selectedPlaylist.Songs.Count;
            }
        }
        private void playlistListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSongsInPlaylist();
        }

        // ------------------- Playlist CRUD -------------------
        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            using var popup = new PlaylistPopup("add");
            if (popup.ShowDialog() == DialogResult.OK)
            {
                LoadPlaylistData();
            }
        }

        private void btnEditPlaylist_Click(object sender, EventArgs e)
        {
            if (playlistListView.SelectedItems.Count > 0)
            {
                var selectedPlaylist = (Playlist)playlistListView.SelectedItems[0].Tag;
                if (selectedPlaylist != null)
                {
                    using var popup = new PlaylistPopup("edit", selectedPlaylist);
                    popup.ShowDialog(this);
                    LoadPlaylistData();
                }
            }
            else
            {
                Utils.ShowWarning("Hãy chọn một danh sách phát để chỉnh sửa!");
            }
        }

        private void btnDeletePlaylist_Click(object sender, EventArgs e)
        {
            if (playlistListView.SelectedItems.Count > 0)
            {
                if (Utils.Confirm("Bạn có chắc chắn muốn xóa các danh sách phát này?"))
                {
                    foreach (ListViewItem item in playlistListView.SelectedItems)
                    {
                        var playlist = (Playlist)item.Tag;
                        int id = playlist.Id;
                        PlaylistService.DeletePlaylist(id);
                        LoadPlaylistData();
                    }
                }
            }
            else
            {
                Utils.ShowWarning("Hãy chọn ít nhất một danh sách phát để xóa!");
            }
        }

        private void btnSavePlaylist_Click(object sender, EventArgs e)
        {
            PlaylistService.SaveChanges();
            Utils.ShowInfo("Đã lưu tất cả mọi thay đổi");
            LoadPlaylistData();
        }

        private void btnCancelPlaylist_Click(object sender, EventArgs e)
        {
            if (Utils.Confirm("Bạn có chắc chắn muốn hủy bỏ tất cả mọi thay đổi?"))
            {
                PlaylistService.Cancel();
                Utils.ShowInfo("Đã hủy thay đổi");
                LoadPlaylistData();
            }
        }

        // ------------------- Song CRUD -------------------
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if (playlistListView.SelectedItems.Count > 0)
            {
                var selectedPlaylist = (Playlist)playlistListView.SelectedItems[0].Tag;
                if (selectedPlaylist != null)
                {
                    List<Song> addedSongs = new List<Song>();
                    foreach (ListViewItem item in songListView.Items)
                    {
                        Song song = (Song)item.Tag;
                        addedSongs.Add(song);
                    }
                    using var popup = new PlaylistSongsPopup(selectedPlaylist, addedSongs);
                    if (popup.ShowDialog() == DialogResult.OK)
                    {
                        LoadSongsInPlaylist();
                    }
                }
            }
            else
            {
                Utils.ShowWarning("Hãy chọn một danh sách phát để thêm bài hát!");
            }
        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            if (playlistListView.SelectedItems.Count > 0)
            {
                if (songListView.SelectedItems.Count > 0)
                {
                    if (Utils.Confirm("Bạn có chắc chắn muốn gỡ các bài hát này danh sách phát?"))
                    {
                        var playlist = (Playlist)playlistListView.SelectedItems[0].Tag;
                        if (playlist != null)
                        {
                            int playlistId = playlist.Id;
                            foreach (ListViewItem item in songListView.SelectedItems)
                            {
                                Song removedSong = (Song)item.Tag;
                                int songId = removedSong.Id;
                                PlaylistSong playlistSong = new PlaylistSong
                                {
                                    PlaylistId = playlistId,
                                    SongId = songId
                                };
                                PlaylistService.RemoveSongFromPlaylist(playlistSong);
                            }
                        }
                        LoadSongsInPlaylist();
                    }
                }
                else
                {
                    Utils.ShowWarning("Hãy chọn ít nhất một bài hát để gỡ bỏ!");
                }
            }
            else
            {
                Utils.ShowWarning("Hãy chọn một danh sách phát để gỡ bài hát!");
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (songListView.SelectedItems.Count > 0)
            {
                var index = songListView.SelectedIndices[0];
                List<Song> playSongs = new List<Song>();
                foreach (ListViewItem item in songListView.SelectedItems)
                {
                    playSongs.Add((Song)item.Tag);
                }
                using var popup = new MusicPlayer(playSongs, index);
                popup.ShowDialog(this);
            }
            else
            {
                Utils.ShowWarning("Hãy chọn 1 bài hát để phát!");
            }
        }
    }
}
