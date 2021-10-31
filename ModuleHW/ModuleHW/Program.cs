using System.Threading.Tasks;

namespace ModuleHW
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var starter = new Starter();
            await starter.RunAsync();
        }
    }
}
