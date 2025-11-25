using System;
using System.Drawing;
using System.Windows.Forms;
using Music_Management.UI.SubUI;
using YourApp.Theme;

namespace Music_Management.UI.Views
{
    public partial class SettingsView : UserControl
    {
        private Image imgOn;
        private Image imgOff;

        public SettingsView()
        {
            InitializeComponent();
            LoadImages();
            HookEvents();

            ThemeManager.ThemeChanged += RefreshTheme;
            RefreshTheme();
        }

        private void LoadImages()
        {
            imgOn = Image.FromFile("Assets/Icons/on-button.png");
            imgOff = Image.FromFile("Assets/Icons/off-button.png");

            switchButton.Image = ThemeManager.IsDark ? imgOn : imgOff;
        }

        private void HookEvents()
        {
            switchButton.Click += (s, e) => ToggleTheme();
            btnExit.Click += (s, e) => Application.Exit(); // vì là UserControl
        }

        private void ToggleTheme()
        {
            ThemeManager.ToggleTheme();
            switchButton.Image = ThemeManager.IsDark ? imgOn : imgOff;
        }

        private void RefreshTheme()
        {
            ThemeManager.ApplyTheme(this);
        }
    }
}
