using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PupilIsNotStudent.model.repository;

namespace PupilIsNotStudent.model.interactor
{
    class GuessInteractor
    {
        private readonly TextRepository _text;
        private readonly FileRepository _file;
        private readonly LogRepository _log;
        private readonly TextJsonRepository _json;

        public GuessInteractor(in TextRepository textRepository, in FileRepository fileRepository, in LogRepository logRepository, in TextJsonRepository textJsonRepository)
        {
            _text = textRepository;
            _file = fileRepository;
            _log = logRepository;
            _json = textJsonRepository;
        }


        //==========TEXT REPOSITORY==========

        public List<string> getRawTextSplit(string notClearedText)
        {
            return _text.getRawTextSplit(notClearedText);
        }


        public string[] splitToWords(string rawText)
        {
            return _text.getSplitStrings(rawText);
        }

        public Dictionary<string, int> associateOccurrencesWithTerms(ref string[] words)
        {
            return _text.associateOccurrencesWithTerms(ref words);
        }

        public string computeDe(List<string> splitText)
        {
            return _text.computeDe(splitText);
        }

        public utils.IndicatorsOfAffiliationForText computeAffiliationOfTextToCategory(Dictionary<string, int>.KeyCollection unrepeatedWords, Dictionary<string, double> tfIdf)
        {
            return _text.computeAffiliationOfTextToCategory(unrepeatedWords, tfIdf);
        }


        //==========FILE REPOSITORY==========

        public bool openFileDialog()
        {
            //return true if Dialog Result is "OK"
            return _file.openFileDialog();
        }

        public string readTextFromFile()
        {
            return _file.readAllText();
        }


        //==========LOG REPOSITORY==========

        public void openNewLogFile(string name)
        {
            _log.createNewFile(name);
        }

        public void writeLog(string logMessage)
        {
            _log.write(logMessage);
        }

        public void closeLogFile()
        {
            _log.closeFile();
        }


        //==========JSON REPOSITORY==========

        public Dictionary<string, WordEntity> getLibrary()
        {
            return _json.library;
        }

        public bool deserializeFromFile()
        {
            return _json.deserializeFromFile();
        }

        public string[] getCategories()
        {
            return _json.getCategories();
        }
    }
}
