using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using System;

namespace MobileSolution
{
    public class BaseTest
    {
        public AppiumDriver<AndroidElement> driver;

        /// <summary>
        ///This setup tells to the server that it is going to run the test on this platform, device and application and etc
        /// </summary>
        [SetUp]
        public void Setup()
        {
            AppiumLocalService service = AppiumLocalService.BuildDefaultService();
            service.Start();

            var appPath = "C:\\Yoana\\LionsHeart\\APKs\\Jira Cloud by Atlassian_v81.1.6_apkpure.com.apk";
            
            //This appium option will help us set capabilities
            var driverOption = new AppiumOptions();
            driverOption.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Galaxy S10e"); 
            driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "9.0"); 
            driverOption.AddAdditionalCapability(MobileCapabilityType.App, appPath); 
            driverOption.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UIAutomator2");

            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), driverOption);

        }

        /// <summary>
        /// Tear down method to quit everything in the end
        /// </summary>
        [TearDown]
        public void TearDownAll()
        {
            driver.Quit();
        }
    }
}
