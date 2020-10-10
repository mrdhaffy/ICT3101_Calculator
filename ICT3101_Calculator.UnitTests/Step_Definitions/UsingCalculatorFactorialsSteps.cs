using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorFactorialsSteps
    {
        private Calculator _calculator;
        private double _result;

        public UsingCalculatorFactorialsSteps(Calculator calculator)
        {
            this._calculator = calculator;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press factorial")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressFactorial(int p0, int p1)
        {
            _result = _calculator.Factorial(p0);
        }
        
        [Then(@"the factorial result should be ""(.*)""")]
        public void ThenTheFactorialResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the factorial result should be an error")]
        public void ThenTheFactorialResultShouldBeAnError()
        {
            try
            {
                Assert.That(() => _result, Throws.ArgumentException);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Number cannot be less than 0", ex.Message);
            }
        }
    }
}
