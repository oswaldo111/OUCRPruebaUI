using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestProject1
{
    [TestClass]
    public class TestOUCR
    {
        private IWebDriver driver;

        public TestOUCR()
        {
            
            driver = new ChromeDriver();
        }
        [TestMethod]
        public void TestGuia5()
        {
            driver.Navigate().GoToUrl("https://localhost:7161/Product");

            var searchBox = driver.FindElement(By.Name("Nombre_Like"));

            searchBox.SendKeys("fanta");

            searchBox.Submit();

            System.Threading.Thread.Sleep(2000);

            Assert.IsTrue(driver.FindElement(By.XPath("//table//td[contains(text(), 'fanta')]")).Displayed, "no se encontro el nombre 'fanta' en la tabla");
        }

        public void Dispose()
        {
             driver.Quit();
        }
    }
}