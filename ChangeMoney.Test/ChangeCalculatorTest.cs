using System;
using Xunit;
using ChangeMoney.Lib;

namespace ChangeMoney.Test
{
    public class ChangeCalculatorTest
    {
        private ChangeCalculator calculator;
        public ChangeCalculatorTest()
        {
            calculator = new ChangeCalculator();
        }

        [Theory]
        [InlineData(50, 100, 50, 0, 0, 0, 1)]
        [InlineData(50, 200, 150, 0, 0, 1, 1)]
        [InlineData(650, 1000, 350, 0, 0, 3, 1)]
        [InlineData(680, 1000, 320, 0, 0, 3, 0, 1)]
        [InlineData(665, 1000, 335, 0, 0, 3, 0, 1, 3)]
        [InlineData(661, 1000, 339, 0, 0, 3, 0, 1, 3, 4)]
        [InlineData(1202, 3000, 1798, 1, 1, 2, 1, 2, 1, 3)]
        public void ChangeCalculator_Successed(
            int amount,
            int pay,
            int expectedChange,
            int thousandAmount = 0,
            int fiveHundredAmount = 0,
            int hundredAmount = 0,
            int fiftyAmount = 0,
            int twentyAmount = 0,
            int fiveAmount = 0,
            int oneAmount = 0)
        {
            var result = calculator.Change(amount, pay);

            Assert.Equal(expectedChange, result.Change);
            Assert.Equal(thousandAmount, result.ThousandAmount);
            Assert.Equal(fiveHundredAmount, result.FiveHundredAmount);
            Assert.Equal(hundredAmount, result.OneHundredAmount);
            Assert.Equal(fiftyAmount, result.FiftyAmount);
            Assert.Equal(twentyAmount, result.TwentyAmount);
            Assert.Equal(fiveAmount, result.FiveAmount);
            Assert.Equal(oneAmount, result.OneAmount);
        }

        [Theory]
        [InlineData(200, 100)]
        [InlineData(400, 399)]
        [InlineData(70, 50)]
        public void ChangeCalculator_Failed(int amount, int pay)
        {
            var result = calculator.Change(amount, pay);
            Assert.Null(result);
        }
    }
}
