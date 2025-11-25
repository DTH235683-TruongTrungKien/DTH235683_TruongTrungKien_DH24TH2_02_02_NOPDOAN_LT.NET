namespace Music_Management.UI.SubUI
{
    partial class ArtistCard
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox picArtist;
        private Label lblName;

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
            picArtist = new PictureBox();
            lblName = new Label();
            btnDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)picArtist).BeginInit();
            SuspendLayout();
            // 
            // picArtist
            // 
            picArtist.Location = new Point(25, 17);
            picArtist.Name = "picArtist";
            picArtist.Size = new Size(160, 160);
            picArtist.SizeMode = PictureBoxSizeMode.Zoom;
            picArtist.TabIndex = 0;
            picArtist.TabStop = false;
            // 
            // lblName
            // 
            lblName.Font = new Font("Quicksand", 10F, FontStyle.Bold);
            lblName.Location = new Point(25, 194);
            lblName.Name = "lblName";
            lblName.Size = new Size(160, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Artist Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDetail
            // 
            btnDetail.Font = new Font("Quicksand", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDetail.Location = new Point(25, 222);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(160, 44);
            btnDetail.TabIndex = 2;
            btnDetail.Text = "Xem chi tiết";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // ArtistCard
            // 
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnDetail);
            Controls.Add(picArtist);
            Controls.Add(lblName);
            Cursor = Cursors.Hand;
            Margin = new Padding(10);
            Name = "ArtistCard";
            Size = new Size(211, 277);
            ((System.ComponentModel.ISupportInitialize)picArtist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDetail;
    }
}
