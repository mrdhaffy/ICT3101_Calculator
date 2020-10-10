using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilitySteps
    {
        private Calculator _calculator;
        private double _result;

        public UsingCalculatorBasicReliabilitySteps(Calculator calculator)
        {
            this._calculator = calculator;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press current failure intensity")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressCurrentFailureIntensity(int p0, int p1)
        {
            _result = _calculator.FailureIntensity(p0, p1);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press average current failure intensity")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAverageCurrentFailureIntensity(int p0, int p1)
        {
            _result = _calculator.AvgFailureIntensity(p0, p1);
        }


        [Then(@"the current failure intensity result should be ""(.*)""")]
        public void ThenTheCurrentFailureIntensityResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        [Then(@"the average current failure intensity result should be ""(.*)""")]
        public void ThenTheAverageCurrentFailureIntensityResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

    }
}
