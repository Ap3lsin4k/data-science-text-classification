using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PupilIsNotStudent.utils;

namespace PupilIsNotStudent.model.repository
{
    // Wrapper for StreamWriter
    class LogRepository : IWriter
    {
        private StreamWriter _log;

        public LogRepository()
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
    }
}
