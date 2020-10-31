using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PupilIsNotStudent.model.core;
using PupilIsNotStudent.model.repository;

namespace PupilIsNotStudent.model.interactor
{
    // the purpose of an Interactor is to encapsulate Repositories for a Presenter
    class CategoriesInteractor
    {
        private readonly TextParsingRepository _text;
        private readonly FileRepository _file;
        private readonly ExtractKeyWordsRepository _extractKeyWords;

        public CategoriesInteractor(in TextParsingRepository textRepository, in FileRepository fileRepository, in ExtractKeyWordsRepository textExtractKeyWordsRepository)
        {
            _text = textRepository;
            _file = fileRepository;
            _extractKeyWords = textExtractKeyWordsRepository;
        }


        //==========TEXT REPOSITORY==========
        
        public string[] getSplitWords(string rawText)
        {
            return _text.getSplitWords(rawText);
        }


        //==========FILE REPOSITORY==========

        public bool openFileDialog()
        {
            //return true if Dialog Result is "OK"
            return _file.openFileDialog();
        }

        public string readTexTermFrequencyromFile()
        {
            return _file.readAllText();
        }



        //==========Extract Key Words Repository==========
        public void addCategory(string shelf, string[] texts)
        {
            _extractKeyWords.addCategory(shelf, in texts);
        }


        public void computeTermFrequencyAltogether(string shelf)
        {
            _extractKeyWords.computeTermFrequencyAltogether(shelf);
        }


        public Dictionary<string, Book>.KeyCollection getCategories()
        {
            return _extractKeyWords.getCategories();
        }

        public bool whetherCategoryExist(string shelf)
        {
            return _extractKeyWords.whetherCategoryExist(shelf);
        }

        public void IDFForEachBook()
        {
            _extractKeyWords.IDFForEachBook();
        }

        public byte getNumberOfShelvesInLibrary()
        {
            return _extractKeyWords.getNumberOfShelvesInLibrary();
        }
        public void calculateTermFrequencyInverseDocumentFrequency(string shelf)
        {
            _extractKeyWords.CalculateTermFrequencyInverseDocumentFrequency(shelf);
        }
        public IOrderedEnumerable<KeyValuePair<string, double>> getTermFrequencyInverseDocumentFrequencyOrderByDescending(string shelf)
        {
            return _extractKeyWords.getTermFrequencyInverseDocumentFrequencyOrderByDescending(shelf);
        }
        public bool TermFrequencyExist(string shelf)
        {
            return _extractKeyWords.TermFrequencyExist(shelf);
        }
        public bool InverseDocumentFrequencyExist(string shelf)
        {
            return _extractKeyWords.InverseDocumentFrequencyExist(shelf);
        }

        public void saveToJsonFile()
        {
            _extractKeyWords.save();
        }

    }
}
