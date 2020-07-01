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
        private readonly ExtractKeyWordRepository _json;

        public CategoriesInteractor(in TextParsingRepository textRepository, in FileRepository fileRepository, in ExtractKeyWordRepository textJsonRepository)
        {
            _text = textRepository;
            _file = fileRepository;
            _json = textJsonRepository;
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
            _json.addCategory(shelf, in texts);
        }


        public uint howManyTimesWordAppear(string shelf, string word)
        {
            return _json.howManyTimesWordAppear(shelf, word);
        }

        public Dictionary<string, uint>.KeyCollection getUniqueWords(string shelf)
        {
            return _json.getUniqueWords(shelf);
        }

        public IOrderedEnumerable<KeyValuePair<string, uint>> getUniqueWordsOrderByDescending(string shelf)
        {
            return _json.getUniqueWordsOrderByDescending(shelf);
        }

        public double calculateTf(string shelf, string word)
        {
            return _json.calculateTf(shelf, word);
        }

        public string[] getCategories()
        {
            return _json.getCategories();
        }

        public bool whetherCategoryExist(string shelf)
        {
            return _json.whetherCategoryExist(shelf);
        }
        public double getTf(string shelf, string word)
        {
            return _json.getTf(shelf, word);
        }
        public Dictionary<string, Book> getLibrary()
        {
            return _json.getLibrary();
        }

        public double IDFForOtherCategories(string shelf, string word)
        {
            return _json.IDFForOtherCategories(shelf, word);
        }


        public int getNumberOfShelvesInLibrary()
        {
            return _json.getNumberOfShelvesInLibrary();
        }
        public void calculateTfIdf(string shelf)
        {
            _json.calculateTfIdf(shelf);
        }
        public IOrderedEnumerable<KeyValuePair<string, double>> getTfIdfOrderByDescending(string shelf)
        {
            return _json.getTfIdfOrderByDescending(shelf);
        }
        public bool tfExist(string shelf)
        {
            return _json.tfExist(shelf);
        }
        public bool idfExist(string shelf)
        {
            return _json.idfExist(shelf);
        }

        public void saveToJsonFile()
        {
            _json.save();
        }

    }
}
