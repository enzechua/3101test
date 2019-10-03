using System;
using _3101_lab1;
using TechTalk.SpecFlow;
using NUnit.Framework;
namespace ICT3101_Calculator.UnitTest.step_definitions
{
    [Binding]
    public class CalculatorDivisionStepDefinition
    {
        private double _result;
        private Calculator _calculator;

        public CalculatorDivisionStepDefinition(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            _result = _calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

    }
}
