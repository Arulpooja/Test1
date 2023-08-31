using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using Unisys.Base;

namespace Unisys.OpenEMRAutomation
{
    public class LoginUiTest :AutomationWrapper
    {
       

        [Test]
        public void ValidateTitleTest()
        {

            string actualTitle = driver.Title;
            // Assert.AreEqual("OpenEMR Login", actualTitle);
            Assert.That(actualTitle, Is.EqualTo("OpenEMR Login"));
        }

        [Test]
        public void ValidatePlaceholderTest()
        {
            string actualUsernamePlaceholder = driver.FindElement(By.Id("authUser")).GetAttribute("placeholder");
            //get placeholder for password
            Assert.That(actualUsernamePlaceholder, Is.EqualTo("Username"));
            //assert the placeholder for password
        }
    }
}
