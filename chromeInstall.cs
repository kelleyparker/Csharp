using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string downloadUrl = "https://dl.google.com/dl/chrome/install/googlechromestandaloneenterprise64.msi";
        string downloadPath = "chrome_installer.msi";
        string installCommand = "/i chrome_installer.msi /quiet";

        Console.WriteLine("This script downloads and silently installs Google Chrome.");

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            Console.WriteLine("Detected Windows OS.");

            // Download the MSI installer
            using (var client = new WebClient())
            {
                Console.WriteLine("Downloading Google Chrome installer...");
                client.DownloadFile(downloadUrl, downloadPath);
                Console.WriteLine("Download completed.");
            }

            // Install Google Chrome silently
            Console.WriteLine("Installing Google Chrome...");
            var process = Process.Start("msiexec", installCommand);
            process.WaitForExit();
            Console.WriteLine("Installation completed.");

            // Clean up the downloaded installer
            File.Delete(downloadPath);
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            Console.WriteLine("Detected macOS.");
            Console.WriteLine("Please download and install Google Chrome manually for macOS.");
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            string packageManager = GetLinuxPackageManager();

            if (packageManager == "apt")
            {
                Console.WriteLine("Detected Ubuntu or Debian-based Linux distribution.");
                Console.WriteLine("Please use the package manager to install Google Chrome.");
            }
            else if (packageManager == "yum")
            {
                Console.WriteLine("Detected CentOS, RHEL, or Fedora-based Linux distribution.");
                Console.WriteLine("Please use the package manager to install Google Chrome.");
            }
            else
            {
                Console.WriteLine("Unsupported Linux distribution. Please install Google Chrome manually.");
            }
        }
        else
        {
            Console.WriteLine("Unsupported operating system. Please install Google Chrome manually.");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    static string GetLinuxPackageManager()
    {
        string packageManager = string.Empty;

        if (File.Exists("/usr/bin/apt-get"))
        {
            packageManager = "apt";
        }
        else if (File.Exists("/usr/bin/yum"))
        {
            packageManager = "yum";
        }

        return packageManager;
    }
}
