using System;

namespace ModuleHW
{
    public class Account
    {
        public Account(string name, Balance balance)
        {
            Name = name;
            Balance = balance;
            Id = Guid.NewGuid();
        }

        public string Name { get; init; }

        public Balance Balance { get; init; }

        public Guid Id { get; init; }
    }
}
