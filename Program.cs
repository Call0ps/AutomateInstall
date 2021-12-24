// See https://aka.ms/new-console-template for more information
using AutomateInstall;

Console.WriteLine("Hello, World!");
var currentDir = Directory.GetCurrentDirectory();
string inputFile = currentDir + "\\input.csv";
StringsAndStuff pathHandler = new(inputFile);
DownloadStuff downloadHander = new(pathHandler.GetDownloads);
downloadHander.Run();
Installer.RunInstallation(currentDir);
