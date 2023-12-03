using SahibindenWebScraper.Domain;

//Create the file and name it the current time
DateTime now = DateTime.Now;
string filePath = $"sahibinden_{now.Year}{now.Month}{now.Day}{now.Hour}{now.Minute}{now.Second}.txt";
//Ensure that resources are released after creating the file
using (File.Create(filePath)) { } 

IAdvertScraper scraper = new AdvertScraper();

List<string> advertLinks = scraper.GetAdvertLinks();

foreach (var url in advertLinks)
{
    Advert advert = scraper.GetAdvertData(url);
    //Write to console and append the line to the file
    Console.WriteLine(advert);
    File.AppendAllText(filePath, advert + Environment.NewLine);
}

Console.WriteLine("Press enter to exit...");
Console.ReadLine();