using System;

namespace ModuleHW
{
    public class Balance
    {
        public Balance(decimal sum)
        {
            Sum = sum;
        }

        public delegate void Notify(decimal sum);

        public event Notify OnAdd;

        public event Notify OnWithdraw;

        public decimal Sum { get; set; }

        public void Add(decimal sum)
        {
            if (sum <= 0)
            {
                Console.WriteLine($"You can't add sum that is less or equal to zero!");
                return;
            }

            Sum += sum;

            OnAdd?.Invoke(sum);
        }

        public void Withdraw(decimal sum)
        {
            if (sum <= 0)
            {
                Console.WriteLine($"You can't withdraw sum that is less or equal to zero!");
                return;
            }

            if (Sum >= sum)
            {
                Sum -= sum;
                OnWithdraw?.Invoke(sum);
            }
            else
            {
                Console.WriteLine($"You can't withdraw sum that is more than your balance!");
                return;
            }
        }
    }
}
