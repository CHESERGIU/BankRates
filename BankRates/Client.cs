using System;

namespace BankRates
{
    public class Client
    {
        readonly int month = 1;
        readonly int months = 12;
        readonly string name;
        readonly Loan loan;

        public Client(string name, Loan loan)
        {
            this.name = name;
            this.loan = loan;
        }

        public decimal Debt(int month)
        {
            return loan.Principal() + (loan.Balance(month) * loan.Interest(month) / months);
        }

        public void Loan(Loan loan)
        {
            if (loan == null)
            {
                return;
            }

            decimal debt = loan.Principal() + (loan.Balance(month) * loan.Interest(month) / months);
        }

        public override string ToString() => name;
    }
}
