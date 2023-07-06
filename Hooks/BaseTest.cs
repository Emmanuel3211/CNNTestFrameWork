using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using TechTalk.SpecFlow;

namespace CNNTestFrameWork1.Hooks
{
    [Binding]
    public class BaseTest
    {
        public static IWebDriver driver;

        [BeforeScenario("@tag1")]
        public static void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver();
            //driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);

        }

        
        [AfterScenario]
        public void AfterScenario()
        {
            //driver.Close();
        }
    }
}