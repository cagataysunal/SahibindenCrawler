
namespace SahibindenWebScraper.Domain
{
    internal interface IAdvertScraper : IScraper
    {
        Advert GetAdvertData(string url);
        List<string> GetAdvertLinks();
    }
}