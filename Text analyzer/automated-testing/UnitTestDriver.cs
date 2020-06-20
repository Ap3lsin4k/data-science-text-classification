using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_analyzer.model.interactor;
using Text_analyzer.presentation;

namespace Text_analyzer.automated_testing
{
    class UnitTestDriver
    {
        public GuessPresenter guessPresenter;
        UnitTestFormGuess unitTestFormGuess;

        public UnitTestDriver(UnitTestFormGuess unitTestFormGuess)
        {
            this.unitTestFormGuess = unitTestFormGuess;
            model.repository.TextJsonRepository textJson = new model.repository.TextJsonRepository();

            guessPresenter = new GuessPresenter(this.unitTestFormGuess,
                new model.interactor.GuessInteractor(
                            new model.repository.TextRepository(),
                            new model.repository.FileRepository(),
                            new model.repository.LogRepository(),
                            ref textJson
                        ));
        }

        #region
        //helper functions controlling test results
        private String NotEqualsErrorMessage(String Expected, String Actual, ref String Msg)
        {
            if (Msg != "")
            {
                Msg = Msg + " : expected " + Expected + ", but was: " + Actual;
            }
            return Msg;
        }

        private String EqualsErrorMessage(String Expected, String Actual, ref String Msg)
        {
            if (Msg != "")
            {
                Msg = Msg + " : expected " + Expected + " and actual were: " + Actual;
            }
            return Msg;
        }

        public void CheckEquals(String Expected, String Actual, ref String Msg)
        {
            if (Expected!=Actual)
            {
                NotEqualsErrorMessage(Expected, Actual, ref Msg);
                Exception exception = new Exception(Msg);
                unitTestFormGuess.show(Msg);
                throw exception;
            }
            unitTestFormGuess.show("Fine");
        }

        private void CheckNotEquals(String Expected, String Actual, ref String Msg)
        {
            if (Expected == Actual)
            {
                NotEqualsErrorMessage(Expected, Actual, ref Msg);
                Exception exception = new Exception(Msg);
                throw exception;
            }
        }
        #endregion

        //tests
        //Busuness Rule 1
        public void Test1()
        {
            guessPresenter.onBtnGuessCategoryClicked(RawTextExamples.longTextSport);
           // unitTestFormGuess.myGrid.Rows[0].Cells[0].Value.ToString());
            //unitTestDriver.checkEquals;
        }
    
        //Busuness Rule 2
        public void Test2()
        {
        }
        //Busuness Rule 3
        public void Test3()
        {
        }
        //Busuness Rule 4
        public void Test4()
        {
        }
        //Busuness Rule 5
        public void Test5()
        {
        }
        //Busuness Rule 6
        public void Test6()
        {
        }
        //Busuness Rule 7
        public void Test7()
        {
        }
        //Busuness Rule 8
        public void Test8()
        {
        }
    }
}