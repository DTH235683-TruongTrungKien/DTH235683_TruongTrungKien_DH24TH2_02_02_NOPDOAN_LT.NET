using System;
using System.Windows.Forms;

namespace Music_Management.UI.Popup
{
    partial class PlaylistPopup
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblPlaylistName;
        private TextBox txtTitle;
        private Label lblDescription;
        private TextBox txtDescription;
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
            lblPlaylistName = new Label();
            txtTitle = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
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
            lblTitle.Text = "Thêm danh sách phát";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlaylistName
            // 
            lblPlaylistName.Location = new Point(20, 50);
            lblPlaylistName.Name = "lblPlaylistName";
            lblPlaylistName.Size = new Size(120, 23);
            lblPlaylistName.TabIndex = 1;
            lblPlaylistName.Text = "Tên danh sách:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(150, 50);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 27);
            txtTitle.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(20, 90);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(120, 23);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Mô tả:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(150, 90);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 27);
            txtDescription.TabIndex = 4;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(80, 139);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 35);
            btnOk.TabIndex = 7;
            btnOk.Text = "OK";
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(200, 139);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // PlaylistPopup
            // 
            ClientSize = new Size(400, 191);
            Controls.Add(lblTitle);
            Controls.Add(lblPlaylistName);
            Controls.Add(txtTitle);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PlaylistPopup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm danh sách phát";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
