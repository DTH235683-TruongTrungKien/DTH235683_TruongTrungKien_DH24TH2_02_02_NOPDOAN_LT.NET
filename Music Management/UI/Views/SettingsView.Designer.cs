namespace Music_Management.UI.Views
{
    partial class SettingsView
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox switchButton;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            switchButton = new PictureBox();
            lblTheme = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)switchButton).BeginInit();
            SuspendLayout();
            // 
            // switchButton
            // 
            switchButton.Cursor = Cursors.Hand;
            switchButton.Location = new Point(682, 199);
            switchButton.Name = "switchButton";
            switchButton.Size = new Size(45, 45);
            switchButton.SizeMode = PictureBoxSizeMode.StretchImage;
            switchButton.TabIndex = 0;
            switchButton.TabStop = false;
            // 
            // lblTheme
            // 
            lblTheme.AutoSize = true;
            lblTheme.Font = new Font("Segoe UI", 12F);
            lblTheme.Location = new Point(552, 209);
            lblTheme.Name = "lblTheme";
            lblTheme.Size = new Size(125, 28);
            lblTheme.TabIndex = 1;
            lblTheme.Text = "Giao diện tối";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Quicksand", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(567, 275);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 40);
            btnExit.TabIndex = 2;
            btnExit.Text = "Thoát";
            // 
            // SettingsView
            // 
            Controls.Add(switchButton);
            Controls.Add(lblTheme);
            Controls.Add(btnExit);
            Name = "SettingsView";
            Size = new Size(1300, 800);
            ((System.ComponentModel.ISupportInitialize)switchButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
