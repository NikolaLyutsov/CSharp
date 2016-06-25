namespace Problem_2.Bank_accounts
{
    using System;

    public abstract class Account
    {
        private Customer customer;
        private decimal bankBalance;
        private decimal interestRate;

        public Account(Customer customer, decimal bankBalance, decimal interestRate)
        {
            this.Customer = customer;
            this.BankBalance = bankBalance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; private set; }

        public decimal BankBalance
        {
            get
            {
                return this.bankBalance;
            }
             set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Must be a positive number!");
                }
                else
                {
                    this.bankBalance = value;
                }
            }
        }
        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Must be a positive number!!");
                }
                else
                {
                    this.interestRate = value;
                }
            }
        }
        public abstract decimal InterestAmount(int months);

        public override string ToString()
        {
            return string.Format("{0} owner: {1}\n\rBalance: {2:C}\n\rInterest Rate: {3}%", GetType().Name, this.Customer, this.bankBalance, this.InterestRate);
        }
    }
}
