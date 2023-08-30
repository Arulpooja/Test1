using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebDriver obj = new EdgeDriver();
            //@"C:\Users\mt\Downloads\chromedriver-win64\chromedriver-win64\chromedriver.exe"
            obj.Url = "http://www.facebook.com";
            string str = obj.Title;
            Console.WriteLine(str);
            string pagesource = obj.PageSource;
           Console.WriteLine(pagesource);
            obj.Quit();



        }
    }
}
