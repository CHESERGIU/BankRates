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
        public void CalculateRateForFirstMonthWithClassLoans()
        {
            var client = new Client("Jhonny");

            Loan firstLoan = new Loan(1000, 18, 6);
            Loan secondLoan = new Loan(2000, 18, 5);

            decimal actual = client.Debt(1, ref firstLoan) + client.Debt(1, ref secondLoan);

            decimal expected = (firstLoan.Principal() + firstLoan.Balance(1) * firstLoan.Interest(1) / 12)
                + (secondLoan.Principal() + secondLoan.Balance(1) * secondLoan.Interest(1) / 12);

            Assert.Equal(expected, actual);
        }
    }
}
