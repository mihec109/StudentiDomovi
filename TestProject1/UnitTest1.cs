using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Drawing;
using System.Threading;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string IE_DRIVER_PATH = @"C:\Users\mihah\OneDrive\Desktop";
        private const string ScreenShotLocation = @"C:\ScreenShot";
        [TestMethod]
        [Obsolete]
        public void Get()
        {
            IWebDriver driver = null;
            try
            {
                FirefoxOptions options = new FirefoxOptions();
                options.AddAdditionalCapability("acceptInsecureCerts", true, true);
                driver = new FirefoxDriver(IE_DRIVER_PATH, options);

                driver.Navigate().GoToUrl("https://localhost:44343/");
                IWebElement enter2 = driver.FindElement(By.Id("dd"));
                enter2.Click();
                TestScreen(driver, "StartStudentov");

                driver.Navigate().GoToUrl("https://localhost:44343/");
                IWebElement enter22 = driver.FindElement(By.Id("ok"));
                enter22.Click();
                TestScreen(driver, "StartDomov");

                driver.Navigate().GoToUrl("https://localhost:44343/");
                IWebElement enter = driver.FindElement(By.Id("ena"));
                enter.Click();
                TestAddStudent(driver);
                driver.Navigate().GoToUrl("https://localhost:44343/");
                IWebElement enter5 = driver.FindElement(By.Id("dd"));
                enter5.Click();
                TestScreen(driver, "AfterAdd");
                TestDeleteStudent(driver);
                TestScreen(driver, "AfterRightDelete");
                TestDeleteStudent2(driver);
                TestScreen(driver, "AfterWrongDelete");

                driver.Navigate().GoToUrl("https://localhost:44343/");
                IWebElement enter8 = driver.FindElement(By.Id("hh"));
                enter8.Click();
                TestAddDomovi2(driver);

                driver.Navigate().GoToUrl("https://localhost:44343/");
                IWebElement enter88 = driver.FindElement(By.Id("ok"));
                enter88.Click();
                TestScreen(driver, "AfterRightAddd");
            }
            finally
            {
                driver.Quit();
            }
            
        }

        private void TestDeleteStudent(IWebDriver driver)
        {
            IWebElement Vpisna_Stevilka = driver.FindElement(By.Id("Vpisna_Stevilka"));
            Vpisna_Stevilka.SendKeys("566");
            IWebElement Submit = driver.FindElement(By.Id("Submit"));
            Submit.Click();
        }

        private void TestDeleteStudent2(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement Vpisna_Stevilka = driver.FindElement(By.Id("Vpisna_Stevilka"));
            Vpisna_Stevilka.SendKeys("efwec");
            IWebElement Submit = driver.FindElement(By.Id("Submit"));
            Submit.Click();

            IAlert alert = null;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until((d) => { alert = d.SwitchTo().Alert(); return alert; });
            alert.Accept();

        }

        private void TestAddStudent(IWebDriver driver)
        {
            driver.Manage().Window.Size = new Size(1024, 768);
            IWebElement Ime = driver.FindElement(By.Id("Ime"));
            IWebElement Priimek = driver.FindElement(By.Id("Priimek"));
            IWebElement Vpisna_stevilka = driver.FindElement(By.Id("Vpisna_stevilka"));
            IWebElement Submit = driver.FindElement(By.Id("Submit"));

            Ime.SendKeys("DIVHSBIDVHB");
            Priimek.SendKeys("hirtlicccc");
            Vpisna_stevilka.SendKeys("3535");
            Submit.Click();
        }

        private void TestAddDomovi2(IWebDriver driver)
        {
            IWebElement Leto_zgradnje = driver.FindElement(By.Id("Leto_zgradnje"));
            IWebElement Naslov = driver.FindElement(By.Id("Naslov"));
            IWebElement Stevilka = driver.FindElement(By.Id("Stevilka"));
            IWebElement Submit = driver.FindElement(By.Id("Submit"));

            Leto_zgradnje.SendKeys("2001");
            Naslov.SendKeys("Tomarjeva 5");
            Stevilka.SendKeys("4");
            Submit.Click();
        }

        public void TestScreen(IWebDriver driver, string type)
        {
            Thread.Sleep(1000);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(ScreenShotLocation + "\\" + type + "ScreenList.Png", OpenQA.Selenium.ScreenshotImageFormat.Png);
        }
    } 
}
