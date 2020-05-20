using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_analyzer.model.repository;

namespace Text_analyzer.model.interactor
{
    class GuessInteractor
    {
        private TextRepository textRepo;
        private FileRepository fileRepo;
        private LogRepository log;

        public GuessInteractor(TextRepository textRepository, FileRepository fileRepository, LogRepository logRepository)
        {
            textRepo = textRepository;
            fileRepo = fileRepository;
            log = logRepository;
        }

        public List<string> getRawTextSplit(string notClearedText)
        {
            return textRepo.getRawTextSplit(notClearedText);
        }


        public string[] splitToWords(string rawText)
        {
            return textRepo.getSplitStrings(rawText);
        }

        public Dictionary<string, int> associateOccurrencesWithTerms(ref string[] words)
        {
            return textRepo.associateOccurrencesWithTerms(ref words);
        }


        public bool openFileDialog()
        {
            //return true if Dialog Result is "OK"
            return fileRepo.openFileDialog();
        }

        public string readTextFromFile()
        {
            return fileRepo.readAllText();
        }

        public void openNewLogFile(string name)
        {
            log.createNewFile(name);
        }

        public void writeLog(string logMessage)
        {
            log.write(logMessage);
        }

        public void closeLogFile()
        {
            log.closeFile();
        }
    }
}
