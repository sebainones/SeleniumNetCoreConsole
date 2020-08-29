using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniunNetCoreConsoleApp.PageRepository;

namespace SeleniunNetCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello RPA with Selenium!");
            
            ChromeDriver driver = null;

            try 
            {
                 driver = new ChromeDriver(@"/home/sebainones/Utils/");

                driver.Navigate().GoToUrl("https://duckduckgo.com/");

                var searchBox =  driver.FindElementById(DuckDuckGoHomePage.SearchBoxId);
                if(searchBox != null)
                {
                    searchBox.SendKeys("Sebastian Inones");

                    var searchButon = driver.FindElementById(DuckDuckGoHomePage.SearchButtonId);
                    searchButon.Click();                    

                    var actualLinkReult = driver.FindElement(By.LinkText(DuckDuckGoHomePage.StackOverFlowLinkText));
                    if(actualLinkReult != null)
                    {
                        actualLinkReult.Click();
                    }                    
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                if(driver != null)
                    driver.Close();
            }
    
        }
    }
}