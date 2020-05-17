using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_analyzer.model.repository;

namespace Text_analyzer.model.interactor
{
    class GuessInteractor
    {
        private FileRepository fileRepo;

        public GuessInteractor(FileRepository fileRepository)
        {
            fileRepo = fileRepository;
            
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
