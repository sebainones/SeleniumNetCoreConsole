using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniunNetCoreConsoleApp.PageRepository;
using SeleniunNetCoreConsoleApp.Utils;

namespace SeleniunNetCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello RPA with Selenium!");
            
            RemoteWebDriver driver = null;
            try
            {
                driver = DriversFactory.GetDriver(DriversFactory.Driver.Chrome);

                driver.Navigate().GoToUrl("https://duckduckgo.com/");
                System.Threading.Thread.Sleep(2000);    

                var searchBox = driver.FindElementById(DuckDuckGoHomePage.SearchBoxId);
                if (searchBox != null)
                {
                    searchBox.SendKeys("Sebastian Inones");

                    var searchButon = driver.FindElementById(DuckDuckGoHomePage.SearchButtonId);
                    System.Threading.Thread.Sleep(1000);    
                    searchButon?.Click();
                    System.Threading.Thread.Sleep(2000);    

                    var actualLinkReult = driver.FindElement(By.LinkText(DuckDuckGoHomePage.StackOverFlowLinkText));
                    if (actualLinkReult != null)
                    {
                        //Ex.: Your buisness logic in here!
                        Console.WriteLine("StackOveflow profile found!");
                        actualLinkReult.Click();
                        System.Threading.Thread.Sleep(2000);    
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                driver?.Quit();                               
            }    
        }        
    }
}