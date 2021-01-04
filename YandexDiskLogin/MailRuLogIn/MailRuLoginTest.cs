using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Xunit;
using Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.IO;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;

namespace MailRuLogIn
{
    public class MailRuLoginTest
    {
        public string locate { get; set; }
        public MailRuLoginTest()
        {
            locate = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Resources\");
        }
        [Fact]
        public void Test()
        {
            EdgeDriver webDriver = new EdgeDriver(locate);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            webDriver.Navigate().GoToUrl("https://mail.ru");
            webDriver.FindElement(By.XPath("//input[@id='mailbox:login']")).Clear();
            webDriver.FindElement(By.CssSelector("input[name='login']")).SendKeys("itectart_88_training");
            webDriver.FindElement(By.CssSelector("input.o-control")).Click();
            webDriver.FindElement(By.XPath("//input[@id='mailbox:password']")).Clear();
            webDriver.FindElement(By.CssSelector("input[name='password']")).SendKeys("12345678it");
            webDriver.FindElement(By.XPath("//input[@class='o-control']"));
            webDriver.FindElement(By.CssSelector("input.o-control")).Click();
            webDriver.Close();

        }
        [Fact]
        public void TestMainPage()
        {
            IWebDriver webDriver = new EdgeDriver(locate);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            webDriver.Navigate().GoToUrl("https://mail.ru");
            webDriver.FindElement(By.XPath("//input[@id='mailbox:login']")).Clear();
            webDriver.FindElement(By.CssSelector("input[name='login']")).SendKeys("itectart_88_training");
            webDriver.FindElement(By.CssSelector("input.o-control")).Click();
            webDriver.FindElement(By.XPath("//input[@id='mailbox:password']")).Clear();
            webDriver.FindElement(By.CssSelector("input[name='password']")).SendKeys("12345678it");
            webDriver.FindElement(By.XPath("//input[@class='o-control']"));
            webDriver.FindElement(By.CssSelector("input.o-control")).Click();
            webDriver.FindElement(By.CssSelector("a[href^='/sent/']")).Click();
            webDriver.FindElement(By.CssSelector("a[href^='/drafts/']")).Click();
            webDriver.FindElement(By.CssSelector("a[href^='/spam/']")).Click();
            webDriver.FindElement(By.CssSelector("a[href^='/trash/'")).Click();
            webDriver.FindElement(By.CssSelector("a[href^='/inbox/']")).Click();
            Actions action = new Actions(webDriver);
            action.MoveToElement(webDriver.FindElement(By.CssSelector("div.ll-av__container"))).Click().Perform();
            action.MoveToElement(webDriver.FindElement(By.XPath("//input[@class='mb-checkbox__input']"))).Click();
            webDriver.FindElement(By.XPath("//span[@title='Удалить']"));
            webDriver.Close();
        }
        
    }
}
