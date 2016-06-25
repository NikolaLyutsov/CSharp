namespace Problem_2.Bank_accounts
{
    using System;

    public class loan_accounts : Account, IDepositable
    {
        public loan_accounts(Customer customer, decimal bankBalance, decimal interestRate)
            : base(customer, bankBalance, interestRate)
        {

        }

        public override decimal InterestAmount(int months)
        {
            decimal interestAmount = 0.00M;

            if (this.Customer is Individual && months >= 2)
            {
                interestAmount = this.InterestRate / 100 * (months - 2);
            }
            else if (this.Customer is Company && months >= 3)
            {
                interestAmount = this.InterestRate / 100 * (months - 2);
            }
            return interestAmount;
        }
        public void AddMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("You cannot deposit a negative number !!");
            }
            if (this.BankBalance < amount)
            {
                Console.WriteLine("You have paid your loan !!");
                this.BankBalance = 0;
            }
            else
            {
                this.BankBalance -= amount;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
