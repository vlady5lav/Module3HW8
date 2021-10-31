using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using CsvHelper;
using CsvHelper.Configuration;

namespace ModuleHW
{
    public class FileProcessor : IFileProcessor
    {
        private readonly CsvConfiguration _csvConfig;

        public FileProcessor()
        {
            _csvConfig = new CsvConfiguration(CultureInfo.GetCultureInfo("en"))
            {
                HasHeaderRecord = true,
                Comment = '#',
                AllowComments = true,
                Delimiter = ";",
            };
        }

        public async Task<IList<T>> ReadCollectionAsync<T>(string path)
        {
            try
            {
                if (path == null || string.IsNullOrWhiteSpace(path))
                {
                    Console.WriteLine($"Path \"{path}\" is null or empty!");
                    return null;
                }

                using var streamReader = new StreamReader(path);
                using var csvReader = new CsvReader(streamReader, _csvConfig);
                return await csvReader.GetRecordsAsync<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task WriteCollectionAsync<T>(string path, IList<T> collection)
        {
            try
            {
                if (path == null || path == default || string.IsNullOrWhiteSpace(path))
                {
                    Console.WriteLine($"Path \"{path}\" is null or empty!");
                    return;
                }

                if (collection == null || collection == default)
                {
                    Console.WriteLine($"Collection is null or empty!");
                    return;
                }

                using var streamWriter = new StreamWriter(path);
                using var csvWriter = new CsvWriter(streamWriter, _csvConfig);
                await csvWriter.WriteRecordsAsync<T>(collection);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
