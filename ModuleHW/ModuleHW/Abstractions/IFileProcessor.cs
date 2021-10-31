using System.Collections.Generic;
using System.Threading.Tasks;

namespace ModuleHW
{
    public interface IFileProcessor
    {
        Task<IList<T>> ReadCollectionAsync<T>(string path);
        Task WriteCollectionAsync<T>(string path, IList<T> collection);
    }
}