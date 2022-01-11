using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OpenSplashScreen();
            Application.Run(new MainScreen());

        }

        public static async Task OpenSplashScreen()
        {
            splashScreen ss = new splashScreen();
            ss.Show();
            await closeSplashScreen(ss);

        }

        public static async Task closeSplashScreen(splashScreen ss)
        {
            await Task.Delay(1000);
            ss.Close();
            return;
        }
    }
}
