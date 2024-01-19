using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TalkyTina
{
    internal class test
    {
        IWebDriver driver = new ChromeDriver();
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://benporter.pro/TalkyTina");
        }

        public void ExecuteTest()
        {
            IWebElement element = driver.FindElement(By.Name("inputDiv"));
            element.SendKeys("somekeys");
        }

        public void ClearMemory()
        {
            driver.Close();
        }
    }
}
