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
        private TextJsonRepository json;

        public GuessInteractor(TextRepository textRepository, FileRepository fileRepository, LogRepository logRepository, in TextJsonRepository textJsonRepository)
        {
            textRepo = textRepository;
            fileRepo = fileRepository;
            log = logRepository;
            json = textJsonRepository;
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

        public string computeDe(List<string> splitText)
        {
            return textRepo.computeDe(splitText);
        }

        public utils.IndicatorsOfAffiliationForText computeAffiliationOfTextToCategory(Dictionary<string, int>.KeyCollection unrepeatedWords, Dictionary<string, double> tfIdf)
        {
            return textRepo.computeAffiliationOfTextToCategory(unrepeatedWords, tfIdf);
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

        
        public Dictionary<string, WordFreq> getLibrary()
        {
            return json.library;
        }

        public bool deserializeFromFile()
        {
            return json.deserializeFromFile();
        }

        public string[] getCategories()
        {
            return json.getCategories();
        }
    }
}
