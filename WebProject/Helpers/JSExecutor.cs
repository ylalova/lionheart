using OpenQA.Selenium;

namespace WebProject.Helpers
{
    public static class JSExecutor
    {
        /// <summary>
        /// This method will execute the passed JavaScript.
        /// </summary>
        /// <param name="driver">The currently used IWebDriver.</param>
        /// <param name="script">The script as string that should be executed.</param>
        public static void RunJS(IWebDriver driver, string script)
        {
            IJavaScriptExecutor jsExe = (IJavaScriptExecutor)driver;
            jsExe.ExecuteScript(script);
        }
    }
}
