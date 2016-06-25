namespace Problem_2.Bank_accounts
{
    using System;

    public class Company : Customer
    {
        private string companyManager;

        public Company(string name, long iDNumber, string companyManager)
       :base (name, iDNumber)
        {
            this.CompanyManager = companyManager;
        }

        public string CompanyManager
        {
            get
            {
                return this.companyManager;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Must enter some text!");
                }
                else
                {
                    this.companyManager = value;
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\n\rComapany manager: " + this.companyManager;
        }
    }
}
