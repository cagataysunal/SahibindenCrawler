using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahibindenWebScraper.Domain
{
    internal class AdvertScraper : IAdvertScraper
    {
        private readonly string _homeUrl;
        public AdvertScraper() { _homeUrl = "https://www.sahibinden.com/"; }

        public Task<string> DownloadHtmlAsync(string url)
        {
            throw new NotImplementedException();
        }

        public Advert GetAdvertData(string url)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAdvertLinks()
        {
            throw new NotImplementedException();
        }
    }
}
