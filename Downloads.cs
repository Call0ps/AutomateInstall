// See https://aka.ms/new-console-template for more information
namespace AutomateInstall;
public class Downloads
{
    public string Uri { get; set; }
    public string Name { get; set; }
    public Downloads(string uri, string name)
    {
        Name = name;
        Uri = uri;
    }
}