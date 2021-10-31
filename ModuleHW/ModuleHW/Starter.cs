using Microsoft.Extensions.DependencyInjection;

namespace ModuleHW
{
    public class Starter
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IAccountService, AccountService>()
                .AddTransient<Application>()
                .BuildServiceProvider();

            var application = serviceProvider.GetService<Application>();

            application.Start();
        }
    }
}
