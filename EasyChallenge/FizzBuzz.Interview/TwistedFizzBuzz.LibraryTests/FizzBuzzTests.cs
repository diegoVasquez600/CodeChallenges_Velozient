using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwistedFizzBuzz.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using TwistedFizzBuzz.Library.Models;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace TwistedFizzBuzz.Library.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        [TestMethod("GenerateFizzBuzz(int start, int end)")]
        public void GenerateFizzBuzzRangeOriginalImplementationTest()
        {
            try
            {
                //Arrange
                FizzBuzz fizzBuzz = new();
                int start = 1;
                int end = 15;
                string[] expectedOutput = new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

                //Act
                List<string> actualOutput = fizzBuzz.GenerateFizzBuzz(start, end);

                //Assert
                CollectionAssert.AreEqual(expectedOutput, actualOutput);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        [TestMethod("GenerateFizzBuzz(int[] numbers)")]
        public void GenerateFizzBuzzNonSequentialOriginalImplementationTest()
        {
            try
            {
                //Arrange
                FizzBuzz fizzBuzz = new();
                int[] numbers = new int[] { -5, 6, 300, 12, 15 };
                string[] expectedOutput = new string[] { "Buzz", "Fizz", "FizzBuzz", "Fizz", "FizzBuzz" };

                //Act
                List<string> actualOutput = fizzBuzz.GenerateFizzBuzz(numbers);

                //Assert
                CollectionAssert.AreEqual(expectedOutput, actualOutput);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        [TestMethod("GenerateFizzBuzz(int start, int end, List<(int divisor, string token)> divisorTokenPairs)")]
        public void GenerateFizzBuzzRangeAlternativeImplementationTest()
        {
            try
            {
                //Arrange
                FizzBuzz fizzBuzz = new();
                int start = 1;
                int end = 15;
                List<(int divisor, string token)> divisorTokenPairs = new() { (3, "Poem"), (5, "Writer") };
                string[] expectedOutput = new string[] { "1", "2", "Poem", "4", "Writer", "Poem", "7", "8", "Poem", "Writer", "11", "Poem", "13", "14", "PoemWriter" };

                //Act
                List<string> actualOutput = fizzBuzz.GenerateFizzBuzz(start, end, divisorTokenPairs);

                //Assert
                CollectionAssert.AreEqual(expectedOutput, actualOutput);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        [TestMethod("GenerateFizzBuzz(int[] numbers, List<(int divisor, string token)> divisorTokenPairs)")]
        public void GenerateFizzBuzzNonSequentialAlternativeImplementationTest()
        {
            try
            {
                //Arrange
                FizzBuzz fizzBuzz = new();
                int[] numbers = new int[] { 119, 51, 21, 357 };
                List<(int divisor, string token)> divisorTokenPairs = new() { (7, "Poem"), (17, "Writer"), (3, "College") };
                string[] expectedOutput = new string[] { "PoemWriter", "WriterCollege", "PoemCollege", "PoemWriterCollege" };

                //Act
                List<string> actualOutput = fizzBuzz.GenerateFizzBuzz(numbers, divisorTokenPairs);

                //Assert
                CollectionAssert.AreEqual(expectedOutput, actualOutput);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        [TestMethod("GenerateFizzBuzz(int start, int end, APIToken token)")]
        public async Task GenerateFizzBuzzWithAPIGeneratedTokenAsyncTest()
        {
            try
            {
                //Arrange
                FizzBuzz fizzBuzz = new();
                int start = 1;
                int end = 100;
                APIToken token = await fizzBuzz.GetAPIGeneratedTokenAsync();
                int[] divisors = { token.Multiple };
                string[] tokens = { token.Word };
                List<string> expectedOutput = new();
                for (int number = start; number <= end; number++)
                {
                    string result = fizzBuzz.GetCustomTokenDivisorOutput(number, divisors, tokens);
                    expectedOutput.Add(result);
                }
                //Act
                List<string> actualOutput = fizzBuzz.GenerateFizzBuzz(start, end, token);

                //Assert
                CollectionAssert.AreEqual(expectedOutput, actualOutput);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }
    }
}