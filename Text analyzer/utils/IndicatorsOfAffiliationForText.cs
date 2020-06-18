using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_analyzer.utils
{
    class IndicatorsOfAffiliationForText
    {
        public ushort commonTerms;
        public double normalizedTfidf, de;

        //for debug purposes
        public bool doesDeExist;
        List<string> termsHasNoDe;

        public IndicatorsOfAffiliationForText()
        {
            termsHasNoDe = new List<string>();
        }

        public void addTermWithBrokenDe(string term)
        {
            termsHasNoDe.Add(term);
        }

        public List<string> getTermsWithBrokenDe()
        {
            return termsHasNoDe;
        }
    }
}
