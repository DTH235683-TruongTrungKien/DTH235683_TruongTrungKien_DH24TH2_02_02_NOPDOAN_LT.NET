namespace Music_Management.UI.Popup
{
    partial class MusicPopup
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.ComboBox cmbArtist;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.TextBox txtRelease;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSongName = new Label();
            txtTitle = new TextBox();
            lblArtist = new Label();
            cmbArtist = new ComboBox();
            lblAlbum = new Label();
            txtAlbum = new TextBox();
            lblRelease = new Label();
            txtRelease = new TextBox();
            lblDuration = new Label();
            txtDuration = new TextBox();
            lblFile = new Label();
            txtFilePath = new TextBox();
            btnChooseFile = new Button();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thêm bài hát";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSongName
            // 
            lblSongName.Location = new Point(20, 50);
            lblSongName.Name = "lblSongName";
            lblSongName.Size = new Size(100, 23);
            lblSongName.TabIndex = 1;
            lblSongName.Text = "Tên bài hát:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(130, 50);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 27);
            txtTitle.TabIndex = 2;
            // 
            // lblArtist
            // 
            lblArtist.Location = new Point(20, 85);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(100, 23);
            lblArtist.TabIndex = 3;
            lblArtist.Text = "Nghệ sĩ:";
            // 
            // cmbArtist
            // 
            cmbArtist.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArtist.Location = new Point(130, 85);
            cmbArtist.Name = "cmbArtist";
            cmbArtist.Size = new Size(200, 28);
            cmbArtist.TabIndex = 4;
            // 
            // lblAlbum
            // 
            lblAlbum.Location = new Point(20, 120);
            lblAlbum.Name = "lblAlbum";
            lblAlbum.Size = new Size(100, 23);
            lblAlbum.TabIndex = 5;
            lblAlbum.Text = "Album:";
            // 
            // txtAlbum
            // 
            txtAlbum.Location = new Point(130, 120);
            txtAlbum.Name = "txtAlbum";
            txtAlbum.Size = new Size(200, 27);
            txtAlbum.TabIndex = 6;
            // 
            // lblRelease
            // 
            lblRelease.Location = new Point(20, 155);
            lblRelease.Name = "lblRelease";
            lblRelease.Size = new Size(100, 23);
            lblRelease.TabIndex = 7;
            lblRelease.Text = "Ngày phát hành:";
            // 
            // txtRelease
            // 
            txtRelease.Location = new Point(130, 155);
            txtRelease.Name = "txtRelease";
            txtRelease.Size = new Size(200, 27);
            txtRelease.TabIndex = 8;
            // 
            // lblDuration
            // 
            lblDuration.Location = new Point(20, 190);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(100, 23);
            lblDuration.TabIndex = 9;
            lblDuration.Text = "Thời lượng:";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(130, 190);
            txtDuration.Name = "txtDuration";
            txtDuration.ReadOnly = true;
            txtDuration.Size = new Size(200, 27);
            txtDuration.TabIndex = 10;
            // 
            // lblFile
            // 
            lblFile.Location = new Point(20, 225);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(100, 23);
            lblFile.TabIndex = 11;
            lblFile.Text = "File nhạc:";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(130, 225);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(200, 27);
            txtFilePath.TabIndex = 12;
            // 
            // btnChooseFile
            // 
            btnChooseFile.Location = new Point(130, 255);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(100, 30);
            btnChooseFile.TabIndex = 13;
            btnChooseFile.Text = "Chọn file";
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(80, 300);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 35);
            btnOk.TabIndex = 14;
            btnOk.Text = "OK";
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(200, 300);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // MusicPopup
            // 
            ClientSize = new Size(400, 360);
            Controls.Add(lblTitle);
            Controls.Add(lblSongName);
            Controls.Add(txtTitle);
            Controls.Add(lblArtist);
            Controls.Add(cmbArtist);
            Controls.Add(lblAlbum);
            Controls.Add(txtAlbum);
            Controls.Add(lblRelease);
            Controls.Add(txtRelease);
            Controls.Add(lblDuration);
            Controls.Add(txtDuration);
            Controls.Add(lblFile);
            Controls.Add(txtFilePath);
            Controls.Add(btnChooseFile);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MusicPopup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm bài hát";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
