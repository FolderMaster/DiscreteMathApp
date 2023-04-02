using System;
using System.Windows.Forms;

using GraphsApp.Views.Forms;

namespace GraphsApp
{
    /// <summary>
    /// Класс приложения с методом запуска.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Запускает приложение.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}