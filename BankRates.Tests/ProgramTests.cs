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
            var client = new Client("Jhon");
            Loan jhon = new Loan(200, 2, 12);
            var actual = client.Loan(jhon);

            Assert.Equal(101, actual);
        }

        [Fact]
        public void CalculateRateForOneYear()
        {
            var client = new Client("Mary");
            Loan mary = new Loan(1000, 1, 12);
            var actual = client.Loan(mary);

            Assert.Equal(1010, actual);
        }
    }
}
