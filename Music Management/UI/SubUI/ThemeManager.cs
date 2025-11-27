using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace YourApp.Theme
{
    public static class ThemeManager
    {
        private static readonly string ThemeFile = "theme.config";

        public static bool IsDark { get; private set; } = false;

        public static event Action ThemeChanged;

        public static void LoadTheme()
        {
            if (File.Exists(ThemeFile))
            {
                string content = File.ReadAllText(ThemeFile).Trim();
                IsDark = (content == "dark");
            }
        }

        private static void SaveTheme()
        {
            File.WriteAllText(ThemeFile, IsDark ? "dark" : "light");
        }

        public static void ToggleTheme()
        {
            IsDark = !IsDark;
            SaveTheme();

            ApplyThemeToAllOpenForms();

            ThemeChanged?.Invoke(); 
        }

        public static void ApplyThemeToAllOpenForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                ApplyTheme(form);
            }
        }

        public static void ApplyTheme(Control control)
        {
            if (IsDark)
            {
                control.BackColor = Color.FromArgb(32, 32, 32);
                control.ForeColor = Color.White;
            }
            else
            {
                control.BackColor = Color.White;
                control.ForeColor = Color.Black;
            }

            foreach (Control c in control.Controls)
                ApplyTheme(c);
        }
    }
}
