using System.IO;

namespace PupilIsNotStudent.utils
{
    // Wrapper for StreamWriter
    public class LoggerAspectSingletone : IWriter
    {
        private StreamWriter _log;

        public LoggerAspectSingletone()
        {
            Directory.CreateDirectory("log");
        }


        public void CreateNewFile(string name)
        {
            FileInfo f = new FileInfo("log/" + name + ".txt");
            _log = f.CreateText();
        }

        public void CloseFile()
        {
            _log.Close();
        }

        public void Write(string logMessage)
        {
            _log.WriteLine(logMessage);
        }

        public static LoggerAspectSingletone GetInstance()
        {
            throw new System.NotImplementedException();
        }
    }
}
