namespace Music_Management.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMusic;
        private System.Windows.Forms.TabPage tabArtist;
        private System.Windows.Forms.TabPage tabPlaylist;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.ImageList imageListTabs;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            tabControl = new TabControl();
            tabMusic = new TabPage();
            tabArtist = new TabPage();
            tabPlaylist = new TabPage();
            tabSettings = new TabPage();
            imageListTabs = new ImageList(components);
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1300, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MUSIC MANAGEMENT APPLICATION";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabMusic);
            tabControl.Controls.Add(tabArtist);
            tabControl.Controls.Add(tabPlaylist);
            tabControl.Controls.Add(tabSettings);
            tabControl.Dock = DockStyle.Fill;
            tabControl.ImageList = imageListTabs;
            tabControl.Location = new Point(0, 60);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(20, 6);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1300, 640);
            tabControl.TabIndex = 0;
            // 
            // tabMusic
            // 
            tabMusic.ImageKey = "music";
            tabMusic.Location = new Point(4, 35);
            tabMusic.Name = "tabMusic";
            tabMusic.Padding = new Padding(3);
            tabMusic.Size = new Size(1292, 601);
            tabMusic.TabIndex = 0;
            tabMusic.Text = "  Danh sách nhạc";
            tabMusic.UseVisualStyleBackColor = true;
            // 
            // tabArtist
            // 
            tabArtist.ImageKey = "artist";
            tabArtist.Location = new Point(4, 35);
            tabArtist.Name = "tabArtist";
            tabArtist.Padding = new Padding(3);
            tabArtist.Size = new Size(1292, 601);
            tabArtist.TabIndex = 1;
            tabArtist.Text = "  Nghệ sĩ";
            tabArtist.UseVisualStyleBackColor = true;
            // 
            // tabPlaylist
            // 
            tabPlaylist.ImageKey = "playlist";
            tabPlaylist.Location = new Point(4, 35);
            tabPlaylist.Name = "tabPlaylist";
            tabPlaylist.Padding = new Padding(3);
            tabPlaylist.Size = new Size(1292, 601);
            tabPlaylist.TabIndex = 2;
            tabPlaylist.Text = "  Danh sách phát";
            tabPlaylist.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            tabSettings.ImageKey = "settings";
            tabSettings.Location = new Point(4, 35);
            tabSettings.Name = "tabSettings";
            tabSettings.Padding = new Padding(3);
            tabSettings.Size = new Size(1092, 501);
            tabSettings.TabIndex = 3;
            tabSettings.Text = "  Cài đặt";
            tabSettings.UseVisualStyleBackColor = true;
            // 
            // imageListTabs
            // 
            imageListTabs.ColorDepth = ColorDepth.Depth32Bit;
            imageListTabs.ImageSize = new Size(20, 20);
            imageListTabs.TransparentColor = Color.Transparent;
            // 
            // MainForm
            // 
            ClientSize = new Size(1300, 700);
            Controls.Add(tabControl);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Management";
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
