using FizzBuzz;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(15, "FizzBuzz")]
        [TestCase(5, "Buzz")]
        [TestCase(3, "Fizz")]
        [TestCase(13440, "FizzBuzz")]
        [TestCase(2, "2")]
        [TestCase(2, "2")]
        public void NumbersToFizzBuzz_TestCases_Returns(int a, string expected)
        {
            NumbersToFizzBuzz numbersToFizzBuzz = new NumbersToFizzBuzz();
            var result = numbersToFizzBuzz.ConvertToFizz(a);
            Assert.AreEqual(expected,result);
        }
        [Test]
        public void NumbersToFizzBuzz_LowerThanZero_Returns()
        {
            NumbersToFizzBuzz _checker = new NumbersToFizzBuzz();

            Assert.That(() => _checker.ConvertToFizz(-1), Throws.ArgumentException);
        }
        //[Test]
        //public void NumbersToFizzBuzz_2_ReturnsNumber2()
        //{
        //    NumbersToFizzBuzz numbersToFizzBuzz = new NumbersToFizzBuzz();
        //    var result = numbersToFizzBuzz.ConvertToFizz(2);
        //    Assert.AreEqual(result, "2");
        //}

        //[Test]
        //public void NumbersToFizzBuzz_3_ReturnsNumberFizz()
        //{
        //    NumbersToFizzBuzz numbersToFizzBuzz = new NumbersToFizzBuzz();
        //    var result = numbersToFizzBuzz.ConvertToFizz(2);
        //    Assert.AreEqual(result, "Fizz");
        //}
        //[Test]
        //public void NumbersToFizzBuzz_5_ReturnsBuzz()
        //{
        //    NumbersToFizzBuzz numbersToFizzBuzz = new NumbersToFizzBuzz();
        //    var result = numbersToFizzBuzz.ConvertToFizz(2);
        //    Assert.AreEqual(result, "Buzz");
        //}

    }
}