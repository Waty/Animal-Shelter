using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using CsvHelper;
using CsvHelper.Configuration;

namespace CsvToXml
{
    public class Player
    {
        public string Name { get; set; }
        public string Bankroll { get; set; }
        public string Makeup { get; set; }
    }

    public sealed class PlayerMap : CsvClassMap<Player>
    {
        public PlayerMap()
        {
            Map(m => m.Name).Index(0);
            Map(m => m.Bankroll).Index(1);
            Map(m => m.Makeup).Index(2);
        }
    }

    public class Program
    {
        private static void Main()
        {
            var csv = new CsvReader(new StringReader(Properties.Resources.Players));
            csv.Configuration.RegisterClassMap<PlayerMap>();

            var serializer = new XmlSerializer(typeof (List<Player>));
            serializer.Serialize(File.Create(@"Players.xml"), csv.GetRecords<Player>().ToList());

            Console.WriteLine("Sucessfully converted the csv to xml\nPress any key to continue");
            Console.ReadKey();
        }
    }
}