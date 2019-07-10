using System;

namespace BankRates
{
    public class Client
    {
        readonly int months = 12;
        readonly string name;
        Loan[] loans;

        public Client(string name)
        {
            this.name = name;
        }

        public decimal Debt(int month, ref Loan loan)
        {
            return loan.Principal() + (loan.Balance(month) * loan.Interest(month) / months);
        }

        public void Loan(Loan loan)
        {
            Array.Resize(ref loans, loans.Length + 1);
            this.loans[loans.Length - 1] = loan;
        }

        public override string ToString() => name;
    }
}
