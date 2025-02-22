using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Nunit_Assignment
{
    [TestFixture]
    public class FileProcessorTests
    {
        private FileProcessor _fileProcessor;
        private string _testFilePath;

        [SetUp]
        public void Setup()
        {
            _fileProcessor = new FileProcessor();
            _testFilePath = "testfile.txt";
        }

        [TearDown]
        public void Cleanup()
        {
            if (File.Exists(_testFilePath))
            {
                File.Delete(_testFilePath); // Cleanup after tests
            }
        }

        [Test]
        public void WriteToFile_ShouldCreateFileAndWriteContent()
        {
            string expectedContent = "Hello, NUnit!";
            _fileProcessor.WriteToFile(_testFilePath, expectedContent);

            Assert.IsTrue(File.Exists(_testFilePath));
            string actualContent = File.ReadAllText(_testFilePath);
            Assert.AreEqual(expectedContent, actualContent);
        }

        [Test]
        public void ReadFromFile_ShouldReturnCorrectContent()
        {
            string expectedContent = "File Handling Test";
            File.WriteAllText(_testFilePath, expectedContent); // Manually create file

            string actualContent = _fileProcessor.ReadFromFile(_testFilePath);

            Assert.AreEqual(expectedContent, actualContent);
        }

        [Test]
        public void ReadFromFile_ShouldThrowIOException_WhenFileDoesNotExist()
        {
            var ex = Assert.Throws<IOException>(() => _fileProcessor.ReadFromFile("nonexistent.txt"));
            Assert.AreEqual("File not found.", ex.Message);
        }
    }
}
