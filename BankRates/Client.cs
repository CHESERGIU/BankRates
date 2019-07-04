using System;

namespace BankRates
{
    public class Client
    {
        const int MonthInAYear = 12;
        const int Procent = 100;

        private readonly int currentMonth;
        private readonly decimal interestPerYear;
        private readonly int periodInMonth;
        private readonly decimal total;

        public Client(decimal total, int periodInMonth, decimal interestPerYear, int currentMonth)
        {
            this.currentMonth = currentMonth;
            this.interestPerYear = interestPerYear;
            this.periodInMonth = periodInMonth;
            this.total = total;
        }

        public int CurrentMonth => currentMonth;

        public decimal InterestPerYear => interestPerYear;

        public int PeriodInMonth => periodInMonth;

        public decimal Total => total;

        public decimal ExactInterestPerMonth()
        {
            return InterestPerYear / MonthInAYear / Procent;
        }

        public decimal Principal()
        {
            return Total / PeriodInMonth;
        }

        public decimal Rate()
        {
            return Principal() + (Sold() * ExactInterestPerMonth());
        }

        public decimal Sold()
        {
            return Total - ((CurrentMonth - 1) * Principal());
        }
    }
}
