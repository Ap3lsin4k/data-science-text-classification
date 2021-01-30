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

        public string ReadTexTermFrequencyromFile()
        {
            return _file.ReadAllText();
        }



        //==========Extract Key Words Repository==========
        public void AddCategory(string shelf, string[] texts)
        {
            _extractKeyWords.AddCategory(shelf, in texts);
        }


        public void ComputeTermFrequencyAltogether(string shelf)
        {
            _extractKeyWords.ComputeTermFrequencyAltogether(shelf);
        }


        public Dictionary<string, Book>.KeyCollection GetCategories()
        {
            return _extractKeyWords.GetCategories();
        }

        public bool WhetherCategoryExist(string shelf)
        {
            return _extractKeyWords.WhetherCategoryExist(shelf);
        }

        public void IDFForEachBook()
        {
            _extractKeyWords.IDFForEachBook();
        }

        public byte GetNumberOfShelvesInLibrary()
        {
            return _extractKeyWords.GetNumberOfShelvesInLibrary();
        }
        public void CalculateTermFrequencyInverseDocumentFrequency(string shelf)
        {
            _extractKeyWords.CalculateTermFrequencyInverseDocumentFrequency(shelf);
        }
        public IOrderedEnumerable<KeyValuePair<string, double>> GetTermFrequencyInverseDocumentFrequencyOrderByDescending(string shelf)
        {
            return _extractKeyWords.GetTermFrequencyInverseDocumentFrequencyOrderByDescending(shelf);
        }
        public bool TermFrequencyExist(string shelf)
        {
            return _extractKeyWords.TermFrequencyExist(shelf);
        }
        public bool InverseDocumentFrequencyExist(string shelf)
        {
            return _extractKeyWords.InverseDocumentFrequencyExist(shelf);
        }

        public void SaveToJsonFile()
        {
            _extractKeyWords.Save();
        }

    }
}
