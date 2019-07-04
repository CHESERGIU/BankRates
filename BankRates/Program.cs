using System;

namespace BankRates
{
    public static class Program
    {
        public static void Main()
        {
            var client = CalculateBankRate(200, 2, 12, 1);

            var client1 = new Client(200, 2, 12, 1);
            var actual = client1.Rate();
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
