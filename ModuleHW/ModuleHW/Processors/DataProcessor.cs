using System;
using System.Collections.Generic;
using System.Linq;

namespace ModuleHW
{
    public class DataProcessor : IDataProcessor
    {
        public DataProcessor()
        {
        }

        public IList<Result> JoinFilteredCollectionsAsync(IList<User> users, IList<Order> orders)
        {
            try
            {
                return users
                    .Where(u => u.Age >= 18 && u.Age <= 65)
                    .Join(
                    orders.Where(o => o.OrderDate >= DateTime.Today.AddDays(-7)),
                    u => u.Id,
                    o => o.UserId,
                    (u, o) => new Result
                    {
                        OrderNumber = o.OrderNumber,
                        OrderDate = o.OrderDate,
                        UserName = u.Name,
                        Total = o.Total,
                    })
                    .OrderByDescending(x => x.OrderDate)
                    .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
