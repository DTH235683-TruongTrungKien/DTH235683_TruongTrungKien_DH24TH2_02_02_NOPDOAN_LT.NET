namespace Music_Management.UI.SubUI
{
    partial class ArtistDetail
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox picArtist;
        private Panel panelInfo;
        private Panel panelButtons;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnPlay;
        private Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelInfo = new Panel();
            lblBirth = new Label();
            lblCountry = new Label();
            lblName = new Label();
            label2 = new Label();
            lbList = new Label();
            picArtist = new PictureBox();
            panelButtons = new Panel();
            btnEdit = new Button();
            btnDelete = new Button();
            btnPlay = new Button();
            btnClose = new Button();
            listDetail = new ListView();
            None = new ColumnHeader();
            title = new ColumnHeader();
            album = new ColumnHeader();
            releaseDate = new ColumnHeader();
            duration = new ColumnHeader();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picArtist).BeginInit();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(lblBirth);
            panelInfo.Controls.Add(lblCountry);
            panelInfo.Controls.Add(lblName);
            panelInfo.Controls.Add(label2);
            panelInfo.Controls.Add(lbList);
            panelInfo.Controls.Add(picArtist);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Location = new Point(0, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Padding = new Padding(10);
            panelInfo.Size = new Size(982, 249);
            panelInfo.TabIndex = 2;
            // 
            // lblBirth
            // 
            lblBirth.AutoSize = true;
            lblBirth.Font = new Font("Quicksand Bold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBirth.Location = new Point(206, 105);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(116, 30);
            lblBirth.TabIndex = 8;
            lblBirth.Text = "Ngày sinh:";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Quicksand Bold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountry.Location = new Point(206, 151);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(113, 30);
            lblCountry.TabIndex = 7;
            lblCountry.Text = "Quê quán:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Quicksand Bold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(206, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(129, 30);
            lblName.TabIndex = 6;
            lblName.Text = "Tên nghệ sĩ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand Bold", 16.9999981F, FontStyle.Bold);
            label2.Location = new Point(377, 9);
            label2.Name = "label2";
            label2.Size = new Size(224, 43);
            label2.TabIndex = 5;
            label2.Text = "Chi tiết nghệ sĩ";
            // 
            // lbList
            // 
            lbList.AutoSize = true;
            lbList.Font = new Font("Quicksand Bold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbList.Location = new Point(13, 213);
            lbList.Name = "lbList";
            lbList.Size = new Size(191, 30);
            lbList.TabIndex = 4;
            lbList.Text = "Danh sách bài hát";
            // 
            // picArtist
            // 
            picArtist.Location = new Point(35, 50);
            picArtist.Name = "picArtist";
            picArtist.Size = new Size(150, 150);
            picArtist.SizeMode = PictureBoxSizeMode.Zoom;
            picArtist.TabIndex = 0;
            picArtist.TabStop = false;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnEdit);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnPlay);
            panelButtons.Controls.Add(btnClose);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 535);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(982, 60);
            panelButtons.TabIndex = 1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(377, 8);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 40);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Sửa thông tin";
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(507, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa nghệ sĩ";
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(723, 8);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(120, 40);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "Phát danh sách";
            btnPlay.Click += btnPlay_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(849, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 40);
            btnClose.TabIndex = 3;
            btnClose.Text = "Đóng";
            btnClose.Click += btnClose_Click;
            // 
            // listDetail
            // 
            listDetail.AllowColumnReorder = true;
            listDetail.Columns.AddRange(new ColumnHeader[] { None, title, album, releaseDate, duration });
            listDetail.FullRowSelect = true;
            listDetail.Location = new Point(13, 255);
            listDetail.Name = "listDetail";
            listDetail.Size = new Size(960, 274);
            listDetail.TabIndex = 3;
            listDetail.UseCompatibleStateImageBehavior = false;
            listDetail.View = View.Details;
            // 
            // None
            // 
            None.Text = "None";
            None.Width = 0;
            // 
            // title
            // 
            title.Text = "Tên bài hát";
            title.TextAlign = HorizontalAlignment.Center;
            title.Width = 435;
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
            // ArtistDetail
            // 
            ClientSize = new Size(982, 595);
            Controls.Add(listDetail);
            Controls.Add(panelButtons);
            Controls.Add(panelInfo);
            Name = "ArtistDetail";
            Text = "Chi tiết nghệ sĩ";
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picArtist).EndInit();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
        private ListView listDetail;
        private ColumnHeader None;
        private ColumnHeader album;
        private ColumnHeader releaseDate;
        private ColumnHeader duration;
        private Label label2;
        private Label lbList;
        private ColumnHeader title;
        private Label lblName;
        private Label lblBirth;
        private Label lblCountry;
    }
}
