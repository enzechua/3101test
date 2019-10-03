using _3101_lab1;
using NUnit.Framework;

namespace CalculatorTests
{ 

    public class CalculatorTests
    {
        private Calculator _calculator;


        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        //[Test]
        //public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        //{
        //    double result = _calculator.Add(0, 0);
        //    Assert.That(result, Is.EqualTo(0));
        //    Assert.Pass();
        //}

        //[Test]
        //[TestCase(0, 0)]
        //[TestCase(10, 0)]
        //[TestCase(0, 10)]
        //public void Divide_WithNegativeInputs_ResultThrowArgumentException(int a, int b)
        //{
        //    // Act
        //    // Assert
        //    Assert.That(() => _calculator.Divide(a,b), Throws.ArgumentException);

        //}

        [Test]
        [TestCase(0)]
        public void Factorial_WithNegativeInputs(int a)
        {
            int result = _calculator.Factorial(a);
            Assert.That(result, Is.EqualTo(1));
            Assert.Pass();
        }


        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
        }
      
    }
}