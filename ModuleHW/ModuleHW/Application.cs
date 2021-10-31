using System;
using System.Threading.Tasks;

namespace ModuleHW
{
    public class Application
    {
        private readonly IFileProcessor _fileProcessor;
        private readonly IDataProcessor _dataProcessor;

        public Application(IFileProcessor fileProcessor, IDataProcessor dataProcessor)
        {
            _fileProcessor = fileProcessor;
            _dataProcessor = dataProcessor;
        }

        public async Task StartAppAsync()
        {
            try
            {
                var users = await _fileProcessor.ReadCollectionAsync<User>("users.txt");
                var orders = await _fileProcessor.ReadCollectionAsync<Order>("orders.txt");

                var result = _dataProcessor.JoinFilteredCollectionsAsync(users, orders);

                await _fileProcessor.WriteCollectionAsync<Result>("result.txt", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
