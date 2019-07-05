using System;
using System.Collections.Generic;
using System.Text;

namespace BankRates
{
    public class Loan
    {
        const int Hundred = 100;
        readonly decimal sum;
        readonly int periodInMonth;
        readonly decimal interestPerYear;

        public Loan(decimal sum, int periodInMonth, decimal interestPerYear)
        {
            this.interestPerYear = interestPerYear;
            this.periodInMonth = periodInMonth;
            this.sum = sum;
        }

        public decimal Interest(int month) // exact Interest Per Month
        {
            return interestPerYear / month / Hundred;
        }

        public decimal Principal() // bank rate per month without interest
        {
            return sum / periodInMonth;
        }
    }
}
