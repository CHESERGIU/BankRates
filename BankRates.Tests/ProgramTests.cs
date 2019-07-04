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

        [Fact]
        public void CalculateRateForFirstMonthWithClassClient()
        {
            var client = new Client(200, 2, 12, 1);

            var principal = client.Principal();
            var sold = client.Sold();
            var rate = client.Rate();
            Assert.Equal(100, principal);
            Assert.Equal(200, sold);
            Assert.Equal(102, rate);
        }
    }
}
