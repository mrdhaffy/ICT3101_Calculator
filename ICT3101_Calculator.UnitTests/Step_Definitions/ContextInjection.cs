using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class ContextInjection
    {
        private Calculator _calculator;
        public ContextInjection(Calculator calculator)
        {
            this._calculator = calculator;
        }
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
        }
    }
}
