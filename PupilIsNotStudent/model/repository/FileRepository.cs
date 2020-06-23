using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PupilIsNotStudent.model.repository
{
    // wrapper for OpenFileDialog
    class FileRepository
    {
        OpenFileDialog fileDialog;
        public FileRepository()
        {

            fileDialog = new OpenFileDialog();
        }

        public bool openFileDialog()
        {
            // opens the dialog in last folder it remembers

            fileDialog.Filter = "txt files (*.txt)|*.txt|Allfiles (*.*)|*.*";
            fileDialog.FilterIndex = 1;

            // It freezes the program while showing the dialog
            return fileDialog.ShowDialog() == DialogResult.OK;
        }

        public string readAllText()
        {
            return File.ReadAllText(fileDialog.FileName, GetEncoding(fileDialog.FileName)); // Windows-1251
        }


        /// <summary>
        /// Determines a text file's encoding by analyzing its byte order mark (BOM).
        /// Defaults to ASCII when detection of the text file's endings fails.
        /// </summary>
        /// <param name="filename">The text file to analyze.</param>
        /// <returns>The detected encoding.</returns>
        /// Note: it doesn't always works
        private static Encoding GetEncoding(string filename)
        {
            // Read the BOM
            var bom = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            return Encoding.Default;  // ANSI
        }

    }
}
