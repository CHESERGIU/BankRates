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
            // Given
            var client = new Client("Jhonny");

            Loan firstLoan = new Loan(1000, 18, 6);
            Loan secondLoan = new Loan(2000, 18, 5);

            client.Loan(firstLoan);
            client.Loan(secondLoan);

            // When
            decimal actual = client.Debt(1);

            decimal expected = firstLoan.TotalInterest(1) + secondLoan.TotalInterest(1);

            // Then
            Assert.Equal(expected, actual);
        }
    }
}
