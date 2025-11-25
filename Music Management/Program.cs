using Music_Management.Data;
using Music_Management.UI;

namespace Music_Management
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DbGeneral.Initialize();
            Application.Run(new MainForm());
        }
    }
}