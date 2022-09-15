using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms {
    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main () {
            Form1 form1 = new Form1 ();
            form1.FormLayout ();
            Application.Run (form1);
        }

        static void MainJunk () {
            Application.SetHighDpiMode (HighDpiMode.SystemAware);
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);
            Application.Run (new Form1 ());
        }
    }
}