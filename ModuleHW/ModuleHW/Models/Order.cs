using System;
using System.ComponentModel.DataAnnotations;

using CsvHelper.Configuration.Attributes;

namespace ModuleHW
{
    public class Order
    {
        public Order()
        {
        }

        [Required]
        [Range(0, int.MaxValue)]
        [Name("id")]
        public int Id { get; init; }
        [Required]
        [Range(0, int.MaxValue)]
        [Name("user_id")]
        public int UserId { get; init; }
        [Required]
        [Range(0, int.MaxValue)]
        [Name("order_number")]
        public int OrderNumber { get; init; }
        [Required]
        [Format("yyyy-MM-dd")]
        [Name("order_date")]
        public DateTime OrderDate { get; init; }
        [Required]
        [Range(0, int.MaxValue)]
        [Name("total")]
        public decimal Total { get; init; }
    }
}
