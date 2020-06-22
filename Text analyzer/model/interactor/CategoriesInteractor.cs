using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_analyzer.model.repository;

namespace Text_analyzer.model.interactor
{
    // the purpose of an Interactor is to encapsulate Repositories for a Presenter
    class CategoriesInteractor
    {
        private readonly TextRepository _text;
        private readonly FileRepository _file;
        private readonly TextJsonRepository _json;

        public CategoriesInteractor(in TextRepository textRepository, in FileRepository fileRepository, in TextJsonRepository textJsonRepository)
        {
            _text = textRepository;
            _file = fileRepository;
            _json = textJsonRepository;
        }


        //==========TEXT REPOSITORY==========

        public string[] getSplitStrings(string rawText)
        {
            return _text.getSplitStrings(rawText);
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
        public void addCategory(string shelf, List<string> texts)
        {
            _json.addCategory(shelf, texts);
        }

        public List<string> getAllWordsFromShelf(string shelf)
        {
            return _json.getAllWordsFromShelf(shelf);
        }

        public void uniquifyWordsIn(string shelf)
        {
            _json.uniquifyWordsIn(shelf);
        }

        public int howManyTimesWordAppear(string shelf, string word)
        {
            return _json.howManyTimesWordAppear(shelf, word);
        }

        public Dictionary<string, int>.KeyCollection getUniqueWords(string shelf)
        {
            return _json.getUniqueWords(shelf);
        }

        public IOrderedEnumerable<KeyValuePair<string, int>> getUniqueWordsOrderByDescending(string shelf)
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
        public Dictionary<string, WordEntity> getLibrary()
        {
            return _json.getLibrary();
        }
        public double calculateIdf(string shelf, string word, int numOfDocsWhereWordAppears)
        {
            return _json.calculateIdf(shelf, word, numOfDocsWhereWordAppears);
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
