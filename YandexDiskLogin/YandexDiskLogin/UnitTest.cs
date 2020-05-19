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
   public class YandexDiskLoginTest
    {
        DataHelp myDataHelp = new DataHelp();
        [Theory]
        [InlineData("c")] //Chrome
        [InlineData("f")] //Firefox
        [InlineData("e")] //Edge
        public void TestInDiffBrowsers(string value)
        {
            myDataHelp.Start(value);
        }
        [Fact]
        public void TestInChrome()
        {
            myDataHelp.Start("c");
        }
        [Fact]
        public void TestInFirefox()
        {
            myDataHelp.Start("f");
        }
        [Fact]
        public void TestInEdge()
        {
            myDataHelp.Start("e");
        }

        [Fact]
        public void Test_Chrome()
        {
            IWebDriver chrome = new ChromeDriver(@"c:\Users\Antony\source\repos\YandexDiskLogin\");
            chrome.Navigate().GoToUrl("https://disk.yandex.ru");
            chrome.FindElement(By.XPath("//a[@class='button button_login header__login-link']")).SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);
            chrome.FindElement(By.XPath("//input[@id='passp-field-login']")).SendKeys("anthon.sta@yandex.by");
            chrome.FindElement(By.XPath("//button[@class='control button2 button2_view_classic button2_size_l button2_theme_action button2_width_max button2_type_submit passp-form-button']")).SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);
            chrome.FindElement(By.XPath("//input[@id='passp-field-passwd']")).SendKeys("Zm2vUNUfLyFDzj7");
            chrome.FindElement(By.XPath("//button[@class='control button2 button2_view_classic button2_size_l button2_theme_action button2_width_max button2_type_submit passp-form-button']")).SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(10000);
            chrome.Close();
        }
        [Fact]
        public void Test_Firefox()
        {
            IWebDriver firefox = new FirefoxDriver(@"c:\Users\Antony\source\repos\YandexDiskLogin\");
            firefox.Navigate().GoToUrl("https://disk.yandex.ru");
            firefox.FindElement(By.XPath("//a[@class='button button_login header__login-link']")).SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);
            firefox.FindElement(By.XPath("//input[@id='passp-field-login']")).SendKeys("anthon.sta@yandex.by");
            firefox.FindElement(By.XPath("//button[@class='control button2 button2_view_classic button2_size_l button2_theme_action button2_width_max button2_type_submit passp-form-button']")).SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);
            firefox.FindElement(By.XPath("//input[@id='passp-field-passwd']")).SendKeys("Zm2vUNUfLyFDzj7");
            firefox.FindElement(By.XPath("//button[@class='control button2 button2_view_classic button2_size_l button2_theme_action button2_width_max button2_type_submit passp-form-button']")).SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(10000);
            firefox.Close();
        }

    }
    
}
