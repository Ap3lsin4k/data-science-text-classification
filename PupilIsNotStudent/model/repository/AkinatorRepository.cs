using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PupilIsNotStudent.model.core;

namespace PupilIsNotStudent.model.repository
{
    internal class AkinatorRepository
    {

        private const byte keyWordsLimit = 155;
        private readonly DisperseEstimation _disperseEstimation;

        public AkinatorRepository()
        {
            _disperseEstimation = new DisperseEstimation();
        }


        public string computeDe(in string[] splitText)
        {
            return _disperseEstimation.analyzeDE(splitText);
        }


        // To AkinatorRepo
        public utils.IndicatorsOfAffiliationForText computeAffiliationOfTextToCategory(HashSet<string> unrepeatedWords, Dictionary<string, double> tfIdf)
        {
            var scores = new utils.IndicatorsOfAffiliationForText();

            // for logging
            scores.doesDeExist = true;


            foreach (string word in unrepeatedWords) // the unrepeated word in unknown category
            {
                byte break_counter = 0;
                // more semantic comes first
                foreach (KeyValuePair<string, double> wordCategory in tfIdf.OrderByDescending(key => key.Value))
                {

                    break_counter++;
                    if (break_counter >= keyWordsLimit)
                    {
                        break;
                    }
                    //TFIDF unknown category word is wordCategory
                    if (word == wordCategory.Key) // if word from unknown category equals word from category we know
                    {
                        ++scores.commonTerms;
                        scores.normalizedTfidf += wordCategory.Value;

                        if (_disperseEstimation.words.ContainsKey(wordCategory.Key))
                        {
                            scores.de += _disperseEstimation.words[word].dispersionEstimation;
                        }
                        else
                        {
                            scores.doesDeExist = false;
                            scores.addTermWithBrokenDe(word);
                        }

                    }

                }

            }

            return scores;
        }
    }
}
