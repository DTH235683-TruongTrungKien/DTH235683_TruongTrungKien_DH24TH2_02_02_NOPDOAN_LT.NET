using System;
using System.Windows.Forms;

namespace Music_Management.UI.Popup
{
    partial class PlaylistSongsPopup
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private ListView lvSongs;
        private ColumnHeader colTitle;
        private ColumnHeader colDuration;
        private Button btnOk;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lvSongs = new ListView();
            None = new ColumnHeader();
            colTitle = new ColumnHeader();
            colDuration = new ColumnHeader();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Quicksand Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(460, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thêm bài hát vào danh sách phát";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lvSongs
            // 
            lvSongs.Columns.AddRange(new ColumnHeader[] { None, colTitle, colDuration });
            lvSongs.Font = new Font("Quicksand", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvSongs.FullRowSelect = true;
            lvSongs.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvSongs.Location = new Point(12, 50);
            lvSongs.Name = "lvSongs";
            lvSongs.Size = new Size(460, 250);
            lvSongs.TabIndex = 1;
            lvSongs.UseCompatibleStateImageBehavior = false;
            lvSongs.View = View.Details;
            // 
            // None
            // 
            None.DisplayIndex = 2;
            None.Width = 0;
            // 
            // colTitle
            // 
            colTitle.DisplayIndex = 0;
            colTitle.Text = "Tên bài hát";
            colTitle.TextAlign = HorizontalAlignment.Center;
            colTitle.Width = 300;
            // 
            // colDuration
            // 
            colDuration.DisplayIndex = 1;
            colDuration.Text = "Thời lượng";
            colDuration.TextAlign = HorizontalAlignment.Center;
            colDuration.Width = 150;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(100, 320);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 35);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(260, 320);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // PlaylistSongsPopup
            // 
            ClientSize = new Size(484, 380);
            Controls.Add(lblTitle);
            Controls.Add(lvSongs);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PlaylistSongsPopup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm bài hát vào danh sách phát";
            ResumeLayout(false);
        }
        private ColumnHeader None;
    }
}
