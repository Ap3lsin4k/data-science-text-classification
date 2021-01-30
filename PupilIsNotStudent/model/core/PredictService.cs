using System;
using System.Collections.Generic;
using System.Linq;
using PupilIsNotStudent.utils;

namespace PupilIsNotStudent.model.core
{
    internal class PredictService
    {

        private const byte KeyWordsLimit = 155;
        private readonly DisperseEstimation _disperseEstimation;

        public PredictService()
        {
            _disperseEstimation = new DisperseEstimation();
        }


        public string ComputeDe(in string[] splitText)
        {
            return _disperseEstimation.AnalyzeDe(splitText);
        }
        
        // To AkinatorRepo
        public IndicatorsOfAffiliationForText ComputeAffiliationOfTextToCategory(HashSet<string> unrepeatedWords, Dictionary<string, double> keywordsForCategory, IWriter log)
        {
            var scores = new IndicatorsOfAffiliationForText();
            
            var slice = (Dictionary<string, double>) keywordsForCategory.OrderByDescending(key => key.Value).Take(KeyWordsLimit);
            
            foreach (string word in unrepeatedWords) // the unrepeated word in unknown category
            {
                double tfIdf;
                if (slice.TryGetValue(word, out tfIdf))
                {
                    ++scores.CommonTerms;
                    scores.NormalizedTfidf += tfIdf;

                    if (_disperseEstimation.Words.ContainsKey(word))
                    {
                        scores.De += _disperseEstimation.Words[word].DispersionEstimation;
                        log.Write(word+": "+_disperseEstimation.Words[word].DispersionEstimation.ToString());
                    }
                    else
                    {
                        log.Write(word+": error. cannot find DE.");
                        // this situation must not be possible
                        throw new Exception("Must initialize DE array properly. ");
                    }

                }

            }
            
            return scores;
        }
    }
}
