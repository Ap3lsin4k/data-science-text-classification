using System;
using System.Collections.Generic;
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

        public string readTextFromFile()
        {
            return _file.readAllText();
        }



        //==========JSON REPOSITORY==========
        public void addCategory(string shelf, string[] texts)
        {
            _extractKeyWords.addCategory(shelf, in texts);
        }


        public uint howManyTimesWordAppear(string shelf, string word)
        {
            return _extractKeyWords.howManyTimesWordAppear(shelf, word);
        }

        public Dictionary<string, uint>.KeyCollection getUniqueWords(string shelf)
        {
            return _extractKeyWords.getUniqueWords(shelf);
        }

        public IOrderedEnumerable<KeyValuePair<string, uint>> getUniqueWordsOrderByDescending(string shelf)
        {
            return _extractKeyWords.getUniqueWordsOrderByDescending(shelf);
        }


        public void updateTF(string shelf)
        {
            _extractKeyWords.updateTF(shelf);
        }


        public string[] getCategories()
        {
            return _extractKeyWords.getCategories();
        }

        public bool whetherCategoryExist(string shelf)
        {
            return _extractKeyWords.whetherCategoryExist(shelf);
        }
        
        public Dictionary<string, Book> getLibrary()
        {
            return _extractKeyWords.getLibrary();
        }

        public void IDFForEachBook()
        {
            _extractKeyWords.IDFForEachBook();
        }

        public int getNumberOfShelvesInLibrary()
        {
            return _extractKeyWords.getNumberOfShelvesInLibrary();
        }
        public void calculateTfIdf(string shelf)
        {
            _extractKeyWords.calculateTfIdf(shelf);
        }
        public IOrderedEnumerable<KeyValuePair<string, double>> getTfIdfOrderByDescending(string shelf)
        {
            return _extractKeyWords.getTfIdfOrderByDescending(shelf);
        }
        public bool tfExist(string shelf)
        {
            return _extractKeyWords.tfExist(shelf);
        }
        public bool idfExist(string shelf)
        {
            return _extractKeyWords.idfExist(shelf);
        }

        public void saveToJsonFile()
        {
            _extractKeyWords.save();
        }

    }
}
