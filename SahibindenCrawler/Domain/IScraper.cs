namespace SahibindenWebScraper.Domain
{
    internal interface IScraper
    {
        public Task<string> DownloadHtmlAsync(string url);
    }
}