// See https://aka.ms/new-console-template for more information
using AutomateInstall;

Console.WriteLine("Hello, World!");
await Run();

static async Task Run()
{
    var currentDir = Directory.GetCurrentDirectory();
    string inputFile = currentDir + "\\input.csv";
    Console.WriteLine("Running StringsAndStuff");
    StringsAndStuff pathHandler = new(inputFile);
    DownloadStuff downloadHander = new(pathHandler.GetDownloads);
    Console.WriteLine("Downloading files...");
    await downloadHander.Run();
    Console.WriteLine("Running installation!");
    await Installer.RunInstallation(currentDir);
}