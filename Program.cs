using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
                driver = DriversFactory.GetDriver("Chrome");

                driver.Navigate().GoToUrl("https://duckduckgo.com/");

                var searchBox = driver.FindElementById(DuckDuckGoHomePage.SearchBoxId);
                if (searchBox != null)
                {
                    searchBox.SendKeys("Sebastian Inones");

                    var searchButon = driver.FindElementById(DuckDuckGoHomePage.SearchButtonId);
                    searchButon.Click();

                    var actualLinkReult = driver.FindElement(By.LinkText(DuckDuckGoHomePage.StackOverFlowLinkText));
                    if (actualLinkReult != null)
                    {
                        //Ex.: Your buisness logic in here!
                        Console.WriteLine("StackOveflow profile found!");
                        actualLinkReult.Click();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                if(driver != null)
                {
                    driver.Quit();

                }
                    
            }
    
        }
        
    }
}