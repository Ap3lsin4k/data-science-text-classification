using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_analyzer.model.repository;

namespace Text_analyzer.model.interactor
{
    // Interactor incapsulates Repositories for a Presenter
    class CategoriesInteractor
    {
        private TextRepository textRepo;

        public CategoriesInteractor() {
            textRepo = new TextRepository();
        }

        public string getRawText(string notClearedText)
        {
            return textRepo.getRawText(notClearedText);
        }
    }
}
