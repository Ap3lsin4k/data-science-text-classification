using System;
using System.IO;
using PupilIsNotStudent.utils;
using Xunit;


namespace TestProject2
{
    public class Tests
    {
        public void SetUp()
        {

        }

        [Fact]
        public void LoggerTest()
        {
            
            var logger = LoggerAspectSingleton.GetInstance("test-log");

          //  Assert.Equal(false, Directory.Exists("test-log"));
            Assert.False(File.Exists("First.txt"));
            
            logger.WriteAndClose("First", "message recorded with automated tests");
            
            Assert.True(Directory.Exists("test-log"));
            Assert.True(File.Exists("First.txt"));
            
            Directory.Delete("test-log");
            logger.WriteAndClose("First.txt", "second");
        }

    }
}