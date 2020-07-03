using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PupilIsNotStudent.model.core;
using PupilIsNotStudent.model.repository;

namespace PupilIsNotStudent.model.interactor
{
    class GuessInteractor
    {
        private readonly TextParsingRepository _text;
        private readonly FileRepository _file;
        private readonly LogRepository _log;
        private readonly ExtractKeyWordsRepository _extractKeyWords;
        private readonly AkinatorRepository _akinator;

        public GuessInteractor(in AkinatorRepository akinatorRepository, in TextParsingRepository textRepository, in FileRepository fileRepository, in LogRepository logRepository, in ExtractKeyWordsRepository textExtractKeyWordsRepository)
        {
            _akinator = akinatorRepository;
            _text = textRepository;
            _file = fileRepository;
            _log = logRepository;
            _extractKeyWords = textExtractKeyWordsRepository;
        }

        //==========AKINATOR aka GUESSER==========
        public string computeDe(in string[] splitText)
        {
            return _akinator.computeDe(splitText);
        }

        public utils.IndicatorsOfAffiliationForText computeAffiliationOfTextToCategory(Dictionary<string, int>.KeyCollection unrepeatedWords, Dictionary<string, double> tfIdf)
        {
            return _akinator.computeAffiliationOfTextToCategory(unrepeatedWords, tfIdf);
        }

        //==========TEXT REPOSITORY==========

        public string[] getSplitWords(string rawText)
        {
            return _text.getSplitWords(rawText);
        }


        public Dictionary<string, int> associateOccurrencesWithTerms(ref string[] words)
        {
            return _text.associateOccurrencesWithTerms(ref words);
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

        public Dictionary<string, Book> getLibrary()
        {
            return _extractKeyWords.library;
        }

        public bool deserializeFromFile()
        {
            return _extractKeyWords.deserializeFromFile();
        }

        public Dictionary<string, Book>.KeyCollection getCategories()
        {
            return _extractKeyWords.getCategories();
        }

        public void relearn(string shelfToBeModernized, in string[] shuffledWords)
        {
            _extractKeyWords.relearn(shelfToBeModernized, in shuffledWords);
        }
    }
}
