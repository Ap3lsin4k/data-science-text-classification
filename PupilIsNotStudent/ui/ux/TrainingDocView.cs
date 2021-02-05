using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PupilIsNotStudent
{
    public static class TrainingDocView
    {
        public static void ProcessBrowserDir(Action<string[], string[]> UseFiles)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                      //  AppendTrainingDoc(TrainingDocManager.GetCategoryNameFromPath(path), 
                       //     (path));
                    
                   List<string> categoryNames = new List<string>();
                   List<string> texts = new List<string>();
                
                   foreach (var path in files)
                   {
                       categoryNames.Add(GetCategoryNameFromPath(path));
                       texts.Add(File.ReadAllText(path));
                   }
                    UseFiles(categoryNames, texts);
                }
            }
        }

        class TrainingFileInfo
        {
            private TrainingFileInfo()
            {
            }

            public string CategoryName { get; private set; }
            public string Text { get; private set; }
// TODO replace string Text to string[] Words
            public static TrainingFileInfo Load(string path)
            {
                return new TrainingFileInfo();
            }
            
            
        }
        public static string[] ReadWords(string filepath)
        {
            var text = File.ReadAllText(filepath);
            text = text.Replace(Environment.NewLine, "");
            return text.Split('.');
        }

        public static string GetCategoryNameFromPath(string path)
        {
            return path.Substring(path.LastIndexOf('\\')+1, path.IndexOf('.')-path.LastIndexOf('\\')-1);
        }
    }
}