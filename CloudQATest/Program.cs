using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

class CloudQATest
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        try
        {
            // Navigate to the Automation Practice Form
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
            driver.Manage().Window.Maximize();

            // Use explicit waits for elements to ensure they are available
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Test 1: Fill in the "First Name" field
            var firstName = wait.Until(drv => drv.FindElement(By.Id("fname")));
            firstName.Clear();
            firstName.SendKeys("Aman");

            // Test 2: Fill in the "Email" field
            var email = wait.Until(drv => drv.FindElement(By.Id("email")));
            email.Clear();
            email.SendKeys("aman@example.com");

            // Test 3: Select "Male" in the gender radio buttons
            var genderMale = wait.Until(drv => drv.FindElement(By.XPath("//input[@value='Male']")));
            genderMale.Click();

            // Validations
            Console.WriteLine(firstName.GetAttribute("value") == "Aman" ? "First Name Test Passed" : "First Name Test Failed");
            Console.WriteLine(email.GetAttribute("value") == "aman@example.com" ? "Email Test Passed" : "Email Test Failed");
            Console.WriteLine(genderMale.Selected ? "Gender Test Passed" : "Gender Test Failed");

            Console.WriteLine("Tests completed successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        finally
        {
            // Close the browser
            driver.Quit();
        }
    }
}
