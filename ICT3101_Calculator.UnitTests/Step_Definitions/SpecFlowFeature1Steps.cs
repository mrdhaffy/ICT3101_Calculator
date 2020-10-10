﻿using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.Step_Definitions
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private Calculator _calculator;
        private double _result;

        public SpecFlowFeature1Steps(Calculator calculator)
        {
            this._calculator = calculator;
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
