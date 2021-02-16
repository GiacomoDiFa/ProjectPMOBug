using MenuInterattivo.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuInterattivo
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu(Database.GetInstance(CreateDefaultDBDir()),Menu.Instance()));
        }
        private static string CreateDefaultDBDir()
        {
            string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string dbFolderPath = userProfilePath + "\\MenuInterattivoDB";

            try
            {
                Directory.CreateDirectory(dbFolderPath);
            }
            catch (Exception e)
            {
                MessageBox.Show("FATAL ERROR \nImpossible create program's DataBase folder: " + dbFolderPath + "\n" + e, "Fatal Error", MessageBoxButtons.OK);
            }
            return dbFolderPath;
        }
    }
}