using System.Windows.Forms;

namespace Music_Management.UI.Views
{
    partial class MusicPlayer
    {
        private System.ComponentModel.IContainer components = null;

        private PictureBox pbDisc;
        private Label lblTitle;
        private TrackBar timeline;
        private Label lblCurrentTime;
        private Label lblTotalTime;

        private PictureBox btnPlayPause;
        private PictureBox btnNext;
        private PictureBox btnPrevious;
        private PictureBox btnRepeat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pbDisc = new PictureBox();
            lblTitle = new Label();
            timeline = new TrackBar();
            lblCurrentTime = new Label();
            lblTotalTime = new Label();
            btnPlayPause = new PictureBox();
            btnNext = new PictureBox();
            btnPrevious = new PictureBox();
            btnRepeat = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbDisc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeline).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPlayPause).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPrevious).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRepeat).BeginInit();
            SuspendLayout();
            // 
            // pbDisc
            // 
            pbDisc.Location = new Point(125, 10);
            pbDisc.Name = "pbDisc";
            pbDisc.Size = new Size(250, 250);
            pbDisc.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDisc.TabIndex = 0;
            pbDisc.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial", 16F);
            lblTitle.Location = new Point(50, 270);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 30);
            lblTitle.TabIndex = 1;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timeline
            // 
            timeline.Location = new Point(30, 310);
            timeline.Maximum = 1000;
            timeline.Name = "timeline";
            timeline.Size = new Size(440, 56);
            timeline.TabIndex = 2;
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.Location = new Point(30, 370);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(80, 25);
            lblCurrentTime.TabIndex = 3;
            // 
            // lblTotalTime
            // 
            lblTotalTime.Location = new Point(390, 370);
            lblTotalTime.Name = "lblTotalTime";
            lblTotalTime.Size = new Size(80, 25);
            lblTotalTime.TabIndex = 4;
            lblTotalTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnPlayPause
            // 
            btnPlayPause.Location = new Point(180, 400);
            btnPlayPause.Name = "btnPlayPause";
            btnPlayPause.Size = new Size(30, 30);
            btnPlayPause.SizeMode = PictureBoxSizeMode.StretchImage;
            btnPlayPause.TabIndex = 6;
            btnPlayPause.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(266, 400);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(30, 30);
            btnNext.SizeMode = PictureBoxSizeMode.StretchImage;
            btnNext.TabIndex = 7;
            btnNext.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(100, 400);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(30, 30);
            btnPrevious.SizeMode = PictureBoxSizeMode.StretchImage;
            btnPrevious.TabIndex = 5;
            btnPrevious.TabStop = false;
            // 
            // btnRepeat
            // 
            btnRepeat.Location = new Point(340, 400);
            btnRepeat.Name = "btnRepeat";
            btnRepeat.Size = new Size(30, 30);
            btnRepeat.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRepeat.TabIndex = 8;
            btnRepeat.TabStop = false;
            // 
            // MusicPlayer
            // 
            ClientSize = new Size(500, 481);
            Controls.Add(pbDisc);
            Controls.Add(lblTitle);
            Controls.Add(timeline);
            Controls.Add(lblCurrentTime);
            Controls.Add(lblTotalTime);
            Controls.Add(btnPrevious);
            Controls.Add(btnPlayPause);
            Controls.Add(btnNext);
            Controls.Add(btnRepeat);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MusicPlayer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)pbDisc).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeline).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPlayPause).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPrevious).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRepeat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
