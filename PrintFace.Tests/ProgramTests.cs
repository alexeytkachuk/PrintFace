using System;
using System.IO;
using NUnit.Framework;

namespace PrintFace.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        private StringWriter _writer;
        
        [SetUp]
        public void SetUp()
        {
            _writer = new StringWriter();
            Console.SetOut(_writer);
        }
        
        [TearDown] public void Cleanup()
        {
            _writer.Close();
        }
        
        [Test]
        public void Main_Tests()
        {
            Program.Main();

            string actual = _writer.GetStringBuilder().ToString().Trim();

            string expected = "Hello, world!";

            Assert.AreEqual(expected, actual);
        }

        [TestCase("Joseph")]
        [TestCase("Eric")]
        [TestCase("Jon")]
        public void SayHelloUser_Tests(string userName)
        {
            Program.SayHelloUser(userName);

            string actual = _writer.GetStringBuilder().ToString().Trim();

            string expected = $"Hello, {userName}!";

            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void PrintFace_Tests()
        {
            Program.PrintFace();

            string actual = _writer.GetStringBuilder().ToString();

            string expected = $" +\"\"\"\"\"+{Environment.NewLine}" +
                              $"(| o o |){Environment.NewLine}" +
                              $" |  ^  |{Environment.NewLine}" +
                              $" | '-' |{Environment.NewLine}" +
                              $" +-----+{Environment.NewLine}";

            Assert.AreEqual(expected, actual);
        }
    }
}
