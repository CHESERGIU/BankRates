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

        public decimal Interest(int month) // mary Interest Per Month = 12 / 1 / 100
        {
            return interestPerYear / month / Hundred;
        }

        public decimal Principal() // bank rate per month without interest = 1000 / 1
        {
            return sum / periodInMonth;
        }

        public decimal Balance(int month) // difference between the sum of debit entries and the sum of credit entries
        {
            return sum - ((month - 1) * Principal());
        }
    }
}
