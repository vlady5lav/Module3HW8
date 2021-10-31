using System;
using System.ComponentModel.DataAnnotations;

using CsvHelper.Configuration.Attributes;

namespace ModuleHW
{
    public class Result
    {
        public Result()
        {
        }

        [Required]
        [Range(0, int.MaxValue)]
        [Name("order_number")]
        public int OrderNumber { get; init; }
        [Required]
        [Format("yyyy-MM-dd")]
        [Name("order_date")]
        public DateTime OrderDate { get; init; }
        [Required]
        [StringLength(60, MinimumLength = 2)]
        [Name("user_name")]
        public string UserName { get; init; }
        [Required]
        [Range(0, int.MaxValue)]
        [Name("total")]
        public decimal Total { get; init; }
    }
}
