using System;

namespace BankRates
{
    public class Client
    {
        readonly string name;
        Loan[] loans;

        public Client(string name)
        {
            this.name = name;
            this.loans = new Loan[] { };
        }

        public decimal Debt(int month)
        {
            decimal debt = 0;
            for (int i = 0; i < loans.Length; i++)
            {
                debt += loans[i].TotalInterest(month);
            }

            return debt;
        }

        public void Loan(Loan loan)
        {
            Array.Resize(ref loans, loans.Length + 1);
            this.loans[loans.Length - 1] = loan;
        }

        public override string ToString() => name;
    }
}
