namespace AutomateInstall;
using System.Diagnostics;
using System.Linq;
public static class Installer
{
    public static async Task RunInstallation(string path)
    {
        Directory.SetCurrentDirectory(path);
        var objs = Directory.EnumerateFiles(Directory.GetCurrentDirectory()).Where(f => f.Contains(".exe"));
        foreach (var obj in objs)
        {
            try
            {
                Console.WriteLine("Starting installation of {0}", obj);
                using Process process = new();
                process.StartInfo.FileName = obj;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                await process.WaitForExitAsync();
                Console.WriteLine("Finished installation of {0}", obj);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
                throw;
            }
        }

    }
}