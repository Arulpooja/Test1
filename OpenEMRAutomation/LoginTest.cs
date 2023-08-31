using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unisys.Base;
using OpenQA.Selenium.Support.UI;

namespace Unisys.OpenEMRAutomation
{
    
    public class LoginTest : AutomationWrapper
    {
        [Test]
        [TestCase("admin","pass", "English (Indian)","OpenEMR Login")]
        public void ValidLoginTest(string user,string pass,string lan,string title)
        {
            driver.FindElement(By.XPath("//input[@id='authUser']")).SendKeys(user);
            driver.FindElement(By.XPath("//input[@id='clearPass']")).SendKeys(pass);
            // driver.FindElement(By.XPath("//label[text(),'")).SendKeys("pass");

            SelectElement SelLang = new SelectElement(driver.FindElement(By.XPath("//select[@name='languageChoice']")));
            SelLang.SelectByText(lan);
            Assert.That(driver.Title, Is.EqualTo(title));
            Console.WriteLine("hi");
        }


    }
}
