using System;

namespace BankRates
{
    public static class Program
    {
        public static void Main()
        {
            var client = CalculateBankRate(200, 2, 12, 1);

            var jhon1 = new Loan(1000, 18, 6);
            var jhon2 = new Loan(2000, 18, 5);

            var jhon = new Client("Jhonny");

            jhon.Loan(jhon1);
            jhon.Loan(jhon2);

            decimal actual = jhon.Debt(1);

            Console.WriteLine(actual);
            Console.ReadLine();
        }

        public static decimal CalculateBankRate(decimal total, int periodInMonth, decimal interestPerYear, int currentMonth)
        {
            decimal principal = total / periodInMonth;
            decimal exactInterestPerMonth = interestPerYear / 12 / 100;
            decimal sold = total - ((currentMonth - 1) * principal);
            return principal + (sold * exactInterestPerMonth);
        }
    }
}
