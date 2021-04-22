using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Runtime.InteropServices;

namespace SeleniunNetCoreConsoleApp.Utils
{
    public static class DriversFactory
    {
        public static RemoteWebDriver GetDriver(Driver driver)
        {
            if (driver == Driver.Chrome)
            {
                ChromeOptions chromeOptions = new ChromeOptions();
                //chromeOptions.AddArgument("--headless");

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Console.WriteLine("I'm on Windowsss");
                    return new ChromeDriver(chromeOptions);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Console.WriteLine("I'm on Linuxxx");
                    return new ChromeDriver(chromeOptions);
                }
            }
            return null;
        }
        public enum Driver
        {
            Chrome,
            Explorer
        }
    }
}