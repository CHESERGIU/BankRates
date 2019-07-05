using System;

namespace BankRates
{
    public static class Program
    {
        public static void Main()
        {
            var client = CalculateBankRate(200, 2, 12, 1);

            var client1 = new Client("Jhon");
            Loan jhon = new Loan(200, 2, 12);
            var actual = client1.Loan(jhon);
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
