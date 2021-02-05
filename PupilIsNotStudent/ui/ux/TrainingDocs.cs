using System;
using System.IO;
using System.Windows.Forms;

namespace PupilIsNotStudent
{
    public static class TrainingDocs
    {
        public static void AsUserOpenFolderWithTrainingFiles(Action<string[]> UseFiles)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    UseFiles(files);
                }
            }
        }
        
        public static string GetCategoryNameFromPath(string path)
        {
            return path.Substring(path.LastIndexOf('\\')+1, path.IndexOf('.')-path.LastIndexOf('\\')-1);
        }
    }
}