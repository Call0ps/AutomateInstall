// See https://aka.ms/new-console-template for more information
using System.Net.Http;
namespace AutomateInstall;
internal class DownloadStuff
{
    HttpClient httpClient = new();
    List<Downloads> dls;
    public DownloadStuff(List<Downloads> downloads)
    {
        dls = downloads;
    }
    public async Task Run()
    {
        foreach (var dl in dls)
        {
            Uri uri = new(dl.Uri);
            using var stream = await httpClient.GetStreamAsync(uri.AbsoluteUri);
            using var fs = new FileStream(uri.Segments.Last(), FileMode.CreateNew);
            await stream.CopyToAsync(fs);
        }
    }

}