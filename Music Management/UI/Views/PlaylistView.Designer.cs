using System;
using System.Drawing;
using System.Windows.Forms;

namespace Music_Management.UI.Views
{
    partial class PlaylistView
    {
        private System.ComponentModel.IContainer components = null;

        private SplitContainer splitContainer;
        private ListView playlistListView;
        private ListView songListView;

        private Panel bottomPanel;

        private Label lblSongQuantity;
        private Label lblDescription;

        private Button btnAddSong;
        private Button btnRemoveSong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            splitContainer = new SplitContainer();
            playlistListView = new ListView();
            None = new ColumnHeader();
            title = new ColumnHeader();
            songListView = new ListView();
            None2 = new ColumnHeader();
            songTitle = new ColumnHeader();
            artist = new ColumnHeader();
            album = new ColumnHeader();
            duration = new ColumnHeader();
            bottomPanel = new Panel();
            btnAddPlaylist = new Button();
            btnAddSong = new Button();
            lblDescription = new Label();
            btnRemoveSong = new Button();
            lblSongQuantity = new Label();
            btnEditPlaylist = new Button();
            btnCancelPlaylist = new Button();
            btnSavePlaylist = new Button();
            btnDeletePlaylist = new Button();
            btnPlay = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            bottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(playlistListView);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(songListView);
            splitContainer.Size = new Size(1360, 350);
            splitContainer.SplitterDistance = 300;
            splitContainer.TabIndex = 0;
            // 
            // playlistListView
            // 
            playlistListView.Columns.AddRange(new ColumnHeader[] { None, title });
            playlistListView.Dock = DockStyle.Fill;
            playlistListView.Font = new Font("Quicksand", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playlistListView.FullRowSelect = true;
            playlistListView.Location = new Point(0, 0);
            playlistListView.Name = "playlistListView";
            playlistListView.Size = new Size(300, 350);
            playlistListView.TabIndex = 0;
            playlistListView.UseCompatibleStateImageBehavior = false;
            playlistListView.View = View.Details;
            playlistListView.SelectedIndexChanged += playlistListView_SelectedIndexChanged;
            // 
            // None
            // 
            None.DisplayIndex = 1;
            None.Width = 0;
            // 
            // title
            // 
            title.DisplayIndex = 0;
            title.Text = "Danh sách phát";
            title.TextAlign = HorizontalAlignment.Center;
            title.Width = 300;
            // 
            // songListView
            // 
            songListView.Columns.AddRange(new ColumnHeader[] { None2, songTitle, artist, album, duration });
            songListView.Dock = DockStyle.Fill;
            songListView.Font = new Font("Quicksand", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            songListView.FullRowSelect = true;
            songListView.Location = new Point(0, 0);
            songListView.Name = "songListView";
            songListView.Size = new Size(1056, 350);
            songListView.TabIndex = 0;
            songListView.UseCompatibleStateImageBehavior = false;
            songListView.View = View.Details;
            // 
            // None2
            // 
            None2.Width = 0;
            // 
            // songTitle
            // 
            songTitle.Text = "Tên bài hát";
            songTitle.TextAlign = HorizontalAlignment.Center;
            songTitle.Width = 410;
            // 
            // artist
            // 
            artist.Text = "Nghệ sĩ";
            artist.TextAlign = HorizontalAlignment.Center;
            artist.Width = 200;
            // 
            // album
            // 
            album.Text = "Album";
            album.TextAlign = HorizontalAlignment.Center;
            album.Width = 200;
            // 
            // duration
            // 
            duration.Text = "Thời lượng";
            duration.TextAlign = HorizontalAlignment.Center;
            duration.Width = 200;
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(btnPlay);
            bottomPanel.Controls.Add(btnAddPlaylist);
            bottomPanel.Controls.Add(btnAddSong);
            bottomPanel.Controls.Add(lblDescription);
            bottomPanel.Controls.Add(btnRemoveSong);
            bottomPanel.Controls.Add(lblSongQuantity);
            bottomPanel.Controls.Add(btnEditPlaylist);
            bottomPanel.Controls.Add(btnCancelPlaylist);
            bottomPanel.Controls.Add(btnSavePlaylist);
            bottomPanel.Controls.Add(btnDeletePlaylist);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 554);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Padding = new Padding(10);
            bottomPanel.Size = new Size(1360, 250);
            bottomPanel.TabIndex = 1;
            // 
            // btnAddPlaylist
            // 
            btnAddPlaylist.Font = new Font("Quicksand", 10F);
            btnAddPlaylist.Location = new Point(206, 127);
            btnAddPlaylist.Name = "btnAddPlaylist";
            btnAddPlaylist.Size = new Size(213, 50);
            btnAddPlaylist.TabIndex = 0;
            btnAddPlaylist.Text = "Thêm danh sách phát";
            btnAddPlaylist.Click += btnAddPlaylist_Click;
            // 
            // btnAddSong
            // 
            btnAddSong.Font = new Font("Quicksand", 10F);
            btnAddSong.Location = new Point(304, 187);
            btnAddSong.Name = "btnAddSong";
            btnAddSong.Size = new Size(306, 50);
            btnAddSong.TabIndex = 0;
            btnAddSong.Text = "Thêm bài hát vào danh sách phát";
            btnAddSong.Click += btnAddSong_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(13, 52);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 30);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Mô tả:";
            // 
            // btnRemoveSong
            // 
            btnRemoveSong.Font = new Font("Quicksand", 10F);
            btnRemoveSong.Location = new Point(772, 187);
            btnRemoveSong.Name = "btnRemoveSong";
            btnRemoveSong.Size = new Size(272, 50);
            btnRemoveSong.TabIndex = 1;
            btnRemoveSong.Text = "Gỡ bài hát khỏi danh sách phát";
            btnRemoveSong.Click += btnRemoveSong_Click;
            // 
            // lblSongQuantity
            // 
            lblSongQuantity.AutoSize = true;
            lblSongQuantity.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSongQuantity.Location = new Point(13, 10);
            lblSongQuantity.Name = "lblSongQuantity";
            lblSongQuantity.Size = new Size(182, 30);
            lblSongQuantity.TabIndex = 2;
            lblSongQuantity.Text = "Số lượng bài hát: 0";
            // 
            // btnEditPlaylist
            // 
            btnEditPlaylist.Font = new Font("Quicksand", 10F);
            btnEditPlaylist.Location = new Point(425, 127);
            btnEditPlaylist.Name = "btnEditPlaylist";
            btnEditPlaylist.Size = new Size(213, 50);
            btnEditPlaylist.TabIndex = 1;
            btnEditPlaylist.Text = "Sửa danh sách phát";
            btnEditPlaylist.Click += btnEditPlaylist_Click;
            // 
            // btnCancelPlaylist
            // 
            btnCancelPlaylist.Font = new Font("Quicksand", 10F);
            btnCancelPlaylist.Location = new Point(988, 127);
            btnCancelPlaylist.Name = "btnCancelPlaylist";
            btnCancelPlaylist.Size = new Size(150, 50);
            btnCancelPlaylist.TabIndex = 4;
            btnCancelPlaylist.Text = "Hủy thay đổi";
            btnCancelPlaylist.Click += btnCancelPlaylist_Click;
            // 
            // btnSavePlaylist
            // 
            btnSavePlaylist.Font = new Font("Quicksand", 10F);
            btnSavePlaylist.Location = new Point(832, 127);
            btnSavePlaylist.Name = "btnSavePlaylist";
            btnSavePlaylist.Size = new Size(150, 50);
            btnSavePlaylist.TabIndex = 3;
            btnSavePlaylist.Text = "Lưu thay đổi";
            btnSavePlaylist.Click += btnSavePlaylist_Click;
            // 
            // btnDeletePlaylist
            // 
            btnDeletePlaylist.Font = new Font("Quicksand", 10F);
            btnDeletePlaylist.Location = new Point(644, 127);
            btnDeletePlaylist.Name = "btnDeletePlaylist";
            btnDeletePlaylist.Size = new Size(182, 50);
            btnDeletePlaylist.TabIndex = 2;
            btnDeletePlaylist.Text = "Xóa danh sách phát";
            btnDeletePlaylist.Click += btnDeletePlaylist_Click;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Quicksand", 10F);
            btnPlay.Location = new Point(616, 187);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(150, 50);
            btnPlay.TabIndex = 5;
            btnPlay.Text = "Phát danh sách";
            btnPlay.Click += btnPlay_Click;
            // 
            // PlaylistView
            // 
            Controls.Add(splitContainer);
            Controls.Add(bottomPanel);
            Name = "PlaylistView";
            Size = new Size(1360, 804);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            ResumeLayout(false);
        }
        private ColumnHeader title;
        private ColumnHeader None;
        private ColumnHeader None2;
        private ColumnHeader songTitle;
        private ColumnHeader artist;
        private ColumnHeader album;
        private ColumnHeader duration;
        private Button btnCancelPlaylist;
        private Button btnSavePlaylist;
        private Button btnDeletePlaylist;
        private Button btnEditPlaylist;
        private Button btnAddPlaylist;
        private Button btnPlay;
    }
}
