using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

namespace ModuleHW
{
    public class Starter
    {
        public Starter()
        {
        }

        public async Task RunAsync()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IDataProcessor, DataProcessor>()
                .AddTransient<IFileProcessor, FileProcessor>()
                .AddTransient<Application>()
                .BuildServiceProvider();

            var application = serviceProvider.GetService<Application>();

            await application.StartAppAsync();
        }
    }
}
