using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace NoteBook
{
    public class CSVAddressBookFile
    {
        /// <summary>
        /// UC15-Iplements the Json program.
        /// </summary>

        public void IplementCsvProgram()
        {
            string importFilePath = @"F:\NoteBook\AddressBookData.csv";
           // string exportFilePath = @"F:\NoteBook\ExportAddress.csv";
            string exportFilePath = @"F:\NoteBook\DataAdress.json";
            using(var reader=new StreamReader(importFilePath))
            using(var csv=new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressBookData>().ToList();
                Console.WriteLine("Read data from csv address file");

                foreach(AddressBookData address in records)
                {
                    Console.WriteLine(address.name);
                    Console.WriteLine(address.lastname);
                    Console.WriteLine(address.address);
                    Console.WriteLine(address.city);
                    Console.WriteLine(address.state);
                    Console.WriteLine(address.zip);
                    Console.WriteLine(address.gmail);

                }
                Console.WriteLine("Writing to The file");

                using (var writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }

            }
        }
    }
}
