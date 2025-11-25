using Music_Management.UI.Views;

namespace Music_Management.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadTabsUserControls();
        }

        private void LoadTabsUserControls()
        {

            var musicControl = new MusicView();
            musicControl.Dock = DockStyle.Fill; 
            tabMusic.Controls.Add(musicControl);

            var artistControl = new ArtistView();
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
