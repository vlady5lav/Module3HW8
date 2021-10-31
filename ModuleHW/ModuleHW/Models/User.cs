using System;
using System.ComponentModel.DataAnnotations;

using CsvHelper.Configuration.Attributes;

namespace ModuleHW
{
    public class User
    {
        public User()
        {
        }

        [Required]
        [Range(0, int.MaxValue)]
        [Name("id")]
        public int Id { get; init; }
        [Required]
        [StringLength(60, MinimumLength = 2)]
        [Name("name")]
        public string Name { get; init; }
        [Required]
        [Name("gender")]
        public Gender Gender { get; init; }
        [Required]
        [Range(1, 120)]
        [Name("age")]
        public int Age { get; init; }
    }
}
