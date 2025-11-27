using Music_Management.UI.Views;

namespace Music_Management.UI
{
    public partial class MainForm : Form
    {
        private readonly string _permission;
        public MainForm(string permission)
        {
            _permission = permission;
            InitializeComponent();
            LoadTabsUserControls();
        }

        private void LoadTabsUserControls()
        {

            var musicControl = new MusicView(_permission);
            musicControl.Dock = DockStyle.Fill; 
            tabMusic.Controls.Add(musicControl);

            var artistControl = new ArtistView(_permission);
            artistControl.Dock = DockStyle.Fill;
            tabArtist.Controls.Add(artistControl);

            var playlistControl = new PlaylistView();
            playlistControl.Dock = DockStyle.Fill;
            tabPlaylist.Controls.Add(playlistControl);

            var settingsControl = new SettingsView();
            settingsControl.Dock = DockStyle.Fill;
            tabSettings.Controls.Add(settingsControl);
        }
    }
}
