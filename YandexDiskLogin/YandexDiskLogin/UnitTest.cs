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
