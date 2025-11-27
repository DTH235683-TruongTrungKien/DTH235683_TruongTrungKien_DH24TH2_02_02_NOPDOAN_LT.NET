namespace Music_Management.UI.Views
{
    partial class MusicView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            btnCancel = new Button();
            btnSave = new Button();
            btnPlay = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            panelButtons = new Panel();
            listMusic = new ListView();
            stt = new ColumnHeader();
            title = new ColumnHeader();
            artistName = new ColumnHeader();
            album = new ColumnHeader();
            releaseDate = new ColumnHeader();
            duration = new ColumnHeader();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Quicksand", 10F);
            btnCancel.Location = new Point(918, 52);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 50);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Hủy thay đổi";
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Quicksand", 10F);
            btnSave.Location = new Point(741, 52);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 50);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu thay đổi";
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Quicksand", 10F);
            btnPlay.Location = new Point(1093, 52);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(150, 50);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "Phát bài hát";
            btnPlay.Click += btnPlay_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Quicksand", 10F);
            btnDelete.Location = new Point(565, 52);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 50);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa bài hát";
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Quicksand", 10F);
            btnEdit.Location = new Point(391, 52);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 50);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa bài hát";
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Quicksand", 10F);
            btnAdd.Location = new Point(215, 52);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm bài hát";
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Controls.Add(btnEdit);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnPlay);
            panelButtons.Controls.Add(btnSave);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 566);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(1300, 134);
            panelButtons.TabIndex = 1;
            // 
            // listMusic
            // 
            listMusic.Columns.AddRange(new ColumnHeader[] { stt, title, artistName, album, releaseDate, duration });
            listMusic.FullRowSelect = true;
            listMusic.Location = new Point(0, 0);
            listMusic.Name = "listMusic";
            listMusic.Size = new Size(1300, 486);
            listMusic.TabIndex = 2;
            listMusic.UseCompatibleStateImageBehavior = false;
            listMusic.View = View.Details;
            // 
            // stt
            // 
            stt.Text = "STT";
            stt.Width = 50;
            // 
            // title
            // 
            title.Text = "Tên bài hát";
            title.TextAlign = HorizontalAlignment.Center;
            title.Width = 500;
            // 
            // artistName
            // 
            artistName.Text = "Nghệ sĩ";
            artistName.TextAlign = HorizontalAlignment.Center;
            artistName.Width = 200;
            // 
            // album
            // 
            album.Text = "Album";
            album.TextAlign = HorizontalAlignment.Center;
            album.Width = 200;
            // 
            // releaseDate
            // 
            releaseDate.Text = "Ngày phát hành";
            releaseDate.TextAlign = HorizontalAlignment.Center;
            releaseDate.Width = 200;
            // 
            // duration
            // 
            duration.Text = "Thời lượng";
            duration.TextAlign = HorizontalAlignment.Center;
            duration.Width = 120;
            // 
            // MusicView
            // 
            Controls.Add(listMusic);
            Controls.Add(panelButtons);
            Name = "MusicView";
            Size = new Size(1300, 700);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Button btnPlay;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Panel panelButtons;
        private ListView listMusic;
        private ColumnHeader stt;
        private ColumnHeader title;
        private ColumnHeader artistName;
        private ColumnHeader album;
        private ColumnHeader duration;
        private ColumnHeader releaseDate;
    }
}
