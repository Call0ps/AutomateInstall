namespace AutomateInstall;
using System.Diagnostics;
using System.Linq;
public static class Installer
{
    public static void RunInstallation(string path)
    {
        Directory.SetCurrentDirectory(path);
        var objs = Directory.EnumerateFiles(Directory.GetCurrentDirectory()).Where(f => f.Contains(".exe"));
        foreach (var obj in objs)
        {
            try
            {
                using Process process = new Process();
                process.StartInfo.FileName = obj;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.WaitForExit();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
                throw;
            }
        }

    }
}