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
using OpenQA.Selenium.Firefox;
using System.IO;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;

namespace YandexDiskLogin
{
    public class DataHelp
    {
        string Username { get; set; }
        string Password { get; set; }
        string Url { get; set; }
        string locationdrivers { get; set; }
        public IWebDriver webDriver;
        public DataHelp()
        {
            Username = "anthon.sta@yandex.by";
            Password = "Zm2vUNUfLyFDzj7";
            Url = "https://disk.yandex.ru";
            locationdrivers = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Resources\");
        }
        public IWebDriver Select(string selectdriver)
        {
            if (selectdriver == "c")
            {
                webDriver = new ChromeDriver(locationdrivers);
            }
            if (selectdriver == "f")
            {
                webDriver = new FirefoxDriver(locationdrivers);
            }
            if (selectdriver == "e")
            {
                webDriver = new EdgeDriver(locationdrivers);
            }
            return webDriver;

        }
        public void Test(IWebDriver webDriver)
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webDriver.Navigate().GoToUrl(Url);
            webDriver.FindElement(By.XPath("//a[@class='button button_login header__login-link']")).SendKeys(Keys.Enter);
            webDriver.FindElement(By.XPath("//input[@id='passp-field-login']")).Clear();
            webDriver.FindElement(By.XPath("//input[@id='passp-field-login']")).SendKeys(Username);
            webDriver.FindElement(By.XPath("//button[@class='control button2 button2_view_classic button2_size_l button2_theme_action button2_width_max button2_type_submit passp-form-button']")).Click();
            webDriver.FindElement(By.XPath("//input[@id='passp-field-passwd']")).Clear();
            webDriver.FindElement(By.XPath("//input[@id='passp-field-passwd']")).SendKeys(Password);
            webDriver.FindElement(By.XPath("//button[@class='control button2 button2_view_classic button2_size_l button2_theme_action button2_width_max button2_type_submit passp-form-button']")).Click();
            webDriver.Close();
        }
        public void Start(string browser)
        {
            Select(browser);
            VCIReports(webDriver);
        }

        
        public void VCIReports(IWebDriver webDriver)
        {
           /* IWebDriver edge = new EdgeDriver();*/
            webDriver.Navigate().GoToUrl("https://vciadmin.qa.flex.cafe/org");

            webDriver.FindElement(By.XPath("//input[@id='username']")).Clear();
            webDriver.FindElement(By.XPath("//input[@id='username']")).SendKeys("Automation_Seller");
            webDriver.FindElement(By.XPath("//input[@id='password']")).Clear();
            webDriver.FindElement(By.XPath("//input[@id='password']")).SendKeys("Password1!");
            webDriver.FindElement(By.XPath("//button[@class='btn ladda-button']")).Click();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webDriver.FindElement(By.XPath("//a[@class='nav-reports']")).Click();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10))
    .       Until(ExpectedConditions.ElementIsVisible(By.XPath("//iframe[starts-with(@src,'http')]"))); 
            webDriver.SwitchTo().Frame(webDriver.FindElement(By.XPath("//iframe[starts-with(@src,'http')]")));

            webDriver.FindElement(By.CssSelector("div.mstr-nav-icon.icon-toc")).Click();
            webDriver.FindElement(By.XPath("//a=[@aria-label='Vehicles Active page']")).Click();


            webDriver.Close();
        }
    }
}
