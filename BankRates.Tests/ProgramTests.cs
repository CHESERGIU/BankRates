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
            Loan jhon1 = new Loan(1000, 18, 6);
            Loan jhon2 = new Loan(2000, 18, 5);
            var client = new Client("Jhon", jhon1);
            var client1 = new Client("Jhon", jhon2);
            decimal actual = client.Debt(1) + client1.Debt(1); // Debt(1) for 1 month on 2 loans

            Assert.Equal(180, actual);
        }

        [Fact]
        public void CalculateRateForOneYear()
        {
            Loan mary = new Loan(1000, 1, 12);
            var client = new Client("Mary", mary);
            decimal actual = client.Debt(1);
            decimal actual1 = mary.Interest(1);
            decimal actual2 = mary.Principal();
            decimal actual3 = mary.Balance(1);

            Assert.Equal(0.12.ToString(), actual1.ToString());
            Assert.Equal(1000, actual2);
            Assert.Equal(1000, actual3);
            Assert.Equal(1010, actual);
        }
    }
}
