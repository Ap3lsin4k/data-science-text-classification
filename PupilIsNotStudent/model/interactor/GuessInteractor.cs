using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PupilIsNotStudent.model.core;
using PupilIsNotStudent.model.repository;
using PupilIsNotStudent.utils;

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
        public string ComputeDe(in string[] splitText)
        {
            return _akinator.ComputeDe(splitText);
        }

        public utils.IndicatorsOfAffiliationForText ComputeAffiliationOfTextToCategory(in HashSet<string> newTextUnrepeatedWords, Dictionary<string, double> tfidf, string categoryName)
        {
            _log.CreateNewFile(categoryName);
            var indicatorsOfAffiliationForText =
                _akinator.ComputeAffiliationOfTextToCategory(newTextUnrepeatedWords, tfidf, _log);
            _log.CloseFile();
            return indicatorsOfAffiliationForText;
        }

        //==========TEXT REPOSITORY==========

        public string[] GetSplitWords(string rawText)
        {
            return _text.GetSplitWords(rawText);
        }




       


        //==========FILE REPOSITORY==========

        public bool OpenFileDialog()
        {
            //return true if Dialog Result is "OK"
            return _file.OpenFileDialog();
        }

        public string ReadTextFromFile()
        {
            return _file.ReadAllText();
        }


        //==========LOG REPOSITORY==========

        public void OpenNewLogFile(string name)
        {
            _log.CreateNewFile(name);
        }

        public void WriteLog(string logMessage)
        {
            _log.Write(logMessage);
        }

        public void CloseLogFile()
        {
            _log.CloseFile();
        }


        //==========EXTRACT KEY WORDS REPOSITORY==========


        public Dictionary<string, Book> GetLibrary()
        {
            return _extractKeyWords.Library;
        }

        public bool DeserializeFromFile()
        {
            return _extractKeyWords.DeserializeFromFile();
        }

        public Dictionary<string, Book>.KeyCollection GetCategories()
        {
            return _extractKeyWords.GetCategories();
        }

        public void Relearn(string shelfToBeModernized, in string[] shuffledWords)
        {
            _extractKeyWords.Relearn(shelfToBeModernized, in shuffledWords);
        }
    }
}
