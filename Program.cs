using System;
using OpenQA.Selenium.Chrome;

namespace SeleniunNetCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello RPA with Selenium!");
            try 
            {
                var driver = new ChromeDriver(@"/home/sebainones/Utils/");


                driver.Navigate().GoToUrl("https://duckduckgo.com/");
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
    
        }
    }
}