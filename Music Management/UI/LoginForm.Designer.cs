namespace Music_Management.UI;

partial class LoginForm
{
    private System.ComponentModel.IContainer components = null;

    private PictureBox pictureBackground;
    private Panel panelLogin;
    private Label lblTitle;
    private Label lblUser;
    private Label lblPass;
    private TextBox txtUser;
    private TextBox txtPass;
    private Button btnLogin;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pictureBackground = new PictureBox();
        panelLogin = new Panel();
        lblTitle = new Label();
        lblUser = new Label();
        txtUser = new TextBox();
        lblPass = new Label();
        txtPass = new TextBox();
        btnLogin = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBackground).BeginInit();
        panelLogin.SuspendLayout();
        SuspendLayout();
        // 
        // pictureBackground
        // 
        pictureBackground.Dock = DockStyle.Fill;
        pictureBackground.Image = Properties.Resources.premium_photo_1661843598966_c7a65f138555;
        pictureBackground.Location = new Point(0, 0);
        pictureBackground.Name = "pictureBackground";
        pictureBackground.Size = new Size(1282, 753);
        pictureBackground.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBackground.TabIndex = 1;
        pictureBackground.TabStop = false;
        // 
        // panelLogin
        // 
        panelLogin.Anchor = AnchorStyles.None;
        panelLogin.BackColor = Color.FromArgb(40, 40, 40);
        panelLogin.Controls.Add(lblTitle);
        panelLogin.Controls.Add(lblUser);
        panelLogin.Controls.Add(txtUser);
        panelLogin.Controls.Add(lblPass);
        panelLogin.Controls.Add(txtPass);
        panelLogin.Controls.Add(btnLogin);
        panelLogin.Location = new Point(472, 251);
        panelLogin.Name = "panelLogin";
        panelLogin.Size = new Size(350, 237);
        panelLogin.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Quicksand Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(94, 21);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(168, 41);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Đăng nhập";
        // 
        // lblUser
        // 
        lblUser.AutoSize = true;
        lblUser.Font = new Font("Quicksand", 9F);
        lblUser.ForeColor = Color.White;
        lblUser.Location = new Point(23, 76);
        lblUser.Name = "lblUser";
        lblUser.Size = new Size(81, 23);
        lblUser.TabIndex = 1;
        lblUser.Text = "Tài khoản:";
        // 
        // txtUser
        // 
        txtUser.Location = new Point(110, 75);
        txtUser.Name = "txtUser";
        txtUser.Size = new Size(200, 27);
        txtUser.TabIndex = 2;
        // 
        // lblPass
        // 
        lblPass.AutoSize = true;
        lblPass.Font = new Font("Quicksand", 9F);
        lblPass.ForeColor = Color.White;
        lblPass.Location = new Point(23, 126);
        lblPass.Name = "lblPass";
        lblPass.Size = new Size(78, 23);
        lblPass.TabIndex = 3;
        lblPass.Text = "Mật khẩu:";
        // 
        // txtPass
        // 
        txtPass.Location = new Point(110, 125);
        txtPass.Name = "txtPass";
        txtPass.PasswordChar = '*';
        txtPass.Size = new Size(200, 27);
        txtPass.TabIndex = 4;
        // 
        // btnLogin
        // 
        btnLogin.Font = new Font("Quicksand", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnLogin.ForeColor = SystemColors.ButtonHighlight;
        btnLogin.Location = new Point(125, 176);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(120, 35);
        btnLogin.TabIndex = 5;
        btnLogin.Text = "Đăng nhập";
        btnLogin.Click += btnLogin_Click;
        // 
        // LoginForm
        // 
        ClientSize = new Size(1282, 753);
        Controls.Add(panelLogin);
        Controls.Add(pictureBackground);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        ((System.ComponentModel.ISupportInitialize)pictureBackground).EndInit();
        panelLogin.ResumeLayout(false);
        panelLogin.PerformLayout();
        ResumeLayout(false);
    }
}
