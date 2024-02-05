using System;
using System.Windows.Forms;

namespace QConverter {
    static class Program {

        [STAThread]
        static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Load file options dialog if a file is dragged (not implemented yet)
            /*if (args.Length > 0)
                Application.Run(new FileActionForm(args[0]));
            else */
            Application.Run(new MainForm());
        }
    }
}
