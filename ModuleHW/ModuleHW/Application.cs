using System;

namespace ModuleHW
{
    public class Application
    {
        public void Start()
        {
            var account = new Account("Vladyslav Shevchenko", new Balance(5));
            var accountService = new AccountService(account);

            accountService.Withdraw(150);
            accountService.GetBalance();
            accountService.Add(50);
            accountService.GetBalance();
            accountService.Withdraw(100);
            accountService.GetBalance();
            accountService.Add(150);
            accountService.GetBalance();
            accountService.Withdraw(195);
            accountService.GetBalance();
            accountService.Withdraw(10);
            accountService.GetBalance();
            Console.Read();
        }
    }
}
