using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Library;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private FizzBuzzService _fizzBuzz;
        public FizzBuzzTests() {
            _fizzBuzz = new FizzBuzzService();
        }
        [TestMethod]
        public void ShouldPrintNumber() {
            Assert.AreEqual("1", _fizzBuzz.Print(1));
            Assert.AreEqual("2", _fizzBuzz.Print(2)); 
        }
        [TestMethod]
        public void shouldPrintFizz() {
            Assert.AreEqual("Fizz", _fizzBuzz.Print(3));
            Assert.AreEqual("Fizz", _fizzBuzz.Print(6));
        }
        [TestMethod]
        public void shouldPrintBuzz() {
            Assert.AreEqual("Buzz", _fizzBuzz.Print(5));
            Assert.AreEqual("Buzz", _fizzBuzz.Print(10));
        }
        [TestMethod]
        public void shouldPrintFizzBuzz() {
            Assert.AreEqual("FizzBuzz", _fizzBuzz.Print(15));
            Assert.AreEqual("FizzBuzz", _fizzBuzz.Print(30));
        }

    }
}
