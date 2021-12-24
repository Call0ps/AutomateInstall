namespace AutomateInstall;
using System.Diagnostics;
public static class Installer
{
    public static void RunInstallation(string path)
    {
        Directory.SetCurrentDirectory(path);
        var objs = Directory.EnumerateFiles(Directory.GetCurrentDirectory());
        foreach (var obj in objs)
        {
            try
            {
                using Process process = new Process();
                process.StartInfo.FileName = obj;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
                throw;
            }
        }

    }
}