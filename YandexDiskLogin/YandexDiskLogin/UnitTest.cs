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
    }
    
}
