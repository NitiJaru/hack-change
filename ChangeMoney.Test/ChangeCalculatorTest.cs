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
    }
}
