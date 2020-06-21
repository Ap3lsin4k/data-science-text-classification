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
        private TextRepository textRepo;
        private FileRepository fileRepo;
        private TextJsonRepository json;

        public CategoriesInteractor(in TextRepository textRepository, in FileRepository fileRepository, in TextJsonRepository textJsonRepository)
        {
            textRepo = textRepository;
            fileRepo = fileRepository;
            json = textJsonRepository;
        }

        public string getRawText(string notClearedText)
        {
            return textRepo.getRawText(notClearedText);
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


        public void addCategory(string shelf, List<string> texts)
        {
            json.addCategory(shelf, texts);
        }

        public List<string> getAllWordsFromShelf(string shelf)
        {
            return json.getAllWordsFromShelf(shelf);
        }

        public void uniquifyWordsIn(string shelf)
        {
            json.uniquifyWordsIn(shelf);
        }

        public int howManyTimesWordApear(string shelf, string word)
        {
            return json.howManyTimesWordApear(shelf, word);
        }

        public Dictionary<string, int>.KeyCollection getUniqueWords(string shelf)
        {
            return json.getUniqueWords(shelf);
        }

        public IOrderedEnumerable<KeyValuePair<string, int>> getUniqueWordsOrderByDescending(string shelf)
        {
            return json.getUniqueWordsOrderByDescending(shelf);
        }

        public double calculateTf(string shelf, string word)
        {
            return json.calculateTf(shelf, word);
        }

        public string[] getCategories()
        {
            return json.getCategories();
        }

        public bool whetherCategoryExist(string shelf)
        {
            return json.whetherCategoryExist(shelf);
        }
        public double getTf(string shelf, string word)
        {
            return json.getTf(shelf, word);
        }
        public Dictionary<string, WordFreq> getLibrary()
        {
            return json.getLibrary();
        }
        public double calculateIdf(string shelf, string word, int numOfDocsWhereWordAppears)
        {
            return json.calculateIdf(shelf, word, numOfDocsWhereWordAppears);
        }

        public int getNumberOfShelfsInLibrary()
        {
            return json.getNumberOfShelfsInLibrary();
        }
        public void calculateTfIdf(string shelf)
        {
            json.calculateTfIdf(shelf);
        }
        public IOrderedEnumerable<KeyValuePair<string, double>> getTfIdfOrderByDescending(string shelf)
        {
            return json.getTfIdfOrderByDescending(shelf);
        }
        public bool tfExist(string shelf)
        {
            return json.tfExist(shelf);
        }
        public bool idfExist(string shelf)
        {
            return json.idfExist(shelf);
        }

        public void saveToJsonFile()
        {
            json.save();
        }

    }
}
