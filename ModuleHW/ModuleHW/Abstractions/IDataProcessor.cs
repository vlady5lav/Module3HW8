using System.Collections.Generic;

namespace ModuleHW
{
    public interface IDataProcessor
    {
        IList<Result> JoinFilteredCollectionsAsync(IList<User> users, IList<Order> orders);
    }
}