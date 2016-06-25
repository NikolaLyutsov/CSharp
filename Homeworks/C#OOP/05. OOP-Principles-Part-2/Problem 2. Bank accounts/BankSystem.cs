using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Bank_accounts
{
    class BankSystem
    {
        static void Main()
        {
            Console.WriteLine("Deposit Account: ");

            var depositAcc = new deposit_acounts(new Individual("Gosho Goshev", 170, new DateTime(1892, 7, 14), Gender.male), 200000, 4);
            Console.WriteLine(depositAcc.ToString());
            depositAcc.AddMoney(1400);
            depositAcc.WithdrawMoney(213);

            Console.WriteLine("{0} Interest amount: {1}%", depositAcc.GetType().Name, depositAcc.InterestAmount(8)); 

            Console.WriteLine(new string('-', 50));

            var companyDeposit = new deposit_acounts(new Company("Apple", 90000, "Steve Jobs"), 84735216508, 260);
            Console.WriteLine(companyDeposit.ToString());

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Loan Deposit: ");
            var loanDeposit = new loan_accounts(new Individual("Martin Hristov", 90, new DateTime(1987, 3, 19), Gender.male), 1800, 3);
            Console.WriteLine(loanDeposit.ToString());
            Console.WriteLine("Interest amount {0}%", loanDeposit.InterestAmount(12));
            loanDeposit.AddMoney(1900);

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Mortgage Deposit");
            var mortgageAcc = new mortgage_accounts(new Company("Telerik", 4583262, "Georgi Georgiev"), 3470000, 0.3m);
            Console.WriteLine(mortgageAcc.ToString());
            Console.WriteLine("Interest amount {0}%", mortgageAcc.InterestAmount(12));
        }
    }
}
