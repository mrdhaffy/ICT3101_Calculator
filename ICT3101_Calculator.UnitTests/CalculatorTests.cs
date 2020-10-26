using NUnit.Framework;
using System;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        [TestCase(10,10)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
        {
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }
        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(10)]
        public void Factorial_WithNegativeInputs_ResultThrowArgumentException(double a)
        {
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }
        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        [TestCase(10, 10)]
        public void AreaTriangle_WithNegativeInputs_ResultThrowArgumentException(double a, double b)
        {
            double result = 0.5 * a * b;
            Assert.That(() => result, Is.EqualTo(0));
            Assert.That(() => _calculator.AreaTriangle(a, b), Throws.ArgumentException);
        }
        [Test]
        [TestCase(0)]
        [TestCase(10)]
        public void AreaCircle_WithNegativeInputs_ResultThrowArgumentException(double a)
        {
            double result = Math.PI * a * a;
            //Assert.That(() => result, Is.EqualTo(0));
            Assert.That(() => _calculator.AreaCircle(a), Throws.ArgumentException);
        }
        [Test]
        [TestCase(3)]
        public void GenMagicNum_WithNegativeInputs_ResultThrownArgumentException(double a)
        {
            IFileReader fileReader = new FileReader();
            double result = _calculator.GenMagicNum(a, fileReader);
            Assert.That(result, Is.EqualTo(8));
        }

    //    //------------------------------------------18a-------------------------------------------
    //    [Test]
    //    public void UnknownFunctionA_WhenGivenTest0_Result()
    //    {
    //        // Act
    //        double result = _calculator.Factorial(5); //removed 2nd param to match function written (5)
    //        // Assert
    //        Assert.That(result, Is.EqualTo(120));
    //    }
    //    [Test]
    //    public void UnknownFunctionA_WhenGivenTest1_Result() //removed 2nd param to match function written (4)
    //    {
    //        // Act
    //        double result = _calculator.Factorial(5);
    //        // Assert
    //        Assert.That(result, Is.EqualTo(120));
    //    }
    //    [Test]
    //    public void UnknownFunctionA_WhenGivenTest2_Result()
    //    {
    //        // Act
    //        double result = _calculator.UnknownFunctionA(5, 3); //unsure
    //        // Assert
    //        Assert.That(result, Is.EqualTo(60));
    //    }
    //    [Test]
    //    public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
    //    {
    //        // Act
    //        // Assert
    //        Assert.That(() => _calculator.Divide(-4, 5), Throws.ArgumentException); // or factorial but max 2 factorial
    //    }
    //    [Test]
    //    public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
    //    {
    //        // Act
    //        // Assert
    //        Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException); //unsure
    //    }

        //    //------------------------------------------18a-------------------------------------------
        //    [Test]
        //    public void UnknownFunctionB_WhenGivenTest0_Result()
        //    {
        //        // Act
        //        double result = _calculator.Divide(5, 5);
        //        // Assert
        //        Assert.That(result, Is.EqualTo(1));
        //    }
        //    [Test]
        //    public void UnknownFunctionB_WhenGivenTest1_Result()
        //    {
        //        // Act
        //        double result = _calculator.UnknownFunctionB(5, 4); //unsure
        //        // Assert
        //        Assert.That(result, Is.EqualTo(5));
        //    }
        //    [Test]
        //    public void UnknownFunctionB_WhenGivenTest2_Result()
        //    {
        //        // Act
        //        double result = _calculator.UnknownFunctionB(5, 3); //unsure
        //        // Assert
        //        Assert.That(result, Is.EqualTo(10));
        //    }
        //    [Test]
        //    public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        //    {
        //        // Act
        //        // Assert
        //        Assert.That(() => _calculator.Factorial(-4), Throws.ArgumentException); //removed 2nd param to match function written (5)
        //    }
        //    [Test]
        //    public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        //    {
        //        // Act
        //        // Assert
        //        Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException); //unsure.
        //    }
    }
}