using System;
using Xunit;
using Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;


namespace YandexDiskLogin
{
    public class DataHelp
    {
        string Username { get; set; }
        string Password { get; set; }
        string Url { get; set; }
        public IWebDriver webDriver;
        public DataHelp()
        {
            Username = "anthon.sta@yandex.by";
            Password = "Zm2vUNUfLyFDzj7";
            Url = "https://disk.yandex.ru";
        }
        public IWebDriver Select(string selectdriver)
        {
            if (selectdriver == "c")
            {
                webDriver = new ChromeDriver(@"\YandexDiskLogin\");
            }
            if (selectdriver == "f")
            {
                webDriver = new FirefoxDriver(@"c:\Users\Antony\source\repos\YandexDiskLogin\");
            }
            if (selectdriver == "e")
            {
                webDriver = new EdgeDriver(@"c:\Users\Antony\source\repos\YandexDiskLogin\");
            }
            return webDriver;

        }
        public void Test(IWebDriver webdriver)
        {
            webDriver.Navigate().GoToUrl(Url);
            webDriver.FindElement(By.XPath("//a[@class='button button_login header__login-link']")).SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);
            webDriver.FindElement(By.XPath("//input[@id='passp-field-login']")).SendKeys("anthon.sta@yandex.by");
            webDriver.FindElement(By.XPath("//button[@class='control button2 button2_view_classic button2_size_l button2_theme_action button2_width_max button2_type_submit passp-form-button']")).SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);
            webDriver.FindElement(By.XPath("//input[@id='passp-field-passwd']")).SendKeys("Zm2vUNUfLyFDzj7");
            webDriver.FindElement(By.XPath("//button[@class='control button2 button2_view_classic button2_size_l button2_theme_action button2_width_max button2_type_submit passp-form-button']")).SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(10000);
            webDriver.Close();
        }
        public void Start(string browser)
        {
            Select(browser);
            Test(webDriver);
        }
    }
}
