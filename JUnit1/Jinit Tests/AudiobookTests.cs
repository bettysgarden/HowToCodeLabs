using NUnit.Framework;
using System;
using System.IO;
using Junit1;

namespace JUnit1.Jinit_Tests
{
    [TestFixture]
    public class AudiobookTests
    {
        [Test]
        public void Display_DisplaysCorrectInformation()
        {
            // Arrange
            var audioBook = new Audiobook("Test AudioBook", "Test Author", "Test Narrator");
            var expectedOutput = "Title: Test AudioBook, Author: Test Author, Narrator: Test Narrator" + Environment.NewLine;

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                audioBook.Display();
                var result = sw.ToString().Trim(); // Trim any trailing whitespace or newline

                // Trim expectedOutput to handle potential trailing newline characters
                expectedOutput = expectedOutput.Trim();

                // Assert
                AssertStringsAreEqual(expectedOutput, result);
            }
        }

        private void AssertStringsAreEqual(string expected, string actual)
        {
            // Check lengths first
            if (expected.Length != actual.Length)
            {
                Assert.Fail($"Lengths differ: Expected '{expected.Length}', but got '{actual.Length}'.");
            }

            // Compare characters
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != actual[i])
                {
                    Assert.Fail($"Strings differ at position {i}: Expected '{expected[i]}', but got '{actual[i]}'.");
                }
            }

            // Strings are equal
            Console.WriteLine("Test Passed: Output matches expected result.");
        }
    }
}