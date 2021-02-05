using System;
using NUnit.Framework;
using PupilIsNotStudent;
using PupilIsNotStudent.model.repository;

namespace TestProject
{
    [TestFixture]
    public class Tests : TextParsingRepository
    {
        [Test]
        public void TestNotSplitWordWithApostrophe()
        {
            Assert.True(this.IsCyrillic('’'));
            Assert.AreEqual("don’t", this.GetPureText("don’t").ToString());
            Assert.AreEqual("Business", TrainingDocView.GetCategoryNameFromPath(@"C:\Business. Inde.txt"));
        }


    }
}