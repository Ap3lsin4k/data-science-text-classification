using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_analyzer
{
    static class Program
    {
        static bool runAutomatedTesting = true;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (runAutomatedTesting) 
                Application.Run(new UnitTestFormGuess());

            Application.Run(new MainWindow());
        }
    }
}
