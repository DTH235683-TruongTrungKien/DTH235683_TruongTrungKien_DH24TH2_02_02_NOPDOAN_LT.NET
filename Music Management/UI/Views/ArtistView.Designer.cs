namespace Music_Management.UI.Views
{
    partial class ArtistView
    {
        private System.ComponentModel.IContainer components = null;
        private FlowLayoutPanel flowArtists;
        private Panel panelMain;
        private Panel panelButtons;
        private Button btnAdd;
        private Button btnSave;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelMain = new Panel();
            flowArtists = new FlowLayoutPanel();
            panelButtons = new Panel();
            btnAdd = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(flowArtists);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1300, 624);
            panelMain.TabIndex = 0;
            // 
            // flowArtists
            // 
            flowArtists.AutoScroll = true;
            flowArtists.BackColor = Color.Transparent;
            flowArtists.Dock = DockStyle.Fill;
            flowArtists.Location = new Point(20, 20);
            flowArtists.Name = "flowArtists";
            flowArtists.Padding = new Padding(10);
            flowArtists.Size = new Size(1260, 584);
            flowArtists.TabIndex = 0;
            flowArtists.Paint += flowArtists_Paint;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Controls.Add(btnSave);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 624);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(1300, 76);
            panelButtons.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Quicksand", 10F);
            btnAdd.Location = new Point(397, 13);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm nghệ sĩ";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Quicksand", 10F);
            btnSave.Location = new Point(573, 13);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 50);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu thay đổi";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Quicksand", 10F);
            btnCancel.Location = new Point(747, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 50);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Hủy thay đổi";
            btnCancel.Click += btnCancel_Click;
            // 
            // ArtistView
            // 
            Controls.Add(panelMain);
            Controls.Add(panelButtons);
            Name = "ArtistView";
            Size = new Size(1300, 700);
            panelMain.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
