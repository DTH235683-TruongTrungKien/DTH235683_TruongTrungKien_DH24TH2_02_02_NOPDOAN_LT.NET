namespace Music_Management.UI.Popup
{
    partial class ArtistPopup
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblName;
        private Label lblBirth;
        private Label lblCountry;
        private Label lblImage;

        private TextBox txtName;
        private TextBox txtBirth;
        private TextBox txtCountry;

        private Label lblImagePath;
        private Button btnChoose;
        private Button btnOK;
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
            lblName = new Label();
            lblBirth = new Label();
            lblCountry = new Label();
            lblImage = new Label();
            txtName = new TextBox();
            txtBirth = new TextBox();
            txtCountry = new TextBox();
            lblImagePath = new Label();
            btnChoose = new Button();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thêm nghệ sĩ mới";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Tên nghệ sĩ:";
            // 
            // lblBirth
            // 
            lblBirth.Location = new Point(20, 120);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(100, 23);
            lblBirth.TabIndex = 3;
            lblBirth.Text = "Ngày sinh:";
            // 
            // lblCountry
            // 
            lblCountry.Location = new Point(20, 160);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(100, 23);
            lblCountry.TabIndex = 5;
            lblCountry.Text = "Quốc gia:";
            // 
            // lblImage
            // 
            lblImage.Location = new Point(20, 200);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(100, 23);
            lblImage.TabIndex = 7;
            lblImage.Text = "File ảnh:";
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(230, 27);
            txtName.TabIndex = 2;
            // 
            // txtBirth
            // 
            txtBirth.Location = new Point(130, 115);
            txtBirth.Name = "txtBirth";
            txtBirth.Size = new Size(230, 27);
            txtBirth.TabIndex = 4;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(130, 155);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(230, 27);
            txtCountry.TabIndex = 6;
            // 
            // lblImagePath
            // 
            lblImagePath.ForeColor = Color.Gray;
            lblImagePath.Location = new Point(130, 230);
            lblImagePath.Name = "lblImagePath";
            lblImagePath.Size = new Size(230, 40);
            lblImagePath.TabIndex = 9;
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(130, 195);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(80, 32);
            btnChoose.TabIndex = 8;
            btnChoose.Text = "Chọn";
            btnChoose.Click += btnChoose_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(80, 273);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(100, 35);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(200, 273);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // ArtistPopup
            // 
            ClientSize = new Size(400, 340);
            Controls.Add(lblTitle);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblBirth);
            Controls.Add(txtBirth);
            Controls.Add(lblCountry);
            Controls.Add(txtCountry);
            Controls.Add(lblImage);
            Controls.Add(btnChoose);
            Controls.Add(lblImagePath);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ArtistPopup";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
