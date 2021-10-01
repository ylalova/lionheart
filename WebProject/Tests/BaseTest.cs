using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Configuration;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace WebProject.Tests
{
    public class BaseTest
    {
        /// <summary>
        /// Webdriver instance
        /// </summary>
        public IWebDriver driver;

        /// <summary>
        /// Url to the page, user will be navigated
        /// </summary>
        protected string pageUrl = ConfigurationManager.AppSettings["WebUrl"];

        /// <summary>
        /// Method which set up driver
        /// </summary>
        [SetUp]
        public void SetDriver()
        {
            InitializeBrowser();

            driver.Navigate().GoToUrl(pageUrl);
            driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Tear down method which dispose the driver
        /// </summary>
        [TearDown]
        public void QuitDriver()
        {
            driver.Dispose();
        }

        /// <summary>
        /// Method which initializes browser based on the app config settings
        /// </summary>
        public void InitializeBrowser()
        {
            switch (ConfigurationManager.AppSettings["Browser"])
            {
                case "Chrome":
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;
                case "Firefox":
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;
                case "IE":
                    new DriverManager().SetUpDriver(new InternetExplorerConfig());
                    driver = new InternetExplorerDriver();
                    break;
                case "Edge":
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;
                default:
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;
            }
        }
    }
}
