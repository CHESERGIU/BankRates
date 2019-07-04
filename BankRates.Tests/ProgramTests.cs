using System;
using Xunit;

namespace BankRates.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void CalculateRateForFirstMonth()
        {
            decimal rate = Program.CalculateBankRate(200, 2, 12, 1);
            Assert.Equal(102, rate);
        }
    }
}
