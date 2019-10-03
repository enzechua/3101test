using System;
using _3101_lab1;
using TechTalk.SpecFlow;
using NUnit.Framework;
namespace ICT3101_Calculator.UnitTest.step_definitions
{
    [Binding]
    public class MtbfStep
    {
        private double _result;
        private Calculator _calculator;

        public MtbfStep(Calculator calc)
        {
            this._calculator = calc;
        }
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(int p0, int p1)
        {
            _result = _calculator.mtbf(p0, p1);
        }

        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

    }
}
