using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using Interface.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace Interface
{
    public class CSV_Reader
    {

        ConfigurationBuilder builder = new ConfigurationBuilder();
        string? csv = "";
        public CSV_Reader() 
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();
            csv = config["ConnectionString:CSV"];
        }
        public List<Card> GetAllCards()
        {
            List<Card> cards;
            using (var streamReader = new StreamReader(@$"{csv}"))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    csvReader.Context.RegisterClassMap<CardMapper>();
                    cards = csvReader.GetRecords<Card>().ToList();
                }
            }
            return cards;
        }
    }

    public class CardMapper : ClassMap<Card>
    {
        public CardMapper() 
        {
            Map(m => m.Name).Name("name");
            Map(m => m.Colors).Name("colors");
            Map(m => m.Cost).Name("convertedManaCost");
            Map(m => m.Type).Name("type");
            Map(m => m.Printings).Name("printings");

        }
    }
}
