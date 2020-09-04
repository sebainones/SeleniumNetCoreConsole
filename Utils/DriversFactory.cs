using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.Runtime.InteropServices;

namespace SeleniunNetCoreConsoleApp.Utils
{
    public static class DriversFactory
    {
        //TODO: Add Dictionary or Enum with Drivers!
        public static RemoteWebDriver GetDriver(string driver)
        {
            if(driver == "Chrome")
            {
                ChromeOptions chromeOptions = new ChromeOptions();
                //chromeOptions.AddArgument("--headless");

                bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
                if (isWindows)
                    return new ChromeDriver(@"C:\Utils\", chromeOptions);
                else //Linux
                    return new ChromeDriver(@"/home/sebainones/Utils/", chromeOptions);

            }
                
            return null;
        }
    }
}