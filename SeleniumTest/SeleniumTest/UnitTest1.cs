using System.IO;
using System.Threading;
using System.Text;
using System.Collections;
using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;



namespace SeleniumTest
{
     class SelTest
     {

         public static void Main(string[] args)
         {
             using (var driver = new OpenQA.Selenium.Firefox.FirefoxDriver())
             {
                 // Go to the home page
                 driver.Navigate().GoToUrl("http://testing-ground.scraping.pro/login");

                 // Get the page elements
                 var userNameField = driver.FindElementById("usr");
                 var userPasswordField = driver.FindElementById("pwd");
                 var loginButton = driver.FindElementByXPath("//input[@value='Login']");

                 // Type user name and password
                 userNameField.SendKeys("admin");
                 userPasswordField.SendKeys("123456");

                 // and click the login button
                 loginButton.Click();

                 // Extract the text and save it into result.txt
                 var result = driver.FindElementByXPath("//div[@id='case_login']/h3").Text;
                 File.WriteAllText("result.txt", result);

                 // Take a screenshot and save it into screen.png
                 //driver.GetScreenshot().SaveAsFile(@"screen.png", ImageFormat.Png);
                 Thread.Sleep(1000);                
                 driver.Quit();
             }

         }
                  
     }

}