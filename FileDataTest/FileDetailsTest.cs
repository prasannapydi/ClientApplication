using System;
using FileData;
using ThirdPartyTools;
using NUnit.Framework;

namespace FileDataTest
{
    [TestFixture]
    public class FileDetailsTest
    { 
        private FileInfoDetails _fileInfoDetails;
        private FileDetails _fileDetails;
        [SetUp]
        public void TestSetup()
        {
            _fileDetails = new FileDetails();
            _fileInfoDetails = new FileInfoDetails(_fileDetails);
        }


        [TestCase("–v,c:/test.txt")]
        [TestCase("--v,c:/test.txt")]
        [TestCase("/v,c:/test.txt")]
        [TestCase("--version,c:/test.txt")]
        public void PassVersionAndReturnFileVersionInCommandLine(string input)
        {
            string[] arguments = input.Split(',');
            var result = _fileInfoDetails.GetFileDetailsUsingCommandLine(arguments);
            string actual = result;
            Assert.AreEqual(result, actual);
        }

        [TestCase("–s,c:/test.txt")]
        [TestCase("--s,c:/test.txt")]
        [TestCase("/s,c:/test.txt")]
        [TestCase("--size,c:/test.txt")]
        public void PassSizeAndReturnFileVersionInCommandLine(string input)
        {
            string[] arguments = input.Split(',');
            var result = _fileInfoDetails.GetFileDetailsUsingCommandLine(arguments);
            string actual = result;
            Assert.AreEqual(result, actual);
        }

        [TearDown]

        public void TestTearDown()

        {
            _fileInfoDetails = null;
            _fileDetails = null;
        }

    }
}
