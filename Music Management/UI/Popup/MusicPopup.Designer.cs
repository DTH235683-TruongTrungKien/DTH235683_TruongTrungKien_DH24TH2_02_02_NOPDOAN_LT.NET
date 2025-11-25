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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSongName = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.cmbArtist = new System.Windows.Forms.ComboBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.lblRelease = new System.Windows.Forms.Label();
            this.txtRelease = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Size = new System.Drawing.Size(360, 30);
            this.lblTitle.Text = "Thêm bài hát";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSongName
            // 
            this.lblSongName.Location = new System.Drawing.Point(20, 50);
            this.lblSongName.Size = new System.Drawing.Size(100, 23);
            this.lblSongName.Text = "Tên bài hát:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(130, 50);
            this.txtTitle.Size = new System.Drawing.Size(200, 23);
            // 
            // lblArtist
            // 
            this.lblArtist.Location = new System.Drawing.Point(20, 85);
            this.lblArtist.Size = new System.Drawing.Size(100, 23);
            this.lblArtist.Text = "Nghệ sĩ:";
            // 
            // cmbArtist
            // 
            this.cmbArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArtist.Location = new System.Drawing.Point(130, 85);
            this.cmbArtist.Size = new System.Drawing.Size(200, 23);
            // 
            // lblAlbum
            // 
            this.lblAlbum.Location = new System.Drawing.Point(20, 120);
            this.lblAlbum.Size = new System.Drawing.Size(100, 23);
            this.lblAlbum.Text = "Album:";
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(130, 120);
            this.txtAlbum.Size = new System.Drawing.Size(200, 23);
            // 
            // lblRelease
            // 
            this.lblRelease.Location = new System.Drawing.Point(20, 155);
            this.lblRelease.Size = new System.Drawing.Size(100, 23);
            this.lblRelease.Text = "Ngày phát hành:";
            // 
            // txtRelease
            // 
            this.txtRelease.Location = new System.Drawing.Point(130, 155);
            this.txtRelease.Size = new System.Drawing.Size(200, 23);
            // 
            // lblDuration
            // 
            this.lblDuration.Location = new System.Drawing.Point(20, 190);
            this.lblDuration.Size = new System.Drawing.Size(100, 23);
            this.lblDuration.Text = "Thời lượng:";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(130, 190);
            this.txtDuration.Size = new System.Drawing.Size(200, 23);
            this.txtDuration.ReadOnly = true;
            // 
            // lblFile
            // 
            this.lblFile.Location = new System.Drawing.Point(20, 225);
            this.lblFile.Size = new System.Drawing.Size(100, 23);
            this.lblFile.Text = "File nhạc:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(130, 225);
            this.txtFilePath.Size = new System.Drawing.Size(200, 23);
            this.txtFilePath.ReadOnly = true;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(130, 255);
            this.btnChooseFile.Size = new System.Drawing.Size(100, 30);
            this.btnChooseFile.Text = "Chọn file";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(80, 300);
            this.btnOk.Size = new System.Drawing.Size(100, 35);
            this.btnOk.Text = "OK";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 300);
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Text = "Cancel";
            // 
            // MusicPopupForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 360);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.cmbArtist);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.lblRelease);
            this.Controls.Add(this.txtRelease);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Thêm bài hát";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
