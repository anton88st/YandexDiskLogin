using System;
using Xunit;
using Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.IO;

namespace GoogleCom
{
    public class GoogleComTest
    {
        public string  locate { get; set; }
        public GoogleComTest()
        {
            locate = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Resources\");

        }
        [Fact]
        public void Test()
        {
            EdgeDriver webDriver = new EdgeDriver(locate);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webDriver.Navigate().GoToUrl("https://google.com");
            webDriver.FindElement(By.XPath("//input[@class='gLFyf gsfi']"));
            webDriver.FindElement(By.CssSelector("input.gLFyf.gsfi"));
            webDriver.FindElement(By.XPath("//input[@class='gNO89b']"));
            webDriver.FindElement(By.CssSelector("input.gNO89b"));
            webDriver.FindElement(By.XPath("//input[@class='RNmpXc']"));
            webDriver.FindElement(By.CssSelector("input.RNmpXc"));
            webDriver.Close();
        }
    }
}
