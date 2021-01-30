
using System.IO;
using System.Security.Cryptography;
using NUnit.Framework;
using PupilIsNotStudent.utils;

namespace TestProject
{
    [TestFixture]
    public class LoggingComponent
    {


        [Test]
        public void LoggerTest()
        {
            LoggerAspectSingleton _logger;
            _logger = LoggerAspectSingleton.GetInstance("test-log", "Second");
            
            Assert.AreEqual(true, Directory.Exists("test-log"));
            Assert.IsFalse(File.Exists("First.txt"));
            
            
            _logger.WriteAndClose("First", "message recorded with automated tests");
            
            
            Assert.IsTrue(Directory.Exists("test-log"));
            Assert.IsTrue(File.Exists(@"test-log\First.txt"));
            
            Directory.Delete("test-log", true);

        }
        
        [Test]
        public void RemoveEverythingFromTheFolderWhenFirstlyCreated()
        {
            
        }
    }
}