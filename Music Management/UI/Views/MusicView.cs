using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Music_Management.Globals;
using Music_Management.Helpers;
using Music_Management.Models;
using Music_Management.Repositories;
using Music_Management.Services;
using Music_Management.UI.Popup;
using Music_Management.UI.SubUI;

namespace Music_Management.UI.Views
{
    public partial class MusicView : UserControl
    {
        private readonly string _permission;
        public MusicView(string permission)
        {
            _permission = permission;
            InitializeComponent();
            ValidatePermission();
            SongCache.Songs = SongRepository.GetAll();
            LoadMusicData();
        }

        private void ValidatePermission()
        {
            if (_permission == "admin")
            {
                this.btnAdd.Visible = true;
                this.btnEdit.Visible = true;
                this.btnDelete.Visible = true;
                this.btnSave.Visible = true;
                this.btnCancel.Visible = true;
            }
        }

        private void LoadMusicData()
        {
            listMusic.Items.Clear();
            int stt = 1;

            foreach (var song in SongCache.Songs)
            {
                string title = string.IsNullOrEmpty(song.Title) ? "(Không có)" : song.Title;
                string artistName = song.Artist?.Name ?? "(Không có)";
                string album = string.IsNullOrEmpty(song.Album) ? "(Không có)" : song.Album;
                string releaseDate = string.IsNullOrEmpty(song.ReleaseDate) ? "(Không có)" : song.ReleaseDate;
                string duration = string.IsNullOrEmpty(song.Duration) ? "(Không có)" : song.Duration;

                ListViewItem item = new ListViewItem(stt.ToString()); // cột 1: STT
                item.SubItems.Add(title);
                item.SubItems.Add(artistName);
                item.SubItems.Add(album);
                item.SubItems.Add(releaseDate);
                item.SubItems.Add(duration);

                item.Tag = song;

                listMusic.Items.Add(item);
                stt++;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var popup = new MusicPopup("add");
            popup.ShowDialog(this);
            LoadMusicData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listMusic.SelectedItems.Count > 0)
            {
                var song = (Song)listMusic.SelectedItems[0].Tag;
                if (song != null)
                {
                    using var popup = new MusicPopup("edit", song);
                    popup.ShowDialog(this);
                    LoadMusicData();
                }
            }
            else
            {
                Utils.ShowWarning("Hãy chọn 1 bài hát để chỉnh sửa!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(listMusic.SelectedItems.Count > 0)
            {
                if (Utils.Confirm("Bạn có chắc chắn muốn xóa các bài hát này?"))
                {
                    foreach(ListViewItem item in listMusic.SelectedItems)
                    {
                        var song = (Song)item.Tag;
                        int id = song.Id;
                        SongService.Delete(id);
                        LoadMusicData();
                    }
                }
            }
            else
            {
                Utils.ShowWarning("Hãy chọn ít nhất một bài hát để xóa!");
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (listMusic.SelectedItems.Count > 0)
            {
                var index = listMusic.SelectedIndices[0];
                using var popup = new MusicPlayer(SongCache.Songs, index);
                popup.ShowDialog(this);
            }
            else
            {
                Utils.ShowWarning("Hãy chọn 1 bài hát để phát!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SongService.SaveChanges();
            Utils.ShowInfo("Đã lưu tất cả mọi thay đổi");
            LoadMusicData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Utils.Confirm("Bạn có chắc chắn muốn hủy bỏ tất cả mọi thay đổi?"))
            {
                SongService.Cancel();
                MessageBox.Show("Đã hủy thay đổi");
                LoadMusicData();
            }
        }
    }
}
