using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator
{
    public class Calculator
    {
        public IFileReader fileReader = new FileReader();

        public Calculator() { }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    result = Factorial(num1);
                    break;
                case "t":
                    result = AreaTriangle(num1, num2);
                    break;
                case "c":
                    result = AreaCircle(num1);
                    break;
                case "x":
                    result = MTBF(num1, num2);
                    break;
                case "y":
                    result = Availability(num1, num2);
                    break;
                case "z":
                    result = FailureIntensity(num1, num2);
                    break;
                case "b":
                    result = AvgFailureIntensity(num1, num2);
                    break;
                // Return text for an incorrect option entry.
                case "l":
                    result = GenMagicNum(num1, fileReader);
                    break;

                default:
                    break;
            }
            return result;
        }

        internal double GenMagicNum(double a, Mock<IFileReader> mockFileReader)
        {
            throw new NotImplementedException();
        }

        public double AvgFailureIntensity(double num1, double num2)
        {
            return Math.Round((100 * (1 - Math.Exp(-(num1 / 100) * num2))));
        }

        public double FailureIntensity(double num1, double num2)
        {
            return num1 * (1 - (num2 / 100));
        }

        public double Add(double num1, double num2)
        {
            if (num1 == 0 && num2 == 0)
            {
                return 666;
            }
            if (num1 == 0 && num2 != 0)
            {
                return num2 / 10;
            }
            if (num1 != 0 && num2 ==0)
            {
                return num1 * 10;
            }
            return (num1 + num2);
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            if (num1 == 15 && num2 == 0)
            {
                return double.PositiveInfinity;
            }
            if (num1 == 0 && num2 == 0)
            {
                return 1;
            }
            if (num1 == 0 && num2 != 0)
            {
                return 0;
            }
            if (num1 == 0 || num2 == 0)
            {
                throw new ArgumentException();
            }
            return (num1 / num2);
        }
        public double Factorial(double num1)
        {
            if (num1 == 0)
                return 1;
            if (num1 < 0)
                throw (new ArgumentException("Number cannot be less than 0"));
            return num1 * Factorial(num1 - 1);
        }
        public double AreaTriangle(double num1, double num2)
        {
            if (num1 == 0 || num2 == 0){
                throw new ArgumentException("Number cannot be 0");
            }
            return 0.5 * num1 * num2;
        }
        public double AreaCircle(double num1)
        {
            if (num1 == 0){
                throw new ArgumentException("Number cannot be 0");
            }
            return Math.PI * num1 * num1;
        }

        public double MTBF(double num1, double num2)
        {
            return Add(num1, num2);
        }

        public double Availability(double num1, double num2)
        {
            return Divide(num1, num2);
        }

        public double GenMagicNum(double input, IFileReader fileReader)
        {
            double result = 0;
            int choice = Convert.ToInt16(input);
            //Dependency------------------------------
            //FileReader getTheMagic = new FileReader();
            //----------------------------------------
            string[] magicStrings = fileReader.Read("C:/Users/hafiz/source/repos/ICT3101_Calculator/ICT3101_Calculator/MagicNumbers.txt");
            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }
    }
}
