using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace SeleniunNetCoreConsoleApp.Utils
{
    public static class DriversFactory
    {
        //TODO: Add Dictionary with Drivers!
        public static RemoteWebDriver GetDriver(string driver)
        {
            if(driver == "Chrome")
            {
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("--headless");
                              
                return new ChromeDriver(@"/home/sebainones/Utils/",chromeOptions);                        
            }
                
            return null;
        }
    }
}