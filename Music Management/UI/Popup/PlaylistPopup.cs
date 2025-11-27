using System;
using System.Linq;
using System.Windows.Forms;
using Music_Management.Helpers;
using Music_Management.Models;
using Music_Management.Repositories;
using Music_Management.Services;

namespace Music_Management.UI.Popup
{
    public partial class PlaylistPopup : Form
    {
        private readonly string option;
        private readonly Playlist? editingPlaylist;

        public PlaylistPopup(string option, Playlist? playlist = null)
        {
            InitializeComponent();

            this.option = option;
            this.editingPlaylist = playlist;

            lblTitle.Text = option == "add" ? "Thêm danh sách phát" : "Chỉnh sửa danh sách phát";

            if (option == "edit" && playlist != null)
                FillValues();
        }

        private void FillValues()
        {
            if (editingPlaylist == null) return;

            txtTitle.Text = editingPlaylist.Title;
            txtDescription.Text = editingPlaylist.Description;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                Utils.ShowWarning("Vui lòng nhập tên danh sách phát!");
                return;
            }

            if (option == "add")
            {
                Playlist newPlaylist = new Playlist
                {
                    Title = txtTitle.Text,
                    Description = txtDescription.Text,
                };
                PlaylistService.AddPlaylist(newPlaylist);
            }
            else if (option == "edit" && editingPlaylist != null)
            {
                editingPlaylist.Title = txtTitle.Text;
                editingPlaylist.Description = txtDescription.Text;
                PlaylistService.EditPlaylist(editingPlaylist);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
