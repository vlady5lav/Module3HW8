namespace ModuleHW
{
    public interface IAccountService
    {
        void Add(decimal sum);
        void GetBalance();
        void Withdraw(decimal sum);
    }
}