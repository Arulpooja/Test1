using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V113.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unisys.SeleConcept2
{
    public class SelAdvanceTest
    {
        [Test]
        public void Uploadtest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);
            Console.WriteLine("upload");

            driver.Url = "https://www.ilovepdf.com/pdf_to_word";
            driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(@"C:\Temp\ksrtc.pdf");
        }
    }
}
