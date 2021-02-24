using System.Data;
using SimpleCalculator.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace SimpleCalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddingTwoPlusTwo() => 
            Assert.AreEqual("4", CalculateExpression.Calculate("2+2"));

        [TestMethod]
        public void TestSubstractionFourMinusTwo() => 
            Assert.AreEqual("2", CalculateExpression.Calculate("4-2"));

        [TestMethod]
        public void TestMultiplicationNineTimesFive() => 
            Assert.AreEqual("45", CalculateExpression.Calculate("9*5"));

        [TestMethod]
        public void TestDivisionNineByThree() => 
            Assert.AreEqual("3", CalculateExpression.Calculate("9/3"));

        [TestMethod]
        public void TestOperationPriorityTwoPlusTwoTimesTwo() => 
            Assert.AreEqual("6", CalculateExpression.Calculate("2+2*2"));

        [TestMethod]
        public void TestOperationPriorityTwoPlusTwoTimesTwoWithParanthesis() => 
            Assert.AreEqual("8", CalculateExpression.Calculate("(2+2)*2"));

        [TestMethod]
        public void TestCalculationWithDifferentOperations() => 
            Assert.AreEqual("693", CalculateExpression.Calculate("33*22-33"));

        [TestMethod]
        public void TestComplexEquationWithAllOperations() => 
            Assert.AreEqual("24", CalculateExpression.Calculate("(2+2*2-2/2)*4+6-2"));

        [TestMethod]
        [ExpectedException(typeof(SyntaxErrorException))]
        public void TestWrongEquation() => 
            CalculateExpression.Calculate("(2+4-5");

        // Converting to RPN

        [TestMethod]
        public void TestConvertingToRpnWithoutParanthesis() =>
            Assert.AreEqual("2 2 2 * +", CalculateExpression.ConvertToRPN("2+2*2"));

        [TestMethod]
        public void TestConvertingToRpnWithParanthesis() =>
            Assert.AreEqual("2 2 + 2 *", CalculateExpression.ConvertToRPN("(2+2)*2"));

        [TestMethod]
        public void TestConvertingToRpnMoreComplexFormula() =>
            Assert.AreEqual("2 2 2 * + 2 2 / - 4 * 6 + 2 -", CalculateExpression.ConvertToRPN("(2+2*2-2/2)*4+6-2"));
    }
}
