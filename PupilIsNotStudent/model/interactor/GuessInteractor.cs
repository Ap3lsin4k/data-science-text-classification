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
        private readonly ExtractKeyWordsRepository _extractKeyWords;
        private readonly PredictService _predict;
        
        public GuessInteractor(in PredictService predictService, in TextParsingRepository textRepository, in FileRepository fileRepository, in ExtractKeyWordsRepository textExtractKeyWordsRepository)
        {
            _predict = predictService;
            _text = textRepository;
            _file = fileRepository;
            _extractKeyWords = textExtractKeyWordsRepository;
        }

        //==========AKINATOR aka GUESSER==========
        public string ComputeDe(in string[] splitText)
        {
            return _predict.ComputeDe(splitText);
        }

        public utils.IndicatorsOfAffiliationForText ComputeAffiliationOfTextToCategory(in HashSet<string> newTextUnrepeatedWords, Dictionary<string, double> tfidf, string categoryName)
        {
            var indicatorsOfAffiliationForText = _predict.ComputeAffiliationOfTextToCategory(newTextUnrepeatedWords, tfidf, LoggerAspectSingleton.GetInstance("log", categoryName));
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
