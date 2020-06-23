using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PupilIsNotStudent
{
    static class Program
    {
        static bool runAutomatedTesting = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

#if DEBUG
                if (runAutomatedTesting)
                    Application.Run(new UnitTestFormGuess());
                else
                    Application.Run(new MainWindow());
#else
            Application.Run(new MainWindow());
#endif


        }
    }
}
