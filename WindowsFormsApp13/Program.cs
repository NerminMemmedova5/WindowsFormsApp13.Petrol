using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp13.Presenter;
using WindowsFormsApp13.View;

namespace WindowsFormsApp13
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
            var view = new HomeWindow();
            var presenter = new HomePresenter(view);
            Application.Run(view);
        }
    }
}
