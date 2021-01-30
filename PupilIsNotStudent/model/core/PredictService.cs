using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PupilIsNotStudent.model.core;
using PupilIsNotStudent.utils;

namespace PupilIsNotStudent.model.repository
{
    internal class AkinatorService
    {

        private const byte KeyWordsLimit = 155;
        private readonly DisperseEstimation _disperseEstimation;

        public AkinatorService()
        {
            _disperseEstimation = new DisperseEstimation();
        }


        public string ComputeDe(in string[] splitText)
        {
            return _disperseEstimation.AnalyzeDe(splitText);
        }
        
        // To AkinatorRepo
        public utils.IndicatorsOfAffiliationForText ComputeAffiliationOfTextToCategory(HashSet<string> unrepeatedWords, Dictionary<string, double> keywordsForCategory, IWriter log=null)
        {
            var scores = new utils.IndicatorsOfAffiliationForText();

            // for logging
            scores.DoesDeExist = true;

            foreach (KeyValuePair<string, double> wordCategory in keywordsForCategory.OrderByDescending(key => key.Value).Take(KeyWordsLimit))
            {
                foreach (string word in unrepeatedWords) // the unrepeated word in unknown category
                {
                    //TFIDF unknown category word is wordCategory
                    if (word == wordCategory.Key) // if word from unknown category equals word from category we know
                    {
                        ++scores.CommonTerms;
                        scores.NormalizedTfidf += wordCategory.Value;

                        if (_disperseEstimation.Words.ContainsKey(wordCategory.Key))
                        {
                            scores.De += _disperseEstimation.Words[word].DispersionEstimation;
                            log.Write(word+_disperseEstimation.Words[word].DispersionEstimation.ToString());
                        }
                        else
                        {
                            scores.DoesDeExist = false;
                            scores.AddTermWithBrokenDe(word);
                        }

                    }

                }

                // more semantic comes first
            }
            return scores;
        }
    }
}
