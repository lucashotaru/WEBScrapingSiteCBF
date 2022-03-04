using CBFWebScraping.DTOs;
using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace CBFWebScraping
{
    public class CsvHelper
    {
        public static string SaveCBFInfo(List<CBFInfoDTO> lista)
        {
            string folderName = "results";
            string fileName = "cbfInfo.csv";
            var filePath = $"{folderName}\\{fileName}";

            if(File.Exists(filePath) is false)
            {
                Directory.CreateDirectory(folderName);
                File.Create(filePath).Dispose();
            }

            using (var stream = File.OpenWrite(filePath))
            using (var writer = new StreamWriter(stream, Encoding.UTF8))
            using (var csv = new CsvWriter(writer,
                new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" }))
            {
                csv.WriteHeader<CBFInfoDTO>();
                csv.NextRecord();
                csv.WriteRecords(lista);
            }

            return Path.GetFullPath(filePath);
        }
    }
}
