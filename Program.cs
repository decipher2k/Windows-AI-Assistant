using System.Diagnostics;

namespace Windows_AI_Assistant
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            if (Process.GetProcessesByName("Windows AI Assistant").Count() > 1)
            {
                MessageBox.Show("Windows AI Assistant is allready running.");
            }
            else
            {
                ApplicationConfiguration.Initialize();
                Globals.Load();
                Application.Run(new AppContext());
            }
		}
    }
}