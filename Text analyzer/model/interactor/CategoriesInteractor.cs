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

        public CategoriesInteractor() {
            textRepo = new TextRepository();
            fileRepo = new FileRepository();
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
    }
}
