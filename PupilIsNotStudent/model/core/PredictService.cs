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
        
        public IndicatorsOfAffiliationForText ComputeAffiliationOfTextToCategory(HashSet<string> unrepeatedWords, Dictionary<string, double> keywordsOfCategory, IWriter log)
        {
            var scores = new IndicatorsOfAffiliationForText();

            // for logging
            log.Write("word   |   TFIDF   |   DE");
                

            foreach (var wordCategory  in keywordsOfCategory.OrderByDescending(key => key.Value).Take(KeyWordsLimit))
            {
                if (unrepeatedWords.Contains(wordCategory.Key) )
                {
                    ++scores.CommonTerms;
                    scores.NormalizedTfidf += wordCategory.Value;

                    if (_disperseEstimation.Words.ContainsKey(wordCategory.Key))
                    {
                        scores.De += _disperseEstimation.Words[wordCategory.Key].DispersionEstimation;
                        WriteLog(wordCategory);
                    }
                    else
                    {
                        log.Write(wordCategory.Key+": error. cannot find DE.");
                        // this situation must not be possible
                        throw new Exception("Must initialize DE array properly. ");
                    }
                }

                // more semantic comes first
            }
            
            void WriteLog(KeyValuePair<string, double> wordCategory)
            {
                log.Write(wordCategory.Key + "\t\t"
                                           + Math.Round(wordCategory.Value, 2) + "\t\t"
                                           + Math.Round(_disperseEstimation.Words[wordCategory.Key].DispersionEstimation, 2)
                );
            }
            
            return scores;

        }
    }
}
