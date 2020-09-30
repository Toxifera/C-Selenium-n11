using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using System;
namespace NUnitTestProject1
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
        
        }

        [Test]
        public void Test1()
        {
    
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(@"C:\Users\sahin\source\repos\NUnitTestProject1\NUnitTestProject1\bin\Debug\netcoreapp3.1", options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);


            driver.Url = "https://www.n11.com";
            driver.FindElement(By.ClassName("closeBtn")).Click();
            driver.FindElement(By.Id("searchData")).SendKeys("Bilgisayar");
            driver.FindElement(By.ClassName("searchBtn")).Click();

           
            //driver.FindElement(By.ClassName("closeBtn")).Click();
            //IList<IWebElement> allelements = driver.FindElements(By.XPath("/html/body/div[1]/div[3]/div/div/div[2]/section/div[2]/ul/li[10]"));
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[2]/section/div[2]/ul/li[1]/div/div[1]/a")).Click();
            driver.FindElement(By.XPath("//a[@title='Sepete Ekle']")).Click();
           

        }
    }
}