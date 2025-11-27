namespace Music_Management.Helpers
{
    public static class Utils
    {
        public static void ShowWarning(string message)
        {
            MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowInfo(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool Confirm(string message)
        {
            return MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static string SecondsToDuration(int seconds)
        {
            int minutes = seconds / 60;
            int sec = seconds % 60;
            return $"{minutes:D2}:{sec:D2}";
        }

        public static void ClearControls(Control container)
        {
            foreach (Control ctrl in container.Controls)
            {
                ctrl.Dispose();
            }
            container.Controls.Clear();
        }

        public static string FileConvert(string filePath)
        {
            return Path.GetFileNameWithoutExtension(filePath);
        }

        public static bool UniqueCheck<T>(List<T> list, object val, Func<T, object> selector, int? ignoreIndex = null)
        {
            return !list.Where((item, index) => !ignoreIndex.HasValue || index != ignoreIndex)
                        .Any(item => selector(item).Equals(val));
        }

        public static void DeleteFromListByIds<T>(List<T> list, Func<T, int> idSelector, List<int> idList)
        {
            list.RemoveAll(item => idList.Contains(idSelector(item)));
        }

        public static void DeleteFromListById<T>(List<T> list, Func<T, int> idSelector, int id)
        {
            list.RemoveAll(item => idSelector(item) == id);
        }

        public static void ConvertValues<T>(T obj)
        {
            if (obj == null) return;
            foreach (var prop in typeof(T).GetProperties())
            {
                if (prop.PropertyType != typeof(string))
                    continue;
                var value = prop.GetValue(obj) as string;
                if (string.IsNullOrWhiteSpace(value))
                {
                    prop.SetValue(obj, "(Không có)");
                }
                else
                {
                    prop.SetValue(obj, value.Trim());
                }
            }
        }

    }
}
