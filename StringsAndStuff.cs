// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic.FileIO;
namespace AutomateInstall;
internal class StringsAndStuff
{
    public List<Downloads> GetDownloads { get { return DownloadsList; } }
    private readonly List<Downloads> DownloadsList;
    public StringsAndStuff(string input)
    {
        DownloadsList = new();
        GenerateLists(input);
    }
    private void GenerateLists(string input)
    {
        using TextFieldParser parser = new(input);
        parser.Delimiters = new string[] { "," };
        parser.HasFieldsEnclosedInQuotes = true;
        parser.ReadLine();

        while (!parser.EndOfData)
        {
            string[] data = parser.ReadFields();
            if (data != null)
            {
                DownloadsList.Add(new Downloads(data[0], data[1]));
            }
        }
    }
}