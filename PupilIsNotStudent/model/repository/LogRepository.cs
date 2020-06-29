using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PupilIsNotStudent.model.repository
{
    // Wrapper for StreamWriter
    class LogRepository
    {
        private StreamWriter log;

        public LogRepository()
        {
            Directory.CreateDirectory("log");
        }


        public void createNewFile(string name)
        {
            FileInfo f = new FileInfo("log/" + name + ".txt");
            log = f.CreateText();
        }

        public void write(string logMessage)
        {
            log.WriteLine(logMessage);
        }

        public void closeFile()
        {
            log.Close();
        }
    }
}
