using System;
using Xunit;
using ChangeMoney.Lib;

namespace ChangeMoney.Test
{
    public class ChangeCalculatorTest
    {
        [Fact]
        public void ChangeCalculator_Success_1()
        {
            var cal = new ChangeCalculator();
            var result = cal.Change(50, 100);

            Assert.Equal(50, result.Change);
            Assert.Equal(1, result.FiftyAmount);
        }

        [Fact]
        public void ChangeCalculator_Success_2()
        {
            var cal = new ChangeCalculator();
            var result = cal.Change(50, 200);

            Assert.Equal(150, result.Change);
            Assert.Equal(1, result.OneHundredAmount);
            Assert.Equal(1, result.FiftyAmount);
        }

        [Fact]
        public void ChangeCalculator_Success_3()
        {
            var cal = new ChangeCalculator();
            var result = cal.Change(650, 1000);

            Assert.Equal(350, result.Change);
            Assert.Equal(3, result.OneHundredAmount);
            Assert.Equal(1, result.FiftyAmount);
        }


        [Fact]
        public void ChangeCalculator_Success_4()
        {
            var cal = new ChangeCalculator();
            var result = cal.Change(680, 1000);

            Assert.Equal(320, result.Change);
            Assert.Equal(3, result.OneHundredAmount);
            Assert.Equal(0, result.FiftyAmount);
            Assert.Equal(1, result.TwentyAmount);
        }

        [Fact]
        public void ChangeCalculator_Success_5()
        {
            var cal = new ChangeCalculator();
            var result = cal.Change(665, 1000);

            Assert.Equal(335, result.Change);
            Assert.Equal(3, result.OneHundredAmount);
            Assert.Equal(0, result.FiftyAmount);
            Assert.Equal(1, result.TwentyAmount);
            Assert.Equal(3, result.FiveAmount);
        }

        [Fact]
        public void ChangeCalculator_Success_6()
        {
            var cal = new ChangeCalculator();
            var result = cal.Change(661, 1000);

            Assert.Equal(339, result.Change);
            Assert.Equal(3, result.OneHundredAmount);
            Assert.Equal(0, result.FiftyAmount);
            Assert.Equal(1, result.TwentyAmount);
            Assert.Equal(3, result.FiveAmount);
            Assert.Equal(4, result.OneAmount);
        }

        [Fact]
        public void ChangeCalculator_Success_7()
        {
            var cal = new ChangeCalculator();
            var result = cal.Change(1202, 3000);

            Assert.Equal(1798, result.Change);
            Assert.Equal(1, result.ThousandAmount);
            Assert.Equal(1, result.FiveHundredAmount);
            Assert.Equal(2, result.OneHundredAmount);
            Assert.Equal(1, result.FiftyAmount);
            Assert.Equal(2, result.TwentyAmount);
            Assert.Equal(1, result.FiveAmount);
            Assert.Equal(3, result.OneAmount);
        }

        [Fact]
        public void ChangeCalculator_Failed()
        {
            var cal = new ChangeCalculator();
            var result = cal.Change(200, 100);

            Assert.Null(result);
        }
    }
}
