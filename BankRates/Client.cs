using System;

namespace BankRates
{
    public class Client
    {
        readonly string name;
        readonly int month = 12;

        public Client(string name)
        {
            this.name = name;
        }

        public decimal Loan(Loan loan)
        {
            if (loan == null)
            {
                return 0m;
            }

            decimal principal = loan.Principal();
            decimal exactInterestPerMonth = loan.Interest(month);
            decimal sold = (principal * month) - ((month - 1) * principal);
            return principal + (sold * exactInterestPerMonth);
        }

        public override string ToString() => name;
    }
}
