using System;

namespace ModuleHW
{
    public class AccountService : IAccountService
    {
        private readonly Account _account;

        public AccountService(Account account)
        {
            _account = account;
            _account.Balance.OnAdd += sum => Console.WriteLine($"{sum} UAH credited to the account \"{_account.Name}\"");
            _account.Balance.OnWithdraw += sum => Console.WriteLine($"{sum} UAH withdrawn from the account \"{_account.Name}\"");
        }

        public void GetBalance()
        {
            Console.WriteLine($"Current balance: {_account.Balance.Sum} UAH.");
        }

        public void Add(decimal sum)
        {
            _account.Balance.Add(sum);
        }

        public void Withdraw(decimal sum)
        {
            _account.Balance.Withdraw(sum);
        }
    }
}
