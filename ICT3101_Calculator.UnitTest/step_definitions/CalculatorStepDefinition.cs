using System;
using _3101_lab1;
using TechTalk.SpecFlow;
using NUnit.Framework;
namespace ICT3101_Calculator.UnitTest.step_definitions
{
    [Binding]
    public class CalculatorStepDefinition
    {
        private double _result;
        private Calculator _calculator;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            this._calculator = new Calculator();
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAdd(int p0, int p1)
        {
            _result = _calculator.Add(p0, p1);
        }

        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

    }
}
