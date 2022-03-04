using System;

namespace CBFWebScraping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cbf = new CBFWebScraping();

            var cbfInfo = cbf.GetCBFInfo();
            var filePath = CsvHelper.SaveCBFInfo(cbfInfo);
        }
    }
}
