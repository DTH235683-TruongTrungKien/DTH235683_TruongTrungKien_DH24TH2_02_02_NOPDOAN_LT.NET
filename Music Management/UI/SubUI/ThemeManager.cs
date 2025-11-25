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

        // Load theme trạng thái cũ khi app khởi động
        public static void LoadTheme()
        {
            if (File.Exists(ThemeFile))
            {
                string content = File.ReadAllText(ThemeFile).Trim();
                IsDark = (content == "dark");
            }
        }

        // Lưu theme khi người dùng đổi
        private static void SaveTheme()
        {
            File.WriteAllText(ThemeFile, IsDark ? "dark" : "light");
        }

        public static void ToggleTheme()
        {
            IsDark = !IsDark;
            SaveTheme();

            ApplyThemeToAllOpenForms();

            ThemeChanged?.Invoke(); // fallback cho các control
        }

        // Áp dụng theme lên TẤT CẢ form trong ứng dụng
        public static void ApplyThemeToAllOpenForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                ApplyTheme(form);
            }
        }

        // Hàm apply theme cho 1 control và các control con
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
