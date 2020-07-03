using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PupilIsNotStudent.model.repository
{
    class AkinatorRepository
    {

        const byte keyWordsLimit = 155;
        private readonly DE _DE;

        public AkinatorRepository()
        {
            _DE = new DE();
        }


        public string computeDe(in string[] splitText)
        {
            return _DE.analyzeDE(splitText);
        }


        // To AkinatorRepo
        public utils.IndicatorsOfAffiliationForText computeAffiliationOfTextToCategory(Dictionary<string, int>.KeyCollection unrepeatedWords, Dictionary<string, double> tfIdf)
        {
            utils.IndicatorsOfAffiliationForText scores = new utils.IndicatorsOfAffiliationForText();

            //logging purposes
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
                    //TFIDF unknown category word is wordCateg
                    if (word == wordCategory.Key) // if word from unknown category equals word from category we know
                    {
                        ++scores.commonTerms;
                        scores.normalizedTfidf += wordCategory.Value;

                        if (_DE.words.ContainsKey(wordCategory.Key))
                        {
                            scores.de += _DE.words[word].dispersionEstimation;
                            //   interactor.writeLog(word + ", TFIDF: " + wordCategory.Value + ", DE: " + myDe.words[word].dispersionEstimation);
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
