namespace Problem_2.Bank_accounts
{

    using System;

    public class mortgage_accounts : Account, IDepositable
    {
        public mortgage_accounts(Customer customer, decimal bankBalance, decimal interestRate)
            : base(customer, bankBalance, interestRate)
        {

        }
        
        public void AddMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("You cannot deposit a negative number !!");
            }
            if (this.BankBalance < amount)
            {
                Console.WriteLine("You have paid your mortgage !!");
                this.BankBalance = 0;
            }
            else
            {
                this.BankBalance -= amount;
            }
        }

        public override decimal InterestAmount(int months)
        {
            decimal interestAmount = 0.00m;

            if (Customer is Individual && months > 6)
            {
                interestAmount = this.InterestRate / 100 * (months - 6);
            }
            else if (Customer is Company && months <= 12)
            {
                interestAmount = (this.InterestRate / 100 * months) / 2;
            }
            else if (Customer is Company && months > 12)
            {
                interestAmount = this.InterestRate / 100 * (months - 12) + (this.InterestRate / 100 * 12) / 2;
            }
            return interestAmount;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
