using System.IO;

namespace PupilIsNotStudent.utils
{
    // Wrapper for StreamWriter
    public class LoggerAspectSingleton : IWriter
    {
        private StreamWriter _log;
        private static LoggerAspectSingleton _uniqueInstance;
        private static string _workingDir;
        private static string _currentFile;

        private LoggerAspectSingleton()
        {
        }
        
        public static LoggerAspectSingleton GetInstance(string workingDir, string currentFile)
        {
            if (_uniqueInstance == null) 
                _uniqueInstance = new LoggerAspectSingleton();

            SetWorkingDirAndCleanAllFiles(workingDir);
            LoggerAspectSingleton._currentFile = currentFile;

            return _uniqueInstance;
        }

        private static void SetWorkingDirAndCleanAllFiles(string workingDir)
        {
            LoggerAspectSingleton._workingDir = workingDir;
            if (Directory.Exists(workingDir))
            {
                string[] files = Directory.GetFiles(workingDir);
                foreach (string file in files)
                {
                    File.Delete(file);
                }
            }
            else
            {
                Directory.CreateDirectory(LoggerAspectSingleton._workingDir);
            }
            
        }

        public void WriteAndClose(string fileNameWithoutExtension, string logMessage)
        {
//           if (!Directory.Exists(_workingDir)) 
            Directory.CreateDirectory(_workingDir);

            FileInfo f = new FileInfo(_workingDir +"/"+ fileNameWithoutExtension + ".txt");
            _log = f.AppendText();
            _log.WriteLine(logMessage);
            _log.Close();
        }

        public void Write(string logMessage)
        {
            WriteAndClose(LoggerAspectSingleton._currentFile, logMessage);
        }
    }
}
