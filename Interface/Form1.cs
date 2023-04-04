using Interface.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;
using System.Linq;

namespace Interface
{
    public partial class Form1 : Form
    {
        AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
        ConfigurationBuilder builder = new ConfigurationBuilder();
        List<Card> currentlist = new List<Card>();
        List<Card> allcards = new List<Card>();
        List<string> allsets = new List<string>();
        string? url = "";
        public Form1()
        {
            InitializeComponent();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();
            url = config["ConnectionString:CardsURL"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CSV_Reader reader = new CSV_Reader();

            allcards = reader.GetAllCards();
            allsets = GetAllSets();

            foreach (Card card in allcards)
            {
                collection.Add(card.Name);
            }


            srch_txtbox.AutoCompleteMode = AutoCompleteMode.Suggest;
            srch_txtbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void srch_txtbox_TextChanged(object sender, EventArgs e)
        {
            TextBox? t = sender as TextBox;

            if (t.Text.Length >= 1)
            {
                srch_txtbox.AutoCompleteCustomSource = collection;
            }
        }

        private void load_btn_Click(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(srch_txtbox.Text))
            {
                if (allcards.Find(r => r.Name == srch_txtbox.Text) != null)
                {
                    Card? card = new Card();

                    var info = allcards.Find(r => r.Name == srch_txtbox.Text);

                    card.Name = info.Name;
                    card.Colors = info.Colors;
                    card.Printings = info.Printings;
                    card.Cost = info.Cost;
                    card.Type = info.Type;

                    var cardlinks = GetSetForSpecificCard(card.Name);

                    var keys = new List<string>(cardlinks.Keys);

                    RequestQuantSet request = new RequestQuantSet(keys);
                    var QuantSet = request.RunQuantSet();

                    if (currentlist.Find(r => r.Name == srch_txtbox.Text && r.Set == request.finalset) == null)
                    {
                        //When the card does not exist in the list yet
                        if (!string.IsNullOrEmpty(request.finalquant) && !string.IsNullOrEmpty(request.finalset))
                        {

                            if (int.TryParse(request.finalquant, out _))
                            {
                                card.Quant = QuantSet.Item1;
                                card.Set = QuantSet.Item2;

                                var page = "";
                                cardlinks.TryGetValue(request.finalset, out page);

                                var html = CallUrl($@"{url}{page}");
                                card.Price = html.Result;

                                currentlist.Add(card);
                                cardBindingSource.Add(card);
                            }
                            else
                            {
                                MessageBox.Show("Quantity specified is not a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Card already in the inventory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Name not in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {

        }

        private void del_btn_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }

        private void new_btn_Click(object sender, EventArgs e)
        {

        }

        private static async Task<string> CallUrl(string fullUrl)
        {
            HtmlWeb web = new HtmlWeb();

            var doc = web.Load(fullUrl);

            var nodes = doc.DocumentNode.SelectNodes("/html/body/main/div[4]/section[2]/div/div[2]/div[1]/div/div[2]/div/div[2]/dl/dd[7]/span");
            if (nodes == null) 
            {
                nodes = doc.DocumentNode.SelectNodes("/html/body/main/div[4]/section[2]/div/div[2]/div[1]/div/div[1]/div/div[2]/dl/dd[6]/span");
            }
            
            foreach(var node in nodes)
            {
                return node.InnerText;
            }

            return "";
        }

        private static List<string> GetAllSets()
        {
            var list = new List<string>();

            HtmlWeb web = new HtmlWeb();

            var cardmarket = web.Load(@"https://www.cardmarket.com/en/Magic/Products/Singles");

            var cmsets = cardmarket.DocumentNode.SelectNodes("/html/body/main/section/div[1]/form/div[2]/select/option[position()>1]");
            foreach (var set in cmsets)
            {
                list.Add(set.InnerText);
            }
            return list;
        }

        private static Dictionary<string, string> GetSetForSpecificCard(string cardname)
        {
            var cardlinks = new Dictionary<string, string>();
            string key = "";
            string value = "";

            var list = new List<string>();
            cardname = cardname.Replace(",", "");
            cardname = cardname.Replace("-", "+");
            cardname = cardname.Replace(" ", "+");

            HtmlWeb web = new HtmlWeb();

            var search = web.Load(@$"https://www.cardmarket.com/en/Magic/Products/Search?searchString={cardname}");

            var vers = search.DocumentNode.SelectNodes("/html/body/main/section/div[3]/div[2]/div[position()>0]");

            for(int i = 0; i < vers.Count; i++)
            {
                var cardpag = search.DocumentNode.SelectNodes(@$"/html/body/main/section/div[3]/div[2]/div[{i+1}]/div[4]/div[1]/div[1]/a[1]");
                var setname = search.DocumentNode.SelectNodes(@$"/html/body/main/section/div[3]/div[2]/div[{i+1}]/div[3]/a[1]");

                foreach (var node in setname)
                {
                    key = node.Attributes["title"].Value;
                    
                }

                foreach (var node in cardpag)
                {
                    value = node.Attributes["href"].Value;
                }
                if (!cardlinks.ContainsKey(key))
                {
                    cardlinks.Add(key, value);
                }
            }

            return cardlinks;
        }
    }
}