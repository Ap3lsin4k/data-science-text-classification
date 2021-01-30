using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PupilIsNotStudent.utils
{
    class IndicatorsOfAffiliationForText
    {
        public ushort CommonTerms;
        public double NormalizedTfidf, De;

        //for debug purposes
        public bool DoesDeExist;
        List<string> _termsHasNoDe;

        public IndicatorsOfAffiliationForText()
        {
            _termsHasNoDe = new List<string>();
        }

        public void AddTermWithBrokenDe(string term)
        {
            _termsHasNoDe.Add(term);
        }

        public List<string> GetTermsWithBrokenDe()
        {
            return _termsHasNoDe;
        }
    }
}
